using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursach
{
    public partial class DeleteEmployee : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public DeleteEmployee(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            //id_employe.Enabled = false;
            NameEmp.Enabled = false;
            Surname.Enabled = false;

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Employees");
            emp.Columns.Add("IdEmployee", typeof(int));
            emp.Columns.Add("Name", typeof(string));
            emp.Columns.Add("Surname", typeof(string));
            emp.Columns.Add("Post", typeof(string));

            dgEmp.SetDataBinding(dSet, "Employees");
            update();
            delete_button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_menu admin = new Admin_menu(IdEmpl);
            Hide();
            admin.ShowDialog();
            Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteEmp = new OleDbCommand("DELETE FROM Employees WHERE IdEmployee = ?", cn);
            deleteEmp.Parameters.Add("@IdEmployee", OleDbType.Integer);
            deleteEmp.Parameters[0].Value = comboBox1.SelectedItem;
            deleteEmp.ExecuteNonQuery();
            MessageBox.Show("Employee deleted", "Delete", MessageBoxButtons.OK);
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Employees");
            update();
        }
        private void update()
        {
            OleDbCommand selectID = new OleDbCommand("SELECT IdEmployee FROM Employees", cn);
            OleDbDataReader reader = selectID.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["IdEmployee"]);
            }
            reader.Close();
        }
        private void Show_button_Click(object sender, EventArgs e)
        {
            OleDbCommand selectEmp = new OleDbCommand("SELECT IdEmployee, Name, Surname, Post FROM Employees ", cn);

            selectEmp.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectEmp;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Employees");

            comboBox1.Items.Clear();
            update();
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Employees");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            OleDbCommand selectEmp = new OleDbCommand("SELECT Name, Surname From Employees WHERE IdEmployee = ?", cn);

            selectEmp.Parameters.AddWithValue("@ID", Convert.ToInt32(comboBox1.Text));
            OleDbDataReader reader = selectEmp.ExecuteReader();
            reader.Read();
            NameEmp.Text = reader["Name"].ToString();
            Surname.Text = reader["Surname"].ToString();
            NameEmp.Enabled = true;
            Surname.Enabled = true;
            delete_button.Enabled = true;
            reader.Close();
            selectEmp.ExecuteNonQuery();
        }
    }
}
