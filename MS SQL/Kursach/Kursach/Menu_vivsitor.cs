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
    public partial class Menu_vivsitor : Form
    {
        private int IdVis;
        public Menu_vivsitor(int IdVisitor)
        {
            InitializeComponent();
            IdVis = IdVisitor;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddOrder addDish = new AddOrder(IdVis);
            Hide();
            addDish.ShowDialog();
            Close();
        }
        private void newDish_Click(object sender, EventArgs e)
        {
            NewDish newOrderDish = new NewDish(IdVis);
            Hide();
            newOrderDish.ShowDialog();
            Close();
        }

        private void review_Click(object sender, EventArgs e)
        {
            Review visitor = new Review(IdVis);
            Hide();
            visitor.ShowDialog();
            Close();
        }

        private void showOrder_Click(object sender, EventArgs e)
        {
            ShowOrders visitor = new ShowOrders(IdVis);
            Hide();
            visitor.ShowDialog();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormN order = new MainFormN();
            Hide();
            order.ShowDialog();
            Close();
        }

        private void Menu_vivsitor_Load(object sender, EventArgs e)
        {

        }
    }
}
