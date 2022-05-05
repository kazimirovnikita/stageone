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
    public partial class OrderIngr : Form
    {
        private int IdEmpl;
        public OrderIngr(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            Order_button.Enabled = false;
            update1();
        }

        private void update1()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT  Storage.Name FROM Ingredients JOIN Storage ON Ingredients.IdIngredient = Storage.IdIngredient " +
                "WHERE Storage.Quantity - Ingredients.Quantity < '0'", cn);
            OleDbDataReader reader1 = selectName.ExecuteReader();
            while (reader1.Read())
            {
                ingrName.Items.Add(reader1["Name"]);
            }
            reader1.Close();

            /*OleDbCommand selectName = new OleDbCommand("SELECT  Storage.Name FROM Ingredients JOIN Storage ON Ingredients.IdIngredient = Storage.IdIngredient " +
                "WHERE Storage.Quantity - Ingredients.Quantity < '0'", cn);*/
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            MenuPurchaser pur = new MenuPurchaser(IdEmpl);
            Hide();
            pur.ShowDialog();
            Close();
        }

        private void ingrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order_button.Enabled = true;
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            //OleDbCommand command = new OleDbCommand("INSERT INTO Ingredients (Name, Quantity, CostPrice, Units) VALUES (?, ?, ?, ?)", cn);
            OleDbCommand updateStorage = new OleDbCommand("UPDATE Storage SET Quantity = (SELECT Quantity FROM PurchasesIngredients WHERE Name = ?)", cn);
            updateStorage.Parameters.AddWithValue("@Name", ingrName.SelectedItem);
            updateStorage.ExecuteNonQuery();
            MessageBox.Show("Ingrdeient successfuly ordered", "Order", MessageBoxButtons.OK);

            ingrName.Text = "";
            ingrName.Items.Clear();
        }
    }
}
