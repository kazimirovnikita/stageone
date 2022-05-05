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
    public partial class ShowCook : Form
    {
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public ShowCook()
        {
            InitializeComponent();
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Cook");
            emp.Columns.Add("Name", typeof(string));
            emp.Columns.Add("Surname", typeof(string));
            emp.Columns.Add("Post", typeof(string));

            dgCook.SetDataBinding(dSet, "Cook");

            OleDbCommand selectCook = new OleDbCommand("SELECT Name, Surname, Post FROM Employees Where Post Like 'Повар%'", cn);

            selectCook.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectCook;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Cook");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
