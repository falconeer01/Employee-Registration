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
    public partial class FormGraphics : Form
    {
        public FormGraphics()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2AK7Q68\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True");

        private void FormGraphics_Load(object sender, EventArgs e)
        {
            // Şehirler
            conn.Open();

            SqlCommand comm1 = new SqlCommand(
                "select city, count(city) from employees " + 
                "group by city"
            , conn);

            SqlDataReader dr1 = comm1.ExecuteReader();

            while (dr1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dr1[0], dr1[1]);
            }

            conn.Close();

            // Maaşlar:
            conn.Open();

            SqlCommand comm2 = new SqlCommand(
                "select job, avg(salary) from employees " + 
                "group by job"
            , conn);

            SqlDataReader dr2 = comm2.ExecuteReader();

            while (dr2.Read()) 
            {
                chart2.Series["Salaries"].Points.AddXY(dr2[0], dr2[1]);
            }

            conn.Close();
        }
    }
}
