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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear(Control comp) 
        {
            if (comp is RadioButton radioButton)
            {
                radioButton.Checked = false;
            }
            else 
            {
                comp.Text = "";
            }
        }

        public void reflectData(Control comp, DataGridView dataGridView, int cellIndex) 
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;

            if (comp is RadioButton radioButton)
            {
                if (dataGridView.Rows[rowIndex].Cells[cellIndex].Value is bool value && value == true)
                {
                    radioButton.Checked = true;
                }
                else 
                { 
                    radioButton.Checked = false; 
                }
            }
            else 
            {
                comp.Text = dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
            }
        }

        public void reflectDataForRadioS(RadioButton radioButton, DataGridView dataGridView, int cellIndex)
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;

            if (dataGridView.Rows[rowIndex].Cells[cellIndex].Value is bool value && value == true)
            {
                radioButton.Checked = false;
            }
            else
            {
                radioButton.Checked = true;
            }
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2AK7Q68\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataSet1.employees);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand comm = new SqlCommand(
                "insert into employees (name, surname, city, salary, job, Mstatus) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6)", conn
            );
            comm.Parameters.AddWithValue("@p1", nameBox.Text);
            comm.Parameters.AddWithValue("@p2", surnameBox.Text);
            comm.Parameters.AddWithValue("@p3", cityBox.Text);
            comm.Parameters.AddWithValue("@p4", salaryBox.Text);
            comm.Parameters.AddWithValue("@p5", jobBox.Text);
            comm.Parameters.AddWithValue("@p6", radioM.Checked ? 1 : 0);
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("A new employee added to the database.");

            clear(IDBox);
            clear(nameBox);
            clear(surnameBox);
            clear(cityBox);
            clear(salaryBox);
            clear(jobBox);
            clear(radioM);
            clear(radioS);
        }

        public void radioM_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void radioS_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear(IDBox);
            clear(nameBox);
            clear(surnameBox);
            clear(cityBox);
            clear(salaryBox);
            clear(jobBox);
            clear(radioM);
            clear(radioS);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            //IDBox.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            reflectData(IDBox, dataGridView1, 0);
            reflectData(nameBox, dataGridView1, 1);
            reflectData(surnameBox, dataGridView1, 2);
            reflectData(cityBox, dataGridView1, 3);
            reflectData(salaryBox, dataGridView1, 4);
            reflectData(radioM, dataGridView1, 5);
            reflectDataForRadioS(radioS, dataGridView1, 5);
            reflectData(jobBox, dataGridView1, 6);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand comm = new SqlCommand(
                "delete from employees where id = @k1;", conn
            );

            comm.Parameters.AddWithValue("@k1", IDBox.Text);
            comm.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Employee deleted from the database.");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand comm = new SqlCommand(
                "update employees " +
                "set name = @p1, " +
                "surname = @p2, " +
                "city = @p3, " +
                "salary = @p4, " +
                "Mstatus = @p5, " +
                "job = @p6 " +
                "where id = @p0"
            , conn);

            comm.Parameters.AddWithValue("@p0", IDBox.Text);
            comm.Parameters.AddWithValue("@p1", nameBox.Text);
            comm.Parameters.AddWithValue("@p2", surnameBox.Text);
            comm.Parameters.AddWithValue("@p3", cityBox.Text);
            comm.Parameters.AddWithValue("@p4", salaryBox.Text);
            comm.Parameters.AddWithValue("@p5", radioM.Checked ? 1 : 0);
            comm.Parameters.AddWithValue("@p6", jobBox.Text);
            comm.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Updated the chosen employee");
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            FormStatistics frmStats = new FormStatistics();
            frmStats.Show();
        }

        private void graphicsBtn_Click(object sender, EventArgs e)
        {
            FormGraphics frmGraphs = new FormGraphics();
            frmGraphs.Show();
        }
    }
}
