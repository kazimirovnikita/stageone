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
    public partial class AddOrder : Form
    {
        private int IdVis;
        private object status = "выполняется";
        public AddOrder(int IdVisitor)
        {
            InitializeComponent();
            IdVis = IdVisitor;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();
            update2();
            update1();
            update3();

            Quantity.Items.Add("1");
            Quantity.Items.Add("2");
            Quantity.Items.Add("3");
            Quantity.Items.Add("4");
            Quantity.Items.Add("5");

            add_button.Enabled = false;
            ShowMenu.Enabled = false;
            dishName.Enabled = false;
            Quantity.Enabled = false;
            NumberOrder.Enabled = false;
            priceBox.Enabled = false;
            NumberOrder.TextAlign = HorizontalAlignment.Center;
        }
        private void update1()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Employees Where Post Like 'Повар%'", cn);
            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                NameEmpl.Items.Add(reader["Name"]);
            }
            reader.Close();
        }

        private void update2()
        {
            OleDbCommand selectID = new OleDbCommand("SELECT NumberOfTable FROM Tables EXCEPT SELECT IdTable  FROM BookedTables", cn);
            OleDbDataReader reader1 = selectID.ExecuteReader();
            while (reader1.Read())
            {
                Number.Items.Add(reader1["NumberOfTable"]);
            }
            reader1.Close();
        }

        private void update3()
        {
            OleDbCommand selectName = new OleDbCommand("SELECT Name FROM Menu", cn);
            OleDbDataReader reader = selectName.ExecuteReader();
            while (reader.Read())
            {
                dishName.Items.Add(reader["Name"]);
            }
            reader.Close();
        }
        private void ShowMenu_Click_1(object sender, EventArgs e)
        {
            ShowMenu menu = new ShowMenu();
            //Hide();
            menu.Show();
            //Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCook cook = new ShowCook();
            //Hide();
            cook.Show();
            //Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Orders (IdVisitor, IdEmployee, IdTable) VALUES (?, (SELECT IdEmployee FROM Employees Where Name = ?), "
                                                            +"(SELECT IdTable FROM Tables Where NumberOfTable = ?))", cn);
            command.Parameters.AddWithValue("@IdVIs", IdVis);
            command.Parameters.AddWithValue("@IdEmployee", NameEmpl.SelectedItem);
            command.Parameters.AddWithValue("@IdTable", Number.SelectedItem);
            command.ExecuteNonQuery();
            MessageBox.Show("New order added", "Add", MessageBoxButtons.OK);

            OleDbCommand command2 = new OleDbCommand("INSERT INTO BookedTables (IdTable, IdVisitor, PhoneNumber) VALUES ((SELECT IdTable FROM Tables Where NumberOfTable = ?), " +
                                                            " ?, "
                                                            + "(SELECT PhoneNumber FROM Visitors Where IdVisitor = ?))", cn);
            command2.Parameters.AddWithValue("@IdTable", Number.SelectedItem);
            command2.Parameters.AddWithValue("@IdVIs", IdVis);
            command2.Parameters.AddWithValue("@IdVIs", IdVis);
            command2.ExecuteNonQuery();

            OleDbCommand selectIdOrder = new OleDbCommand("SELECT IdOrder FROM Orders WHERE IdVisitor = ? "
                                                           + "AND IdTable = (SELECT IdTable FROM Tables Where NumberOfTable = ?)", cn);
            selectIdOrder.Parameters.AddWithValue("@IdVis", IdVis);
            selectIdOrder.Parameters.AddWithValue("@IdTable", Number.SelectedItem);

            OleDbDataReader reader = selectIdOrder.ExecuteReader();
            while (reader.Read())
            {
                NumberOrder.Text = reader[0].ToString();
            }
            reader.Close();

            add_button.Enabled = true;
            ShowMenu.Enabled = true;
            button3.Enabled = false;
            dishName.Enabled = true;
            Quantity.Enabled = true;
            button1.Enabled = false;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO OrderList (IdOrder, IdDish, Quantity, Price) VALUES (?, " +
                                                    "(SELECT IdDish FROM Menu Where Name = ?), " +
                                                    "?, (SELECT Price FROM Menu Where Name = ?))", cn);
            command.Parameters.AddWithValue("@IdOrder", NumberOrder.Text);
            command.Parameters.AddWithValue("@IdDish", dishName.SelectedItem);
            command.Parameters.AddWithValue("@Quant", Quantity.SelectedItem);
            command.Parameters.AddWithValue("@Price", dishName.SelectedItem);
            command.ExecuteNonQuery();
            MessageBox.Show("New dish in yuor order added", "Add", MessageBoxButtons.OK);

            dishName.Text = "";
            Quantity.Text = "";


            /*OleDbCommand commandBill = new OleDbCommand("INSERT INTO Bill (IdOrder, Bill) VALUES ((SELECT IdOrder FROM Orders Where IdVisitor = ? AND IdTable = (SELECT IdTable FROM Tables Where NumberOfTable = ?)), " +
                                                               "?", cn);
            commandBill.Parameters.AddWithValue("@IdOrder", IdVis);
            commandBill.Parameters.AddWithValue("@IdTable", Number.SelectedItem);
            commandBill.Parameters.AddWithValue("@Pr", 0);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand commandStatus = new OleDbCommand("INSERT INTO StatusOrders (IdOrder, Status) VALUES (?, ?)", cn);
            commandStatus.Parameters.AddWithValue("@IdOrder", NumberOrder.Text);
            commandStatus.Parameters.AddWithValue("@Stat", status);
            commandStatus.ExecuteNonQuery();

            int bill = 0;

            OleDbCommand commandBill = new OleDbCommand("INSERT INTO Bill (IdOrder, Bill) VALUES (?, ?)", cn);
            commandBill.Parameters.AddWithValue("@IdOrder", NumberOrder.Text);
            commandBill.Parameters.AddWithValue("@Pr", bill);
            commandBill.ExecuteNonQuery();

            Menu_vivsitor visitor = new Menu_vivsitor(IdVis);
            Hide();
            visitor.ShowDialog();
            Close();
        }

        private void dishName_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand selectPrice = new OleDbCommand("SELECT Price FROM Menu WHERE Name = ?", cn);
            selectPrice.Parameters.AddWithValue("@Name", dishName.SelectedItem);
            OleDbDataReader reader = selectPrice.ExecuteReader();
            while (reader.Read())
            {
                priceBox.Text = reader[0].ToString();
            }
            reader.Close();
        }

























        /*private void dichName_Click(object sender, EventArgs e)
        {

        }*/

        /*private void NameEmpl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
