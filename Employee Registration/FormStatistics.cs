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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2AK7Q68\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True");

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            // Toplam personel sayısı:
            conn.Open();

            SqlCommand comm1 = new SqlCommand(
                "select count(*) from employees", conn);

            SqlDataReader dr1 = comm1.ExecuteReader();

            while (dr1.Read()) 
            {
                totalPerLbl.Text = dr1[0].ToString();
            }

            conn.Close();


            // Evli personel sayısı:
            conn.Open();

            SqlCommand comm2 = new SqlCommand(
                "select count(*) from employees " +
                "where Mstatus = 1"
            , conn);

            SqlDataReader dr2 = comm2.ExecuteReader();

            while (dr2.Read()) 
            {
                marriedPerLbl.Text = dr2[0].ToString();
            }

            conn.Close();

            // Bekar personel sayısı:
            conn.Open();

            SqlCommand comm3 = new SqlCommand(
                "select count(*) from employees " +
                "where Mstatus = 0"
            , conn);

            SqlDataReader dr3 = comm3.ExecuteReader();

            while (dr3.Read())
            {
                singlePerLbl.Text = dr3[0].ToString();
            }

            conn.Close();

            // Farklı şehirler:
            conn.Open();

            SqlCommand comm4 = new SqlCommand(
                "select count(distinct city) as unique_cities from employees"
            , conn);

            SqlDataReader dr4 = comm4.ExecuteReader();

            while (dr4.Read())
            { 
                nofCitiesLbl.Text = dr4[0].ToString();
            }

            conn.Close();

            // Maaşların toplamı:
            conn.Open();

            SqlCommand comm5 = new SqlCommand(
                "select sum(salary) from employees"
            , conn);

            SqlDataReader dr5 = comm5.ExecuteReader();

            while (dr5.Read())
            { 
                salariesSumLbl.Text = dr5[0].ToString();
            }

            conn.Close();

            // Maaşların ortalaması:
            conn.Open();

            SqlCommand comm6 = new SqlCommand(
                "select avg(salary) from employees"
            , conn);

            SqlDataReader dr6 = comm6.ExecuteReader();

            while (dr6.Read())
            { 
                salariesAvgLbl.Text = dr6[0].ToString();
            }

            conn.Close();
        }
    }
}
