using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairShopAccounting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string admincode = txtadmincode.Text;
                string email = txtemail.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\CarRepairShopAccounting\CarRepairShopAccounting\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string AdminCode = read["AdminCode"].ToString();
                    string e_mail = read["e_mail"].ToString();
                    if (admincode == AdminCode && email == e_mail)
                    {
                        MessageBox.Show("Username = admin & Password = admin", "User information");
                        this.Hide();

                    }
                    else
                        MessageBox.Show("کد عددی کاربر یا ایمیل کاربر اشتباه است","Error");
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
