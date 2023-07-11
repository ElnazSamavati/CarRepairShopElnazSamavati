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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;


namespace CarRepairShopAccounting
{
    public partial class Customers : Form
    {

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
        }

        private void btnnewcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                string birthday = txtbirthday.Text;
                string mobile = txtmobile.Text;
                string phone = txtphone.Text;
                string address = txtaddress.Text;
                string gender = cmbgender.Text;
                string ncode = txtncode.Text;

                SqlConnection sc1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\CarRepairShopAccounting\CarRepairShopAccounting\Database1.mdf;Integrated Security=True");
                sc1.Open();
                string query = "INSERT INTO Customers (name,mobile,telephone,gender,birthday,n_code,address) VALUES (N'" + name + "',N'" + mobile + "',N'" + phone + "',N'" + gender + "',N'" + birthday + "',N'" + ncode + "',N'" + address + "')";
                SqlCommand com1 = new SqlCommand(query, sc1);
                com1.ExecuteNonQuery();
                sc1.Close();
                MessageBox.Show("ثبت مشتری جدید با موفقیت انجام شد", "Information");
                txtname.Text = txtbirthday.Text = txtmobile.Text = txtphone.Text = txtaddress.Text = cmbgender.Text = txtncode.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtcustomercode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {

            if (comboBox1.Items.Count == 0)
            {
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\source\\repos\\CarRepairShopAccounting\\CarRepairShopAccounting\\Database1.mdf;Integrated Security=True");
                string query = "SELECT name FROM [Customers]";
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sc.Open();
                cmd.ExecuteScalar();
                sc.Close();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i]["name"]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string birthday = txtbirthday2.Text;
            string mobile = txtmobile2.Text;
            string phone = txtphone2.Text;
            string address = txtaddress2.Text;
            string gender = cmbgender2.Text;
            string ncode = txtncode2.Text;
           
            if (name == "")
            {
                txtbirthday2.Text = txtmobile2.Text = txtphone2.Text = txtaddress2.Text = cmbgender2.Text = txtncode2.Text = "";
                comboBox1.Enabled = true;
            }
            else
            {
                try
                {
                    comboBox1.Enabled = false;
                    SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\CarRepairShopAccounting\CarRepairShopAccounting\Database1.mdf;Integrated Security=True");
                    sc.Open();
                    SqlCommand comm = new SqlCommand("SELECT * FROM Customers WHERE name= N'" + name + "'", sc);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Text = reader["name"].ToString();
                        txtbirthday2.Text = reader["birthday"].ToString();
                        txtmobile2.Text = reader["mobile"].ToString();
                        txtphone2.Text = reader["telephone"].ToString();
                        txtaddress2.Text = reader["address"].ToString();
                        cmbgender2.Text = reader["gender"].ToString();
                        txtncode2.Text = reader["n_code"].ToString();
                        
                    }

                    sc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btneditcustomer_Click(object sender, EventArgs e)
        {
            try 
            {
                string name = comboBox1.Text;
                string birthday = txtbirthday2.Text;
                string mobile = txtmobile2.Text;
                string phone = txtphone2.Text;
                string address = txtaddress2.Text;
                string gender = cmbgender2.Text;
                string ncode = txtncode2.Text;

                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\CarRepairShopAccounting\CarRepairShopAccounting\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query= "UPDATE Customers SET mobile = N'" + mobile + "', telephone = N'" + phone + "', gender = N'" + gender + "', birthday = N'" + birthday + "',n_code = N'" + ncode + "',address = N'" + address + "' WHERE name = N'"+name+"'";
                SqlCommand com = new SqlCommand(query, sc);
                com.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("ویرایش مشتری با موفقیت انجام شد", "Information");
                comboBox1.Text = txtbirthday2.Text = txtmobile2.Text = txtphone2.Text = txtaddress2.Text = cmbgender2.Text = txtncode2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
