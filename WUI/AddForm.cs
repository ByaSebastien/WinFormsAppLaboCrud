using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;

namespace WUI
{
    public partial class AddForm : Form
    {
        public IList<Supplier> Suppliers = new List<Supplier>();
        public IList<Supplier> TempSuppliers = new List<Supplier>();
        public int RowSelected;
        public bool Closing = false;
        public AddForm()
        {
            InitializeComponent();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            dateToolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
            Size = new Size(886, 547);
            CopyList();
            FillSuppliers();
        }
        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateToolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
        }
        private void nameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            validNameLabel.ForeColor = Utility.ValidationUtility.ValidName(nameTextBox.Text) ? Color.Green : Color.Red;
        }
        private void phoneNumberTextBox_TextChanged_1(object sender, EventArgs e)
        {
            validPhoneNumberLabel.ForeColor = Utility.ValidationUtility.ValidPhoneNumber(phoneNumberTextBox.Text) ? Color.Green : Color.Red;
        }
        private void emailAddressTextBox_TextChanged_1(object sender, EventArgs e)
        {
            validEmailAddressLabel.ForeColor = Utility.ValidationUtility.ValidEmailAddress(emailAddressTextBox.Text) ? Color.Green : Color.Red;
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string emailAddress = emailAddressTextBox.Text;
            string city = cityTextBox.Text;
            bool ordered = orderedCheckBox.Checked;

            if (Utility.ValidationUtility.ValidAll(name, phoneNumber, emailAddress))
            {
                Cursor.Current = Cursors.WaitCursor;
                TempSuppliers.Add(new Supplier(name, phoneNumber, emailAddress, city, ordered));
                FillSuppliers();
                if (Suppliers.Count > 0)
                    suppliersDataGridView.Rows[0].Selected = false;
                ClearTextBoxs();
                EnableConfirmButton();
                Cursor.Current = Cursors.Default;
            }
            else
                MessageBox.Show("Formulaire non valide.");
        }
        private void rightArrowButton_Click_1(object sender, EventArgs e)
        {
            Size = new Size(886, 547);
            rightArrowButton.Visible = false;
            leftArrowButton.Visible = true;
            plusButton.Visible = true;
        }
        private void leftArrowButton_Click_1(object sender, EventArgs e)
        {
            Size = new Size(472, 547);
            rightArrowButton.Visible = true;
            leftArrowButton.Visible = false;
            plusButton.Visible = false;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            Suppliers = TempSuppliers;
            Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void suppliersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RowSelected = e.RowIndex;
                suppliersDataGridView.Rows[e.RowIndex].Selected = true;
                if (!modifyButton.Enabled && !removeButton.Enabled)
                {
                    modifyButton.Enabled = true;
                    modifyButton.BackColor = Color.DarkCyan;
                    removeButton.Enabled = true;
                    removeButton.BackColor = Color.DarkCyan;
                }
            }
        }
        private void modifyButton_Click(object sender, EventArgs e)
        {
            confirmModifyButton.Visible = true;
            cancelModifyButton.Visible = true;
            nameTextBox.Text = TempSuppliers[RowSelected].Name;
            phoneNumberTextBox.Text = TempSuppliers[RowSelected].PhoneNumber;
            emailAddressTextBox.Text = TempSuppliers[RowSelected].EmailAddress;
            cityTextBox.Text = TempSuppliers[RowSelected].City;
            orderedCheckBox.Checked = TempSuppliers[RowSelected].Ordered;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            TempSuppliers.RemoveAt(RowSelected);
            FillSuppliers();
            ClearTextBoxs();
            EnableConfirmButton();
        }
        private void confirmModifyButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string emailAddress = emailAddressTextBox.Text;
            string city = cityTextBox.Text;
            bool ordered = orderedCheckBox.Checked;
            if (Utility.ValidationUtility.ValidAll(name, phoneNumber, emailAddress))
            {
                confirmModifyButton.Visible = false;
                cancelModifyButton.Visible=false;
                TempSuppliers[RowSelected].Name = nameTextBox.Text;
                TempSuppliers[RowSelected].PhoneNumber = phoneNumberTextBox.Text;
                TempSuppliers[RowSelected].EmailAddress = emailAddressTextBox.Text;
                TempSuppliers[RowSelected].City = cityTextBox.Text;
                TempSuppliers[RowSelected].Ordered = orderedCheckBox.Checked;
                FillSuppliers();
                ClearTextBoxs();
                EnableConfirmButton();
            }
            else
                MessageBox.Show("Formulaire non valide.");
        }
        private void cancelModifyButton_Click(object sender, EventArgs e)
        {
            confirmModifyButton.Visible = false;
            cancelModifyButton.Visible = false;
            ClearTextBoxs();
        }
        private void FillSuppliers()
        {
            suppliersDataGridView.Rows.Clear();
            foreach (Supplier supplier in TempSuppliers)
            {
                suppliersDataGridView.Rows.Add(supplier.ID, supplier.Name, supplier.Ordered);
            }
        }
        private void ClearTextBoxs()
        {
            nameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            emailAddressTextBox.Text = "";
            cityTextBox.Text = "";
            orderedCheckBox.Checked = false;
        }
        private void EnableConfirmButton()
        {
            if (!confirmButton.Enabled)
            {
                confirmButton.BackColor = Color.DarkCyan;
                confirmButton.Enabled = true;
            }
            if (modifyButton.Enabled && removeButton.Enabled)
            {
                modifyButton.Enabled = false;
                modifyButton.BackColor = Color.Silver;
                removeButton.Enabled = false;
                removeButton.BackColor = Color.Silver;
            }
        }
        private void CopyList()
        {
            foreach (Supplier supplier in Suppliers)
            {
                TempSuppliers.Add(new Supplier(supplier));
            }
        }

    }
}
