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
    public partial class Information : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public Information(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();


            inf.Items.Add("Поставщики");
            inf.Items.Add("Склад");
            inf.Items.Add("Ингридиенты");
            inf.Items.Add("Прайс-лист");

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MenuPurchaser temp = new MenuPurchaser(IdEmpl);
            Hide();
            temp.ShowDialog();
            Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (inf.SelectedIndex == 0)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("Suppliers");
                emp.Columns.Add("OrganizationName", typeof(string));
                emp.Columns.Add("PhoneNumber", typeof(string));
                emp.Columns.Add("DelegateName", typeof(string));


                dg.SetDataBinding(dSet, "Suppliers");

                OleDbCommand selectSup= new OleDbCommand("SELECT OrganizationName, PhoneNumber, DelegateName FROM Suppliers", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "Suppliers");

            }
            else if (inf.SelectedIndex == 1)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("Storage");
                emp.Columns.Add("IdIngredient", typeof(int));
                emp.Columns.Add("Name", typeof(string));
                emp.Columns.Add("Quantity", typeof(int));
                emp.Columns.Add("Units", typeof(string));

                dg.SetDataBinding(dSet, "Storage");

                OleDbCommand selectSup = new OleDbCommand("SELECT IdIngredient, Name, Quantity, Units FROM Storage", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "Storage");

            }
            else if (inf.SelectedIndex == 2)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("Ingredients");
                emp.Columns.Add("IdIngredient", typeof(int));
                emp.Columns.Add("Name", typeof(string));
                emp.Columns.Add("Quantity", typeof(int));
                emp.Columns.Add("CostPrice", typeof(int));
                emp.Columns.Add("Units", typeof(string));


                dg.SetDataBinding(dSet, "Ingredients");

                OleDbCommand selectSup = new OleDbCommand("SELECT IdIngredient, Name, Quantity, CostPrice, Units FROM Ingredients", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "Ingredients");
            }
            else if (inf.SelectedIndex == 3)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("PHIngredients");
                emp.Columns.Add("IdSupplier", typeof(int));
                emp.Columns.Add("IdIngredients", typeof(int));
                emp.Columns.Add("Name", typeof(string));
                emp.Columns.Add("Quantity", typeof(int));
                emp.Columns.Add("Price", typeof(int));

                dg.SetDataBinding(dSet, "PHIngredients");

                OleDbCommand selectSup = new OleDbCommand("SELECT IdSupplier, IdIngredients, Name, Quantity, Price FROM PurchasesIngredients", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "PHIngredients");
            }
        }
    }
}
