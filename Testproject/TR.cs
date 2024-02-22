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

namespace Testproject
{
    public partial class TR : Form
    {
        public TR()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8S1SAKC\\SQLEXPRESS;Initial Catalog=ifty;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {

            
  
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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TR_Load(object sender, EventArgs e)
        {
            BindData();
            BindData2();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update TR1 set Name = '" + textBox2.Text + "', subject = '" + comboBox1.Text + "',slot = '" + comboBox2.Text + "',confirmation = '" + comboBox3.Text + "',s_name = '" + textBox3.Text + "' where ID = '" + int.Parse(textBox1.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully updated");
            BindData2();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into TR1 values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox3.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            con.Close();
            BindData2();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home fl1 = new Home();
            fl1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home fl2 = new Home();
            fl2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            T_Routine fl1 = new T_Routine();
            fl1.Show();
            this.Hide();
        }
    }
    }

