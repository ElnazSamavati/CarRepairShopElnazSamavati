using System.Data.SqlClient;

namespace CarRepairShopAccounting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
Panel p = new Panel();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = usertxt.Text;
                string pass = passtxt.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\CarRepairShopAccounting\CarRepairShopAccounting\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string username = read["Username"].ToString();
                    string password = read["Password"].ToString();
                    if (user == username && pass == password)
                    {

                        p.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است","Error");
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}