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
    public partial class ShowMenu : Form
    {
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public ShowMenu()
        {
            InitializeComponent();
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Menu");
            emp.Columns.Add("IdDish", typeof(int));
            emp.Columns.Add("Name", typeof(string));
            emp.Columns.Add("Price", typeof(int));
            emp.Columns.Add("Description", typeof(string));

            dgMenu.SetDataBinding(dSet, "Menu");

            OleDbCommand selectMenu = new OleDbCommand("SELECT IdDish, Name, Price, Description FROM Menu", cn);

            selectMenu.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMenu;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Menu");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
