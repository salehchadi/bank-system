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

namespace bank_sysstem_database
{
    public partial class log_in : Form
    {
        static string sql = "Data Source=Saleh;Initial Catalog=bank_data;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        public log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            con.Open(); 
            this.Hide();
            Sign_UP sign= new Sign_UP();
            sign.Show();
            con.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string SSN  , Acc_nB , type , password;
            SSN = textBox1.Text;
            Acc_nB = textBox3.Text;
            password = textBox2.Text;
            type = comboBox1.Text;
            try {
                string login_query = "SELECT * FROM Customer,Account ;" +
                                     "WHERE c.SSN = a.SSN AND c.SSN = '"+ textBox1.Text + "' AND account_number='" + textBox3.Text  + "' AND type = '" + comboBox1.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(login_query,con);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);
                if ( dt.Rows.Count > 0) {
                    SSN = textBox1.Text;
                    Acc_nB = textBox3.Text;
                    password = textBox2.Text;
                    type = (string)comboBox1.Text;
                    MessageBox.Show("Logged in! ");
                    this.Close();
                    con.Close();

                }
            }
            catch {
                MessageBox.Show("Account not found");
            }
            finally {
            con.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
       public string SSN { get; set; }
        public string Acc_nB { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        
}
}
