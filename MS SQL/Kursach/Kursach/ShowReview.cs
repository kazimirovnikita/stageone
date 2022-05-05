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
    public partial class ShowReview : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet1;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public ShowReview(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet1 = new DataSet();
            DataTable menu;
            menu = dSet1.Tables.Add("Reviews");
            menu.Columns.Add("IdVisitor", typeof(int));
            menu.Columns.Add("Rating", typeof(int));
            menu.Columns.Add("Comment", typeof(string));
            dgMenu.SetDataBinding(dSet1, "Reviews");


            OleDbCommand selectMenu = new OleDbCommand("SELECT * FROM Reviews", cn);

            selectMenu.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMenu;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet1, "Reviews");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           Admin_menu cook = new Admin_menu(IdEmpl);
            Hide();
            cook.ShowDialog();
            Close();
        }
    }
}
