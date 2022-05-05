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
    public partial class NewDish : Form
    {
        private int IdVis;
        private System.Data.DataSet dSet;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        public NewDish(int IdVisitor)
        {
            InitializeComponent();
            IdVis = IdVisitor;
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

            update1();
            update2();
            Quantity.Items.Add("1");
            Quantity.Items.Add("2");
            Quantity.Items.Add("3");
            Quantity.Items.Add("4");
            Quantity.Items.Add("5");

            NumberOrder.TextAlign = HorizontalAlignment.Center;
            NumberOrder.Enabled = false;
        }
        private void update1()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Menu", cn);
            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                dishName.Items.Add(reader["Name"]);
            }
            reader.Close();
        }

        private void update2()
        {
            OleDbCommand selectIdOrder = new OleDbCommand("SELECT IdOrder FROM Orders WHERE IdVisitor = (SELECT max(IdVisitor) FROM Orders WHERE IdVisitor = ?)", cn);
            selectIdOrder.Parameters.AddWithValue("@IdVis", IdVis);
            //SELECT IdOrder FROM Orders WHERE IdVisitor = (SELECT max(IdVisitor) FROM Orders WHERE IdVisitor = ?);
            OleDbDataReader reader = selectIdOrder.ExecuteReader();
            while (reader.Read())
            {
                NumberOrder.Text = reader[0].ToString();
            }
            reader.Close();
        }

        private void ShowMenu_Click(object sender, EventArgs e)
        {
            OleDbCommand selectMenu = new OleDbCommand("SELECT IdDish, Name, Price, Description FROM Menu", cn);

            selectMenu.ExecuteNonQuery();

            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = selectMenu;
            dAdapter.SelectCommand.Connection = cn;
            dAdapter.Fill(dSet, "Menu");

            dSet.Tables[0].Clear();
            dAdapter.Fill(dSet, "Menu");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO OrderList (IdOrder, IdDish, Quantity, Price) VALUES (?, " +
                                        "(SELECT IdDish FROM Menu Where Name = ?), " +
                                        "?, (SELECT Price FROM Menu Where Name = ?))", cn);
            command.Parameters.AddWithValue("@IdOrder", NumberOrder.Text);
            //command.Parameters.AddWithValue("@IdOrder", Number.SelectedItem);
            command.Parameters.AddWithValue("@IdDish", dishName.SelectedItem);
            command.Parameters.AddWithValue("@Quant", Quantity.SelectedItem);
            command.Parameters.AddWithValue("@Price", dishName.SelectedItem);
            command.ExecuteNonQuery();
            MessageBox.Show("New dish in yuor order added", "Add", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_vivsitor visitor = new Menu_vivsitor(IdVis);
            Hide();
            visitor.ShowDialog();
            Close();
        }
    }
}
