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
    public partial class AddEmployee : Form
    {
        private int IdEmpl;
        public AddEmployee(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            Dolznost.Height = 24;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_menu admin = new Admin_menu(IdEmpl);
            Hide();
            admin.ShowDialog();
            Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Employees (Name, Surname, Post, Salary, PhoneNumber, Date) VALUES (?, ?, ?, ?, ?, ?)", cn);
            command.Parameters.AddWithValue("@Name", NameEmp.Text);
            command.Parameters.AddWithValue("@Surname", Surname.Text);
            command.Parameters.AddWithValue("@Dol", Dolznost.Text);
            command.Parameters.AddWithValue("@Zarplata", ZP.Text);
            command.Parameters.AddWithValue("@Telefon", tfnumber.Text);
            command.Parameters.AddWithValue("@Data", date.Value);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee added", "Add", MessageBoxButtons.OK);

            OleDbCommand command2 = new OleDbCommand("INSERT INTO Users (Login, Password, Surname) VALUES (?, ?, ?)", cn);
            command2.Parameters.AddWithValue("@Login", Login.Text);
            command2.Parameters.AddWithValue("@Pass", Password.Text);
            command2.Parameters.AddWithValue("@Surname", Surname.Text);
            command2.ExecuteNonQuery();

            OleDbCommand command3 = new OleDbCommand("INSERT INTO EmployeeUsers (IdEmployee, IdUser) VALUES ((SELECT IdEmployee FROM Employees WHERE Surname = ?), " +
                                "(SELECT IdUser FROM Users WHERE Surname = ?))", cn);
            command3.Parameters.AddWithValue("@Surname", Surname.Text);
            command3.Parameters.AddWithValue("@Surname", Surname.Text);
        }
    }

}
