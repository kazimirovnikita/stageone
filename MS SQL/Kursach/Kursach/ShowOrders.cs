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
    public partial class ShowOrders : Form
    {
        private int IdVis;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public ShowOrders(int IdVisitor)
        {
            InitializeComponent();
            IdVis = IdVisitor;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Order");
            emp.Columns.Add("IdOrder", typeof(int));
            emp.Columns.Add("Name", typeof(string));
            emp.Columns.Add("Quantity", typeof(int));
            emp.Columns.Add("Price", typeof(int));
            emp.Columns.Add("Status", typeof(string));

            dg.SetDataBinding(dSet, "Order");

            OleDbCommand selectSup = new OleDbCommand("SELECT OrderList.IdOrder, Menu.Name, OrderList.Quantity, OrderList.Price, StatusOrders.Status FROM OrderList " +
                "JOIN Menu ON Menu.IdDish = OrderList.IdDish " +
                "JOIN Orders ON Orders.IdOrder = OrderList.IdOrder JOIN StatusOrders ON StatusOrders.IdOrder = OrderList.IdOrder " +
                "WHERE Orders.IdVisitor = ?", cn);
            selectSup.Parameters.AddWithValue("@IdVisitor", IdVis);
            selectSup.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectSup;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Order");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Menu_vivsitor visitor = new Menu_vivsitor(IdVis);
            Hide();
            visitor.ShowDialog();
            Close();
        }
    }
}
