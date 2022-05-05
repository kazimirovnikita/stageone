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
    public partial class AddIngredientOfDish : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet1;
        private System.Data.DataSet dSet2;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public AddIngredientOfDish(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet1 = new DataSet();
            DataTable menu;
            menu = dSet1.Tables.Add("Menu");
            menu.Columns.Add("IdDish", typeof(int));
            menu.Columns.Add("Name", typeof(string));
            menu.Columns.Add("CostPrice", typeof(int));
            menu.Columns.Add("Price", typeof(int));
            dgMenu.SetDataBinding(dSet1, "Menu");

            dSet2 = new DataSet();
            DataTable ingr;
            ingr = dSet2.Tables.Add("Ingr");
            ingr.Columns.Add("IdIngredient", typeof(int));
            ingr.Columns.Add("Name", typeof(string));
            ingr.Columns.Add("Quantity", typeof(int));
            ingr.Columns.Add("CostPrice", typeof(int));
            ingr.Columns.Add("Units", typeof(string));
            dgIngr.SetDataBinding(dSet2, "Ingr");

            update1();
            update2();
            ComBox3.Items.Add("1");
            ComBox3.Items.Add("2");
            ComBox3.Items.Add("3");
            ComBox3.Items.Add("4");
            ComBox3.Items.Add("5");
        }

        private void update1()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Menu", cn);
            OleDbDataReader reader1 = selectName.ExecuteReader();
            while (reader1.Read())
            {
                ComBox1.Items.Add(reader1["Name"]);
            }
            reader1.Close();
        }

        private void update2()
        {
            OleDbCommand selectNameIng = new OleDbCommand("SELECT Name, Quantity FROM Ingredients", cn);
            OleDbDataReader reader2 = selectNameIng.ExecuteReader();
            while (reader2.Read())
            {
                ComBox2.Items.Add(reader2["Name"]);
            }
            reader2.Close();
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
            OleDbCommand selectMenu = new OleDbCommand("SELECT IdDish, Name, CostPrice, Price FROM Menu", cn);

            selectMenu.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMenu;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet1, "Menu");

            ComBox1.Items.Clear();
            update1();
            dSet1.Tables[0].Clear();
            dAdapter.Fill(dSet1, "Menu");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO СompositionОfDishes (IdDish, IdIngredient, Quantity) VALUES ((SELECT IdDish FROM Menu Where Name = ?), (SELECT IdIngredient FROM Ingredients Where Name = ?), ?)", cn);
            command.Parameters.AddWithValue("@IdDish", ComBox1.SelectedItem);
            command.Parameters.AddWithValue("@IdIngr", ComBox2.SelectedItem);
            command.Parameters.AddWithValue("@Quantity", ComBox3.SelectedItem);
            command.ExecuteNonQuery();
            MessageBox.Show("New component of dish added", "Add", MessageBoxButtons.OK);

            /*dSet1.Tables[0].Clear();
            dAdapter.Fill(dSet1, "Menu");

            dSet2.Tables[0].Clear();
            dAdapter.Fill(dSet2, "Ingr");*/
        }

        private void ShowIng_Click(object sender, EventArgs e)
        {
            OleDbCommand selectIngr = new OleDbCommand("SELECT IdIngredient, Name, Quantity, CostPrice, Units FROM Ingredients", cn);

            selectIngr.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectIngr;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet2, "Ingr");

            ComBox2.Items.Clear();
            update2();
            dSet2.Tables[0].Clear();
            dAdapter.Fill(dSet2, "Ingr");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteIngr = new OleDbCommand("DELETE FROM СompositionОfDishes WHERE IdIngredient = (SELECT IdIngredient FROM Ingredients Where Name = ?)"
                                                                    + "AND IdDish = (SELECT IdDish FROM Menu Where Name = ?)", cn);
            deleteIngr.Parameters.AddWithValue("@NameIngr", ComBox2.SelectedItem);
            deleteIngr.Parameters.AddWithValue("@NameDish", ComBox1.SelectedItem);

            deleteIngr.ExecuteNonQuery();
            MessageBox.Show("Ingridient from compostion of dish deleted", "Delete", MessageBoxButtons.OK);
        }
    }
}
