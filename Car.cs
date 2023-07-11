using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRepairShopAccounting
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cartag = txtcartag.Text;
            string type = cmbtype.Text;
            string model = txtmodel.Text;
            string brand = txtbrand.Text;
            string color = txtcolor.Text;
            string insurace = txtinsurace.Text;
            string vin = txtvin.Text;
            string odometer = txtodometer.Text;
            string vfc = txtvfc.Text;
            string rs = cmbrepairstatus.Text;
            string rt = txtrepairtype.Text;
            string service = txtservices.Text;
            string ncode = cmbcustomer.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\CarRepairShopAccounting\CarRepairShopAccounting\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO Car (CarTag,type,model,brand,color,insurace,VIN,odometer,vfc,repairstatus,repair_type,services,n_code) VALUES (N'" + cartag + "',N'" + type + "',N'" + model + "',N'" + brand + "',N'" + color + "',N'" + insurace + "',N'" + vin + "', '"+odometer+"', '"+vfc+"','"+rs+"','"+rt+"', '"+service+"','"+ncode+"')";
            SqlCommand c = new SqlCommand(query, sc);
            c.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("ثبت مشتری جدید با موفقیت انجام شد", "Information");
        }
    }
}
