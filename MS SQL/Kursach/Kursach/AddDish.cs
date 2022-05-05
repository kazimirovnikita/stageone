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
    public partial class AddDish : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public AddDish(int IdEmployee)
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
            emp.Columns.Add("CostPrice", typeof(string));
            emp.Columns.Add("Price", typeof(string));
            emp.Columns.Add("Description", typeof(string));

            dgMenu.SetDataBinding(dSet, "Menu");
        }

        private void PR_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Cook_menu cook = new Cook_menu(IdEmpl);
            Hide();
            cook.ShowDialog();
            Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Menu (Name, CostPrice, Price, Description) VALUES (?, ?, ?, ?)", cn);
            command.Parameters.AddWithValue("@Name", NameDish.Text);
            command.Parameters.AddWithValue("@CostPR", CostPrice.Text);
            command.Parameters.AddWithValue("@PR", Price.Text);
            command.Parameters.AddWithValue("@Desc", Description.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("New dish added", "Add", MessageBoxButtons.OK);

            AddIngredientOfDish ingr = new AddIngredientOfDish(IdEmpl);
            Hide();
            ingr.ShowDialog();
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

            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Menu");
        }
    }
}
