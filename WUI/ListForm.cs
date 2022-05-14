using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WUI
{
    public partial class ListForm : Form
    {
        public IList<Supplier> Suppliers = new List<Supplier>();
        public ListForm()
        {
            InitializeComponent();
        }
        private void ListForm_Load(object sender, EventArgs e)
        {
            suppliersDataGridView.DataSource = Suppliers.ToArray();
            WindowState = FormWindowState.Maximized;
            suppliersDataGridView.Rows[0].Selected = false;
        }
    }
}