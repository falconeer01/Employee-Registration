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

namespace Employee_Registration
{
    public partial class FormEntrance : Form
    {
        public FormEntrance()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2AK7Q68\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True");

        private void connBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand comm = new SqlCommand(
                "select * from userInfos " + 
                "where userName = @p1 and userPassword = @p2"
            , conn);

            comm.Parameters.AddWithValue("@p1", userNameBox.Text);
            comm.Parameters.AddWithValue("@p2", passBox.Text);

            SqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong info", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
