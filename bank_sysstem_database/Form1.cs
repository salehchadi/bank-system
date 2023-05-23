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
    public partial class Form1 : Form
    {
        static string sql = "Data Source=Saleh;Initial Catalog=bank_data;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable LoadCustomers()
        {
            DataTable dt = new DataTable();
            string customers_query = "SELECT SSN,name,phone,address FROM Customer";
            con.Open();
            SqlCommand cmd = new SqlCommand(customers_query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable loadAccounts()
        {
            DataTable dt = new DataTable();
            string customers_query = "SELECT a.SSN,c.name,a.account_number,a.type,c.phone,c.address,a.balance,c.branch_number " +
                "FROM Account a JOIN Customer c ON a.SSN = c.SSN;";
            con.Open();
            SqlCommand cmd = new SqlCommand(customers_query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadCustomers();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loadAccounts();
        }
        //cc
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            // Delete related records in Account table
            string deleteAccountsQuery = "DELETE FROM Account WHERE SSN = @CurrentSSN";
            SqlCommand deleteAccountsCmd = new SqlCommand(deleteAccountsQuery, con);
            deleteAccountsCmd.Parameters.AddWithValue("@CurrentSSN", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            deleteAccountsCmd.ExecuteNonQuery();

            // Update SSN value in Customer table
            string updateCustomerQuery = "UPDATE Customer SET SSN = @NewSSN WHERE SSN = @CurrentSSN";
            SqlCommand updateCustomerCmd = new SqlCommand(updateCustomerQuery, con);
            updateCustomerCmd.Parameters.AddWithValue("@NewSSN", "11111111");
            updateCustomerCmd.Parameters.AddWithValue("@CurrentSSN", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            updateCustomerCmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Customer deleted!");
            dataGridView1.DataSource = loadAccounts();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {   con.Open();
            
            string update_info_query = "UPDATE Customer SET name = @name, phone = @phone, address = @address WHERE SSN = @SSN;"; 
            SqlCommand cmd = new SqlCommand(update_info_query, con);
            cmd.Parameters.AddWithValue("@SSN", textBox1.Text);
            cmd.Parameters.AddWithValue("@name",textBox5.Text);
            cmd.Parameters.AddWithValue("@phone", textBox6.Text);
            cmd.Parameters.AddWithValue("@address",textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            dataGridView1.DataSource = loadAccounts();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string update_info_query = "UPDATE Account SET balance =@balance  WHERE SSN = @SSN;";
            SqlCommand cmd = new SqlCommand(update_info_query, con);
            cmd.Parameters.AddWithValue("@SSN", textBox1.Text);
            cmd.Parameters.AddWithValue("@balance", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            dataGridView1.DataSource = loadAccounts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_customer_query = "Delete from Account Where SSN=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(@delete_customer_query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account deleted");
            dataGridView1.DataSource = loadAccounts();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_UP sign = new Sign_UP();
            sign.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_in l = new log_in();
            l.Show();
        }
    }
}
