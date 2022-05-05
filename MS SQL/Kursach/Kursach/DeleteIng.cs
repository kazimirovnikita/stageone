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
    public partial class DeleteIng : Form
    {
        private int IdEmpl;
        public DeleteIng(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            delete_button.Enabled = false;
            update1();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuPurchaser pur = new MenuPurchaser(IdEmpl);
            Hide();
            pur.ShowDialog();
            Close();
        }

        private void update1()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Ingredients", cn);
            OleDbDataReader reader1 = selectName.ExecuteReader();
            while (reader1.Read())
            {
                ingrName.Items.Add(reader1["Name"]);
            }
            reader1.Close();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteIngr = new OleDbCommand("DELETE FROM Ingredients WHERE Name = ?", cn);
            deleteIngr.Parameters.AddWithValue("@Name", ingrName.SelectedItem);
            deleteIngr.ExecuteNonQuery();
            MessageBox.Show("Ingrdeient deleted", "Delete", MessageBoxButtons.OK);
            ingrName.Text = "";
            ingrName.Items.Clear();
        }

        private void ingrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_button.Enabled = true;
        }
    }
}
