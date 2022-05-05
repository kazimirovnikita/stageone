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
    public partial class MainFormN : Form
    {
        
        public MainFormN()
        {
            InitializeComponent();
            String strConn = "Provider = SQLOLEDB; Data Source = DESKTOP-H4GUTBQ; Initial Catalog = Kursach; Integrated Security = SSPI";
            cn.ConnectionString = strConn;
            cn.Open();

           // SignIn.Enabled = false;

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            OleDbCommand selectUser = new OleDbCommand("SELECT IdUser, Surname FROM Users WHERE Login = ? AND Password = ?", cn);
            selectUser.Parameters.AddWithValue("@Login", Login.Text);
            selectUser.Parameters.AddWithValue("@IdTable", Password.Text);
            selectUser.ExecuteNonQuery();

            object idUser;
            object Surname;

            OleDbDataReader reader = selectUser.ExecuteReader();
            if (reader.Read())
            {
                idUser = reader["IdUser"];
                Surname = reader["Surname"];
            }
            else
            {
                MessageBox.Show("    Нет пользователя с таким логином или паролем!    ");
                return;
            }
            reader.Close();


            OleDbCommand selectIdVisitor = new OleDbCommand("SELECT IdVisitor FROM Visitors WHERE Surname = ?", cn);
            selectIdVisitor.Parameters.AddWithValue("@Sur", Surname);
            selectIdVisitor.ExecuteNonQuery();

            object idVisitor;

            OleDbDataReader reader1 = selectIdVisitor.ExecuteReader();
            if (reader1.Read())
            {
                idVisitor = reader1["IdVisitor"];
                Menu_vivsitor vivsitor = new Menu_vivsitor(Convert.ToInt32(idVisitor));
                Hide();
                vivsitor.ShowDialog();
                Close();
            }
            else
            {
                OleDbCommand selectIdEmp = new OleDbCommand("SELECT IdEmployee FROM Employees WHERE Surname = ?", cn);
                selectIdEmp.Parameters.AddWithValue("@Sur", Surname);
                selectIdEmp.ExecuteNonQuery();

                object idEmployee;

                OleDbDataReader reader2 = selectIdEmp.ExecuteReader();
                if (reader2.Read())
                {
                    idEmployee = reader2["IdEmployee"];
                

                    OleDbCommand selectPost = new OleDbCommand("SELECT Post FROM Employees WHERE IdEmployee = ?", cn);
                    selectPost.Parameters.AddWithValue("@IdEmpl", Convert.ToInt32(idEmployee));
                    selectPost.ExecuteNonQuery();

                    object Post;

                    OleDbDataReader reader3 = selectPost.ExecuteReader();
                    if (reader3.Read())
                    {
                        Post = reader3["Post"];
                        if (Post.ToString() == "Администратор")
                        {
                            Admin_menu admin = new Admin_menu(Convert.ToInt32(idEmployee));
                            Hide();
                            admin.ShowDialog();
                            Close();
                        }
                        else if (Post.ToString() == "Повар-стажер")
                        {
                            Cook_menu cook = new Cook_menu(Convert.ToInt32(idEmployee));
                            Hide();
                            cook.ShowDialog();
                            Close();
                        }
                        else if (Post.ToString() == "Закупщик")
                        {
                            MenuPurchaser purchaser = new MenuPurchaser(Convert.ToInt32(idEmployee));
                            Hide();
                            purchaser.ShowDialog();
                            Close();
                        }
                    }
                }
            }
        }

        private void regist_Click(object sender, EventArgs e)
        {
            Registration vivsitor = new Registration();
            Hide();
            vivsitor.ShowDialog();
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}


