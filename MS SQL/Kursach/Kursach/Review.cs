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
    public partial class Review : Form
    {
        private int IdVis;
        public Review(int IdVisitor)
        {
            InitializeComponent();
            IdVis = IdVisitor;
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

            add_button.Enabled = false;
            rating.Items.Add("1");
            rating.Items.Add("2");
            rating.Items.Add("3");
            rating.Items.Add("4");
            rating.Items.Add("5");
        }

        private void Review_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu_vivsitor visitor = new Menu_vivsitor(IdVis);
            Hide();
            visitor.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Reviews (IdVisitor, Rating, Comment) VALUES (?, ?, ?)", cn);
            command.Parameters.AddWithValue("@IdVisitor", IdVis);
            command.Parameters.AddWithValue("@IdTable", rating.SelectedItem);
            command.Parameters.AddWithValue("@IdTable", comment.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("New order added", "Add", MessageBoxButtons.OK);
        }

        private void status_TextChanged(object sender, EventArgs e)
        {
            add_button.Enabled = true;
        }
    }
}
