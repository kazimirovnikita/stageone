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
    public partial class Cook_menu : Form
    {
        private int IdEmpl;
        public Cook_menu(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddDish addDish = new AddDish(IdEmpl);
            Hide();
            addDish.ShowDialog();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteDish delDish = new DeleteDish(IdEmpl);
            Hide();
            delDish.ShowDialog();
            Close();
        }
        private void show_status_Click(object sender, EventArgs e)
        {
            StatusOrders order = new StatusOrders(IdEmpl);
            Hide();
            order.ShowDialog();
            Close();
        }

        private void changeIng_Click(object sender, EventArgs e)
        {
            AddIngredientOfDish order = new AddIngredientOfDish(IdEmpl);
            Hide();
            order.ShowDialog();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormN order = new MainFormN();
            Hide();
            order.ShowDialog();
            Close();
        }

        private void Cook_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
