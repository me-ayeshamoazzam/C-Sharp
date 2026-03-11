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

namespace Class10_DatabaseInsertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=DESKTOP-VQDPLPC;Initial Catalog=school;Integrated Security=True"
                ))

            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO students(ID, Name,Age) VALUES (@id, @name , @age)", con))
                {
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    cmd.ExecuteNonQuery();
                }
            }
                MessageBox.Show(
                "Data Saved",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=DESKTOP-VQDPLPC;Initial Catalog=school;Integrated Security=True"
                ))

            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE students SET name=@name, age=@age WHERE id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBox3.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show(
            "Data Updated",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes) {
                using (SqlConnection con = new SqlConnection(
                    "Data Source=DESKTOP-VQDPLPC;Initial Catalog=school;Integrated Security=True"
                    ))

                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM students WHERE id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox3.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(
                "Data Deleted",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=DESKTOP-VQDPLPC;Initial Catalog=school;Integrated Security=True"
                ))

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM students", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
