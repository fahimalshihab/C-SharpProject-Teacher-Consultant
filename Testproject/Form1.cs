using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Testproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8S1SAKC\\SQLEXPRESS;Initial Catalog=ifty;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username, user_password;
             username = text_username.Text;
            user_password = text_password.Text;
            try
            {
                string querry = " SELECT * FROM Login_new WHERE username = '"+text_username.Text+"' AND password ='"+text_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0 )
                {
                    username = text_username.Text;
                    user_password = text_password.Text;

                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_username.Clear();
                    text_password.Clear();

                    text_username.Focus();



                }


            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fsignup = new Form2();
            fsignup.Show();
            this.Hide();
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            text_username.Clear();
            text_password.Clear();

            text_username.Focus();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home mf2 = new Home();
            mf2.Show();
            this.Hide();
        }
    }
}
