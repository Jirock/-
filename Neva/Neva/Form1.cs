using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Neva
{
    public partial class Form1 : Form
    {
        Database database = new Database();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            t_password.PasswordChar = '*';
            t_name.MaxLength = 50;
            t_password.MaxLength = 50;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string email = t_name.Text;
            string password_text = t_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();   
            DataTable table = new DataTable();

            string querystring = $"select _id, user_name, user_password from users where user_name = '{email}' and user_password = '{password_text}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                Form2 form = new Form2();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
