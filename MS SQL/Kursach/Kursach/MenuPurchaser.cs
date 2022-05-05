using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class MenuPurchaser : Form
    {
        private int IdEmpl;
        public MenuPurchaser(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddNewIngr newIngr = new AddNewIngr(IdEmpl);
            Hide();
            newIngr.ShowDialog();
            Close();
        }

        private void showOrder_Click(object sender, EventArgs e)
        {
            OrderIngr newIngr = new OrderIngr(IdEmpl);
            Hide();
            newIngr.ShowDialog();
            Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Information inf = new Information(IdEmpl);
            Hide();
            inf.ShowDialog();
            Close();
        }

        private void newDish_Click(object sender, EventArgs e)
        {
            DeleteIng ing = new DeleteIng(IdEmpl);
            Hide();
            ing.ShowDialog();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormN order = new MainFormN();
            Hide();
            order.ShowDialog();
            Close();
        }

        private void MenuPurchaser_Load(object sender, EventArgs e)
        {

        }
    }
}
