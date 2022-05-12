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
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }
        private void newbutton_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm())
            {
                Visible = false;
                addForm.ShowDialog();
            }
            Visible = true;
        }
    }
}
