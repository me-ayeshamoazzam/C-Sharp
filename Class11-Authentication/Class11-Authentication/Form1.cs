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

namespace Class11_Authentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text ;
            string age = textBox3.Text ;

            string connectionString = "Data Source=DESKTOP-VQDPLPC;Initial Catalog=login;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM users WHERE name=@name AND age=@age";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);

            con.Open();

            int count = (int)cmd.ExecuteScalar();

            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid name or age", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
