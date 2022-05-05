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
    public partial class DeleteDish : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public DeleteDish(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Menu");
            emp.Columns.Add("IdDish", typeof(int));
            emp.Columns.Add("Name", typeof(string));
            emp.Columns.Add("CostPrice", typeof(int));
            emp.Columns.Add("Price", typeof(int));
            emp.Columns.Add("Description", typeof(string));

            dgMenu.SetDataBinding(dSet, "Menu");
            update();
        }

        private void update()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Menu", cn);
            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                ComBox.Items.Add(reader["Name"]);
            }
            reader.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Cook_menu cook = new Cook_menu(IdEmpl);
            Hide();
            cook.ShowDialog();
            Close();
        }

        private void ShowMenu_Click(object sender, EventArgs e)
        {
            OleDbCommand selectMenu = new OleDbCommand("SELECT IdDish, Name, CostPrice, Price, Description FROM Menu", cn);

            selectMenu.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMenu;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Menu");

            ComBox.Items.Clear();
            update();
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Menu");
        }

        private void ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name From Menu WHERE Name = ?", cn);

            selectName.Parameters.AddWithValue("@Name", ComBox.Text);
            selectName.ExecuteNonQuery();
            OleDbDataReader reader = selectName.ExecuteReader();
            reader.Read();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteName = new OleDbCommand("DELETE FROM Menu WHERE Name = ?", cn);
            deleteName.Parameters.AddWithValue ("@IdEmployee", ComBox.Text);
            deleteName.ExecuteNonQuery();
            MessageBox.Show("Dish deleted", "Delete", MessageBoxButtons.OK);

            ComBox.Text = "";
            ComBox.Items.Clear();
            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Menu");
            update();
        }
    }
}
