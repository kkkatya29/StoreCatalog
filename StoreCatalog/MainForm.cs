using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreCatalog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }
        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog newForm = new Catalog();
            newForm.Show();
        }
        private void AvailabilityBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Availability newForm = new Availability();
            newForm.Show();
        }
    }
}
