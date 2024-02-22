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
    public partial class T_Routine : Form
    {
        public T_Routine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8S1SAKC\\SQLEXPRESS;Initial Catalog=ifty;Integrated Security=True");
        void BindData3()
        {
            SqlCommand command = new SqlCommand("select * from T_Routine", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void T_Routine_Load(object sender, EventArgs e)
        {
            BindData3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into T_Routine values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "', '" + comboBox3.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            con.Close();
            BindData3();
        }
    }
}
