namespace WUI
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.leftArrowButton = new System.Windows.Forms.Button();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmModifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelModifyButton = new System.Windows.Forms.Button();
            this.orderedCheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderedLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.validEmailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.validPhoneNumberLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.validNameLabel = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(870, 25);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentToolStripMenuItem,
            this.importDocumentToolStripMenuItem,
            this.saveDocumentToolStripMenuItem,
            this.saveAsSousToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.editToolStripMenuItem.Text = "Editer";
            // 
            // newDocumentToolStripMenuItem
            // 
            this.newDocumentToolStripMenuItem.Name = "newDocumentToolStripMenuItem";
            this.newDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDocumentToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.newDocumentToolStripMenuItem.Text = "Nouveau Document";
            this.newDocumentToolStripMenuItem.Click += new System.EventHandler(this.newDocumentToolStripMenuItem_Click);
            // 
            // importDocumentToolStripMenuItem
            // 
            this.importDocumentToolStripMenuItem.Name = "importDocumentToolStripMenuItem";
            this.importDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importDocumentToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.importDocumentToolStripMenuItem.Text = "Importer Document";
            this.importDocumentToolStripMenuItem.Click += new System.EventHandler(this.importDocumentToolStripMenuItem_Click);
            // 
            // saveDocumentToolStripMenuItem
            // 
            this.saveDocumentToolStripMenuItem.Name = "saveDocumentToolStripMenuItem";
            this.saveDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDocumentToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.saveDocumentToolStripMenuItem.Text = "Sauvegarder Document";
            this.saveDocumentToolStripMenuItem.Click += new System.EventHandler(this.saveDocumentToolStripMenuItem_Click);
            // 
            // saveAsSousToolStripMenuItem
            // 
            this.saveAsSousToolStripMenuItem.Name = "saveAsSousToolStripMenuItem";
            this.saveAsSousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsSousToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.saveAsSousToolStripMenuItem.Text = "Sauvegarder Sous";
            this.saveAsSousToolStripMenuItem.Click += new System.EventHandler(this.saveAsSousToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(870, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // dateToolStripStatusLabel
            // 
            this.dateToolStripStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.dateToolStripStatusLabel.Name = "dateToolStripStatusLabel";
            this.dateToolStripStatusLabel.Size = new System.Drawing.Size(851, 17);
            this.dateToolStripStatusLabel.Spring = true;
            this.dateToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimer
            // 
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // leftArrowButton
            // 
            this.leftArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftArrowButton.BackgroundImage")));
            this.leftArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftArrowButton.ForeColor = System.Drawing.Color.White;
            this.leftArrowButton.Location = new System.Drawing.Point(831, 188);
            this.leftArrowButton.Name = "leftArrowButton";
            this.leftArrowButton.Size = new System.Drawing.Size(31, 32);
            this.leftArrowButton.TabIndex = 30;
            this.leftArrowButton.UseVisualStyleBackColor = true;
            this.leftArrowButton.Click += new System.EventHandler(this.leftArrowButton_Click_1);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrowButton.BackgroundImage")));
            this.rightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightArrowButton.ForeColor = System.Drawing.Color.White;
            this.rightArrowButton.Location = new System.Drawing.Point(420, 183);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(31, 43);
            this.rightArrowButton.TabIndex = 29;
            this.rightArrowButton.UseVisualStyleBackColor = true;
            this.rightArrowButton.Visible = false;
            this.rightArrowButton.Click += new System.EventHandler(this.rightArrowButton_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmModifyButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.cancelModifyButton);
            this.groupBox1.Controls.Add(this.orderedCheckBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.orderedLabel);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(this.cityLabel);
            this.groupBox1.Controls.Add(this.emailAddressTextBox);
            this.groupBox1.Controls.Add(this.emailAddressLabel);
            this.groupBox1.Controls.Add(this.validEmailAddressLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.phoneNumberLabel);
            this.groupBox1.Controls.Add(this.validPhoneNumberLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.validNameLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 344);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // confirmModifyButton
            // 
            this.confirmModifyButton.BackColor = System.Drawing.Color.DarkCyan;
            this.confirmModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmModifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmModifyButton.ForeColor = System.Drawing.Color.White;
            this.confirmModifyButton.Location = new System.Drawing.Point(14, 281);
            this.confirmModifyButton.Name = "confirmModifyButton";
            this.confirmModifyButton.Size = new System.Drawing.Size(160, 50);
            this.confirmModifyButton.TabIndex = 15;
            this.confirmModifyButton.Text = "Appliquer";
            this.confirmModifyButton.UseVisualStyleBackColor = false;
            this.confirmModifyButton.Visible = false;
            this.confirmModifyButton.Click += new System.EventHandler(this.confirmModifyButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkCyan;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(14, 281);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 50);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // cancelModifyButton
            // 
            this.cancelModifyButton.BackColor = System.Drawing.Color.DarkCyan;
            this.cancelModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelModifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelModifyButton.ForeColor = System.Drawing.Color.White;
            this.cancelModifyButton.Location = new System.Drawing.Point(202, 281);
            this.cancelModifyButton.Name = "cancelModifyButton";
            this.cancelModifyButton.Size = new System.Drawing.Size(160, 50);
            this.cancelModifyButton.TabIndex = 29;
            this.cancelModifyButton.Text = "Annuler";
            this.cancelModifyButton.UseVisualStyleBackColor = false;
            this.cancelModifyButton.Visible = false;
            this.cancelModifyButton.Click += new System.EventHandler(this.cancelModifyButton_Click);
            // 
            // orderedCheckBox
            // 
            this.orderedCheckBox.AutoSize = true;
            this.orderedCheckBox.Location = new System.Drawing.Point(233, 243);
            this.orderedCheckBox.Name = "orderedCheckBox";
            this.orderedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.orderedCheckBox.TabIndex = 13;
            this.orderedCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkCyan;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(202, 281);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 50);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderedLabel
            // 
            this.orderedLabel.AutoSize = true;
            this.orderedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderedLabel.Location = new System.Drawing.Point(14, 231);
            this.orderedLabel.Name = "orderedLabel";
            this.orderedLabel.Size = new System.Drawing.Size(213, 30);
            this.orderedLabel.TabIndex = 12;
            this.orderedLabel.Text = "Commande en cour :";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(91, 188);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(271, 29);
            this.cityTextBox.TabIndex = 11;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(13, 184);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(63, 30);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "Ville :";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(91, 141);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(271, 29);
            this.emailAddressTextBox.TabIndex = 8;
            this.emailAddressTextBox.TextChanged += new System.EventHandler(this.emailAddressTextBox_TextChanged_1);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailAddressLabel.Location = new System.Drawing.Point(13, 137);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(64, 30);
            this.emailAddressLabel.TabIndex = 7;
            this.emailAddressLabel.Text = "Mail :";
            // 
            // validEmailAddressLabel
            // 
            this.validEmailAddressLabel.AutoSize = true;
            this.validEmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validEmailAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.validEmailAddressLabel.Location = new System.Drawing.Point(368, 131);
            this.validEmailAddressLabel.Name = "validEmailAddressLabel";
            this.validEmailAddressLabel.Size = new System.Drawing.Size(28, 37);
            this.validEmailAddressLabel.TabIndex = 6;
            this.validEmailAddressLabel.Text = "•";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(91, 94);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(271, 29);
            this.phoneNumberTextBox.TabIndex = 5;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged_1);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.Location = new System.Drawing.Point(13, 90);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(50, 30);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Tel :";
            // 
            // validPhoneNumberLabel
            // 
            this.validPhoneNumberLabel.AutoSize = true;
            this.validPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validPhoneNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.validPhoneNumberLabel.Location = new System.Drawing.Point(368, 84);
            this.validPhoneNumberLabel.Name = "validPhoneNumberLabel";
            this.validPhoneNumberLabel.Size = new System.Drawing.Size(28, 37);
            this.validPhoneNumberLabel.TabIndex = 3;
            this.validPhoneNumberLabel.Text = "•";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(91, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(271, 29);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged_1);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(13, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 30);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nom :";
            // 
            // validNameLabel
            // 
            this.validNameLabel.AutoSize = true;
            this.validNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validNameLabel.ForeColor = System.Drawing.Color.Red;
            this.validNameLabel.Location = new System.Drawing.Point(368, 37);
            this.validNameLabel.Name = "validNameLabel";
            this.validNameLabel.Size = new System.Drawing.Size(28, 37);
            this.validNameLabel.TabIndex = 0;
            this.validNameLabel.Text = "•";
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.Silver;
            this.listButton.Enabled = false;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listButton.ForeColor = System.Drawing.Color.White;
            this.listButton.Location = new System.Drawing.Point(26, 418);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(160, 50);
            this.listButton.TabIndex = 27;
            this.listButton.Text = "Lister";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Silver;
            this.removeButton.Enabled = false;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(666, 418);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(160, 50);
            this.removeButton.TabIndex = 26;
            this.removeButton.Text = "Supprimer";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Silver;
            this.modifyButton.Enabled = false;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modifyButton.ForeColor = System.Drawing.Color.White;
            this.modifyButton.Location = new System.Drawing.Point(458, 418);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(160, 50);
            this.modifyButton.TabIndex = 25;
            this.modifyButton.Text = "Modifier";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AllowUserToAddRows = false;
            this.suppliersDataGridView.AllowUserToDeleteRows = false;
            this.suppliersDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.suppliersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.suppliersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.suppliersDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.suppliersDataGridView.Location = new System.Drawing.Point(458, 40);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            this.suppliersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersDataGridView.RowTemplate.Height = 25;
            this.suppliersDataGridView.Size = new System.Drawing.Size(369, 363);
            this.suppliersDataGridView.TabIndex = 24;
            this.suppliersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 39.28934F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 99999;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 157.1574F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FillWeight = 20F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ordered";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 75;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 511);
            this.Controls.Add(this.leftArrowButton);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.suppliersDataGridView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fournisseur CRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newDocumentToolStripMenuItem;
        private ToolStripMenuItem importDocumentToolStripMenuItem;
        private ToolStripMenuItem saveDocumentToolStripMenuItem;
        private ToolStripMenuItem saveAsSousToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel dateToolStripStatusLabel;
        private System.Windows.Forms.Timer dateTimer;
        private Button leftArrowButton;
        private Button rightArrowButton;
        private GroupBox groupBox1;
        private Button addButton;
        private CheckBox orderedCheckBox;
        private Label orderedLabel;
        private TextBox cityTextBox;
        private Label cityLabel;
        private TextBox emailAddressTextBox;
        private Label emailAddressLabel;
        private Label validEmailAddressLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private Label validPhoneNumberLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label validNameLabel;
        private Button listButton;
        private Button removeButton;
        private Button searchButton;
        private Button modifyButton;
        private DataGridView suppliersDataGridView;
        private Button confirmModifyButton;
        private Button cancelModifyButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}