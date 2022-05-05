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
    public partial class AddNewIngr : Form
    {
        private int IdEmpl;
        private object quant = 0;
        public AddNewIngr(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            add_button.Enabled = false;


        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command1 = new OleDbCommand("INSERT INTO Ingredients (Name, Quantity, CostPrice, Units) VALUES (?, ?, ?, ?)", cn);
            command1.Parameters.AddWithValue("@Name", NameIngr.Text);
            command1.Parameters.AddWithValue("@Quant", Quantity.Text);
            command1.Parameters.AddWithValue("@PR", CostPrice.Text);
            command1.Parameters.AddWithValue("@Units", Units.Text);
            command1.ExecuteNonQuery();
            MessageBox.Show("New ingredient added", "Add", MessageBoxButtons.OK);

            OleDbCommand command2 = new OleDbCommand("INSERT INTO Storage (IdIngredient, Name, Quantity, Units) VALUES ((SELECT IdIngredient FROM Ingredients WHERE Name = ?),?, ?, ?)", cn);
            command2.Parameters.AddWithValue("@Name1", NameIngr.Text);
            command2.Parameters.AddWithValue("@Name2", NameIngr.Text);
            command2.Parameters.AddWithValue("@Quant", quant);
            command2.Parameters.AddWithValue("@Units", Units.Text);
            command2.ExecuteNonQuery();
            //MessageBox.Show(" added", "Add", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPurchaser pur = new MenuPurchaser(IdEmpl);
            Hide();
            pur.ShowDialog();
            Close();
        }

        private void Units_TextChanged(object sender, EventArgs e)
        {
            add_button.Enabled = true;
        }
    }
}
