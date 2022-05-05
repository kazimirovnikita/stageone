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
    public partial class CheckReviews : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public CheckReviews(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Review");
            emp.Columns.Add("IdVisitor", typeof(int));
            emp.Columns.Add("Name", typeof(string));
            emp.Columns.Add("Rating", typeof(int));
            emp.Columns.Add("Comment", typeof(string));

            dg.SetDataBinding(dSet, "Review");

            OleDbCommand selectMenu = new OleDbCommand("SELECT Reviews.IdVisitor, Visitors.Name, Visitors.Surname, Rating, Comment FROM Reviews" +
                " JOIN Visitors ON Visitors.IdVisitor = Reviews.IdVisitor", cn);

            selectMenu.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMenu;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Review");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Admin_menu admin = new Admin_menu(IdEmpl);
            Hide();
            admin.ShowDialog();
            Close();
        }
    }
}
