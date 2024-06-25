using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreCatalog
{
    public partial class Availability : Form
    {
        public Availability()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }
        private void Availability_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=Katya_ld\\MSSQLSERVER3; Database=StoreCatalog; Integrated Security=true"; //подключение к бд
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.Id, c.Name, q.Quantity FROM Catalog c INNER JOIN Quantities q ON q.Id_Catalog = c.Id", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                QuantityDtGrdVw.DataSource = table;
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Show();
        }
    }
}