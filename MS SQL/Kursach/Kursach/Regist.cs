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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Visitors (Name, Surname, PhoneNumber) VALUES (?, ?, ?)", cn);
            command.Parameters.AddWithValue("@Name", Name.Text);
            command.Parameters.AddWithValue("@Surname", Surname.Text);
            command.Parameters.AddWithValue("@Telefon", Phone.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("You Successfully registered", "Success", MessageBoxButtons.OK);

            OleDbCommand command2 = new OleDbCommand("INSERT INTO Users (Login, Password, Surname) VALUES (?, ?, ?)", cn);
            command2.Parameters.AddWithValue("@Login", Login.Text);
            command2.Parameters.AddWithValue("@Pass", Password.Text);
            command2.Parameters.AddWithValue("@Surname", Surname.Text);
            command2.ExecuteNonQuery();

            OleDbCommand command3 = new OleDbCommand("INSERT INTO VisitorUsers (IdVisitor, IdUser) VALUES ((SELECT IdVisitor FROM Visitors WHERE Surname = ?), " +
                                "(SELECT IdUser FROM Users WHERE Surname = ?))", cn);
            command3.Parameters.AddWithValue("@Surname", Surname.Text);
            command3.Parameters.AddWithValue("@Surname", Surname.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormN vis = new MainFormN();
            Hide();
            vis.ShowDialog();
            Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
