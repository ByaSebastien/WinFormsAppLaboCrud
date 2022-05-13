using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using Models;
using BLL;
using Utility;
using CsvHelper;

namespace WUI
{
    public partial class AddForm : Form
    {
        public IList<Supplier> Suppliers = new List<Supplier>();
        public int RowSelected;
        public string FilePath = null;
        public AddForm()
        {
            InitializeComponent();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            dateToolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
            Size = new Size(886, 547);
            FillSuppliers();
            CheckSuppliersCountToEnableButton();
            if (!string.IsNullOrWhiteSpace(FilePath))
            {
                GetSuppliersImport();
                CheckSuppliersCountToEnableButton();
                foreach (Supplier supplier in Suppliers)
                {
                    if(supplier.ID >= Supplier._ID)
                        Supplier._ID = supplier.ID;                    
                    Supplier._ID++;
                }
            }
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
            validNameLabel.ForeColor = ValidationUtility.ValidName(nameTextBox.Text) ? Color.Green : Color.Red;
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
                Suppliers.Add(new Supplier(name, phoneNumber, emailAddress, city, ordered));
                FillSuppliers();
                if (Suppliers.Count > 0)
                    suppliersDataGridView.Rows[0].Selected = false;
                ClearTextBoxs();
                EnableConfirmButton();
                CheckSuppliersCountToEnableButton();
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
            nameTextBox.Text = Suppliers[RowSelected].Name;
            phoneNumberTextBox.Text = Suppliers[RowSelected].PhoneNumber;
            emailAddressTextBox.Text = Suppliers[RowSelected].EmailAddress;
            cityTextBox.Text = Suppliers[RowSelected].City;
            orderedCheckBox.Checked = Suppliers[RowSelected].Ordered;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            Suppliers.RemoveAt(RowSelected);
            FillSuppliers();
            ClearTextBoxs();
            EnableConfirmButton();
            CheckSuppliersCountToDisableButton();
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
                cancelModifyButton.Visible = false;
                Suppliers[RowSelected].Name = nameTextBox.Text;
                Suppliers[RowSelected].PhoneNumber = phoneNumberTextBox.Text;
                Suppliers[RowSelected].EmailAddress = emailAddressTextBox.Text;
                Suppliers[RowSelected].City = cityTextBox.Text;
                Suppliers[RowSelected].Ordered = orderedCheckBox.Checked;
                Suppliers[RowSelected].CreationDateTime = DateTime.Now;
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
            FillSuppliers();
        }
        private void listButton_Click(object sender, EventArgs e)
        {
            using (ListForm listForm = new ListForm())
            {
                Visible = false;
                listForm.Suppliers = Suppliers;
                listForm.ShowDialog();
            }
            Visible = true;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Supplier> SearchSuppliers = new List<Supplier>(Suppliers);

            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
                SearchSuppliers = SearchSuppliers.Where(sup => sup.Name.Contains(nameTextBox.Text));
            if (!string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                SearchSuppliers = SearchSuppliers.Where(sup => sup.PhoneNumber.Contains(phoneNumberTextBox.Text));
            if (!string.IsNullOrWhiteSpace(emailAddressTextBox.Text))
                SearchSuppliers = SearchSuppliers.Where(sup => sup.EmailAddress.Contains(emailAddressTextBox.Text));
            if (!string.IsNullOrWhiteSpace(cityTextBox.Text))
                SearchSuppliers = SearchSuppliers.Where(sup => sup.City.Contains(cityTextBox.Text));
            suppliersDataGridView.Rows.Clear();
            foreach (Supplier supplier in SearchSuppliers)
            {
                suppliersDataGridView.Rows.Add(supplier.ID, supplier.Name, supplier.Ordered);
            }
            cancelModifyButton.Visible = true;
        }
        private void FillSuppliers()
        {
            suppliersDataGridView.Rows.Clear();
            foreach (Supplier supplier in Suppliers)
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
            if (modifyButton.Enabled && removeButton.Enabled)
            {
                modifyButton.Enabled = false;
                modifyButton.BackColor = Color.Silver;
                removeButton.Enabled = false;
                removeButton.BackColor = Color.Silver;
            }
        }
        private void CheckSuppliersCountToEnableButton()
        {
            if (Suppliers.Count > 0)
            {
                if (!listButton.Enabled)
                {
                    listButton.Enabled = true;
                    listButton.BackColor = Color.DarkCyan;
                }
            }
        }
        private void CheckSuppliersCountToDisableButton()
        {
            if (Suppliers.Count == 0)
            {
                if (listButton.Enabled)
                {
                    listButton.Enabled = false;
                    listButton.BackColor = Color.Silver;
                }
            }
        }
        private void saveAsSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "csv files |*.csv";
                saveFileDialog.Title = "Lire fichier csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = saveFileDialog.FileName;
                    ManipulateData.WriteFileData(Suppliers, FilePath);
                }
            }
        }
        private void saveDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (string.IsNullOrWhiteSpace(FilePath))
                {
                    saveFileDialog.Filter = "csv files |*.csv";
                    saveFileDialog.Title = "Lire fichier csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = saveFileDialog.FileName;
                        ManipulateData.WriteFileData(Suppliers, FilePath);
                    }
                }
                else
                {
                    ManipulateData.WriteFileData(Suppliers, FilePath);
                }
            }
        }

        private void importDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files |*.csv";
                openFileDialog.Title = "Lire fichier csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    GetSuppliersImport();
                }
            }
            FillSuppliers();
        }

        private void GetSuppliersImport()
        {
            try
            {
                Suppliers = ManipulateData.ReadFileData(FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Format du csv incompatible");
            }
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers = new List<Supplier>();
            CheckSuppliersCountToDisableButton();
            ClearTextBoxs();
            EnableConfirmButton();
            FillSuppliers();
            FilePath = null;
            Supplier._ID = 1;
        }
    }
}
