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
    public partial class Sign_UP : Form
    {
        static string sql = "Data Source=Saleh;Initial Catalog=bank_data;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        public object SqlCommand { get; private set; }

        public Sign_UP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sign_UP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string signup_queury = "INSERT INTO Customer (SSN, name, phone, address) VALUES (@SSN, @name, @phone, @address);" +
                "INSERT INTO Account (SSN,type) VALUES (@SSN,@type)";
            SqlCommand cmd  = new SqlCommand(signup_queury,con);
            cmd.Parameters.AddWithValue("@SSN", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox2.Text);
            cmd.Parameters.AddWithValue("@type", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account created");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
