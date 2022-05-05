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
    public partial class Statistic : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public Statistic(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            
            inf.Items.Add("Общая выручка");
            inf.Items.Add("Лучший сотрудник");
            inf.Items.Add("Самое популярное блюдо");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_menu admin = new Admin_menu(IdEmpl);
            Hide();
            admin.ShowDialog();
            Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (inf.SelectedIndex == 0)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("Revenue");
                emp.Columns.Add("Revenue", typeof(int));
                emp.Columns.Add("Count", typeof(int));


                dg.SetDataBinding(dSet, "Revenue");

                OleDbCommand selectSup = new OleDbCommand("SELECT Sum(OrderList.Price * OrderList.Quantity) " +
                    "AS Revenue, Count(*) AS Count FROM Orders " +
                    "INNER JOIN OrderList ON Orders.IdOrder=OrderList.IdOrder", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "Revenue");

            }
            else if (inf.SelectedIndex == 1)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("BestEmployee");
                emp.Columns.Add("Number_Of_orders", typeof(int));
                emp.Columns.Add("Name", typeof(string));
                emp.Columns.Add("Surname", typeof(string));
                emp.Columns.Add("Post", typeof(string));

                dg.SetDataBinding(dSet, "BestEmployee");

                OleDbCommand selectSup = new OleDbCommand("SELECT Count(*) AS Number_Of_orders, Name, Surname, Post FROM Orders " +
                    "INNER JOIN Employees ON Orders.IdEmployee = Employees.IdEmployee " +
                    "GROUP BY Orders.IdEmployee, Employees.Name, Employees.Surname, Employees.Post " +
                    "HAVING Count(Orders.IdOrder) > Max(1)", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "BestEmployee");

            }
            else if (inf.SelectedIndex == 2)
            {
                dSet = new DataSet();
                DataTable emp;
                emp = dSet.Tables.Add("PopularDish");
                emp.Columns.Add("Quantity", typeof(int));
                emp.Columns.Add("Name", typeof(string));
                emp.Columns.Add("Price", typeof(int));

                dg.SetDataBinding(dSet, "PopularDish");

                OleDbCommand selectSup = new OleDbCommand("SELECT Count(*) AS  Quantity, Name, Menu.Price FROM OrderList " +
                    "INNER JOIN Menu ON OrderList.IdDish = Menu.IdDish INNER JOIN Orders ON OrderList.IdOrder = Orders.IdOrder " +
                    "GROUP BY Menu.Name, Menu.Price " +
                    "HAVING Count(OrderList.Quantity) > Max(1)", cn);
                selectSup.ExecuteNonQuery();

                dAdapter = new OleDbDataAdapter();
                dAdapter.SelectCommand = selectSup;
                dAdapter.SelectCommand.Connection = cn;
                dAdapter.Fill(dSet, "PopularDish");
            }
        }
    }
}
