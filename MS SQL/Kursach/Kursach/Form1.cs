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
    public partial class Admin_menu : Form
    {
        private int IdEmpl;
        public Admin_menu(int IdEmployee)
        {
            InitializeComponent();
            IdEmpl = IdEmployee;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(IdEmpl);
            Hide();
            addEmployee.ShowDialog();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteEmployee deletEmployee = new DeleteEmployee(IdEmpl);
            Hide();
            deletEmployee.ShowDialog();
            Close();
        }

        private void showReview_Click(object sender, EventArgs e)
        {
            ShowReview rev = new ShowReview(IdEmpl);
            Hide();
            rev.ShowDialog();
            Close();
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            Statistic stat = new Statistic(IdEmpl);
            Hide();
            stat.ShowDialog();
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormN order = new MainFormN();
            Hide();
            order.ShowDialog();
            Close();
        }

        private void Admin_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
