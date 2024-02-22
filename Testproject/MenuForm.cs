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

namespace Testproject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8S1SAKC\\SQLEXPRESS;Initial Catalog=ifty;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand command = new SqlCommand("insert into info_T values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "', getdate(),getdate())", con);
             command.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            con.Close();
            BindData();
         }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from info_T", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void BindData2()
        {
            SqlCommand command = new SqlCommand("select * from TR1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            BindData();
            BindData2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update info_T set Name = '"+textBox2.Text+"', subject = '"+comboBox1.Text+ "',slot = '"+comboBox2.Text+"',Update = '" + DateTime.Parse(dateTimePicker1.Text)+"' where ID = '"+int.Parse(textBox1.Text)+"'",con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully updated");
            BindData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                if (MessageBox.Show("Are you sure you wanna Delete?", "Delete Record", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete info_T where ID = '" + int.Parse(textBox1.Text) + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("input product ID");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home fl1 = new Home();
            fl1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Teachers_form ft = new Teachers_form();
            ft.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
