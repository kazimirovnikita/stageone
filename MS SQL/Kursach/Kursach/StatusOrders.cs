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
    public partial class StatusOrders : Form
    {
        private int IdEmpl;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private object Status = "завершён";

        public StatusOrders(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            dSet = new DataSet();
            DataTable emp;
            emp = dSet.Tables.Add("Orders");
            emp.Columns.Add("IdOrder", typeof(int));
            emp.Columns.Add("Status", typeof(string));
            emp.Columns.Add("Bill", typeof(int));


            dgOrder.SetDataBinding(dSet, "Orders");

            OleDbCommand selectOrders = new OleDbCommand("SELECT Orders.IdOrder, StatusOrders.Status, Bill.Bill FROM Orders " +
                "INNER JOIN StatusOrders ON Orders.IdOrder = StatusOrders.IdOrder " +
                "INNER JOIN Bill ON Orders.IdOrder = Bill.IdOrder", cn);

            selectOrders.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectOrders;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Orders");

            update();
            status.Enabled = false;
            bill_button.Enabled = false;
            billBox.Enabled = false;
            status.TextAlign = HorizontalAlignment.Center;
            billBox.TextAlign = HorizontalAlignment.Center;
        }

        private void update()
        {
            OleDbCommand selectId = new OleDbCommand("SELECT DISTINCT Orders.IdOrder FROM Orders JOIN StatusOrders ON Orders.IdOrder = StatusOrders.IdOrder " +
                                                            "WHERE Status = 'выполняется'", cn);
            OleDbDataReader reader = selectId.ExecuteReader();
            while (reader.Read())
            {
                idorder.Items.Add(reader["Idorder"]);
            }
            reader.Close();
        }

        private void bill_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command1 = new OleDbCommand("UPDATE Bill SET Bill = (SELECT SUM(Price*Quantity) FROM OrderList WHERE IdOrder = ?) WHERE IdOrder = ?", cn);
            command1.Parameters.AddWithValue("@Bill", idorder.SelectedItem);
            command1.Parameters.AddWithValue("@id", idorder.SelectedItem);
            command1.ExecuteNonQuery();

            OleDbCommand command4 = new OleDbCommand("DELETE FROM BookedTables WHERE IdVisitor = (SELECT IdVisitor FROM Orders WHERE IdOrder =  ?)", cn);
            command4.Parameters.AddWithValue("@id", idorder.SelectedItem);
            command4.ExecuteNonQuery();

            OleDbCommand command2 = new OleDbCommand("UPDATE StatusOrders SET status = ? WHERE IdOrder = ?", cn);
            command2.Parameters.AddWithValue("@Status", Status);
            command2.Parameters.AddWithValue("@id", idorder.SelectedItem);
            command2.ExecuteNonQuery();

            OleDbCommand command3 = new OleDbCommand("SELECT Bill FROM Bill WHERE IdOrder = ?", cn);
            command3.Parameters.AddWithValue("@bill", idorder.SelectedItem);
            command3.ExecuteNonQuery();
            OleDbDataReader reader = command3.ExecuteReader();
            while (reader.Read())
            {
                billBox.Text = reader[0].ToString();
            }
            reader.Close();

            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Orders");
        }

        private void idorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            bill_button.Enabled = true;
            OleDbCommand selectStat = new OleDbCommand("SELECT Status FROM StatusOrders WHERE IdOrder = ?", cn);
            selectStat.Parameters.AddWithValue("@Name", idorder.SelectedItem);
            OleDbDataReader reader = selectStat.ExecuteReader();
            while (reader.Read())
            {
                status.Text = reader[0].ToString();
            }
            reader.Close();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Cook_menu cook = new Cook_menu(IdEmpl);
            Hide();
            cook.ShowDialog();
            Close();
        }
    }
}
