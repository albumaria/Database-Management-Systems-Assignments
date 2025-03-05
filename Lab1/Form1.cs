using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1: Form
    {
        String connectionString = @"Data Source=DESKTOP-6QSI2DC\MSSQLSERVER01;Initial Catalog=Cat_Cafe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection cs = new SqlConnection("Data Source=DESKTOP-6QSI2DC\\MSSQLSERVER01;Initial Catalog=Cat_Cafe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsStaff = new DataSet();
        DataSet dsShifts = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM Staff", cs);
            dsStaff.Clear();
            da.Fill(dsStaff);
            dataGridViewStaff.DataSource = dsStaff.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(connectionString);
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();

                    MessageBox.Show("Test conn. succeeded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertCommand = new SqlCommand("INSERT INTO Staff (staff_id, last_name, first_name, age, cnp)" +
                    "VALUES (@s, @l, @f, @a, @c)", cs);

                da.InsertCommand.Parameters.Add("@s", SqlDbType.Int).Value = Int32.Parse(textBoxStaffId.Text);
                da.InsertCommand.Parameters.Add("@l", SqlDbType.VarChar).Value = textBoxLastName.Text;
                da.InsertCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = textBoxFirstName.Text;
                da.InsertCommand.Parameters.Add("@a", SqlDbType.Int).Value = Int32.Parse(textBoxAge.Text);
                da.InsertCommand.Parameters.Add("@c", SqlDbType.VarChar).Value = textBoxCnp.Text;

                cs.Open();
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted Staff Member Successfully");
                cs.Close();
                dsStaff.Clear();
                da.Fill(dsStaff);
                dataGridViewStaff.DataSource = dsStaff.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridViewStaff.Rows[e.RowIndex];

                    int staffId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    da.SelectCommand = new SqlCommand("SELECT * FROM Shifts WHERE staff_id = @f", cs);
                    da.SelectCommand.Parameters.Add("@f", SqlDbType.Int).Value = staffId;
                    dsShifts.Clear();
                    da.Fill(dsShifts);
                    dataGridViewShifts.DataSource = dsShifts.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
            
        }

    }
}
