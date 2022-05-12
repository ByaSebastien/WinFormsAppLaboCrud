namespace WUI
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.newbutton = new System.Windows.Forms.Button();
            this.crudLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // newbutton
            // 
            this.newbutton.BackColor = System.Drawing.Color.DarkCyan;
            this.newbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newbutton.ForeColor = System.Drawing.Color.White;
            this.newbutton.Location = new System.Drawing.Point(54, 318);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(288, 50);
            this.newbutton.TabIndex = 5;
            this.newbutton.Text = "Nouveau document";
            this.newbutton.UseVisualStyleBackColor = false;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // crudLabel
            // 
            this.crudLabel.AutoSize = true;
            this.crudLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crudLabel.Location = new System.Drawing.Point(94, 184);
            this.crudLabel.Name = "crudLabel";
            this.crudLabel.Size = new System.Drawing.Size(208, 86);
            this.crudLabel.TabIndex = 4;
            this.crudLabel.Text = "CRUD";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supplierLabel.Location = new System.Drawing.Point(12, 62);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(373, 86);
            this.supplierLabel.TabIndex = 3;
            this.supplierLabel.Text = "Fournisseur";
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.DarkCyan;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.Location = new System.Drawing.Point(54, 387);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(288, 50);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Importer document";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 507);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.crudLabel);
            this.Controls.Add(this.supplierLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TitleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fournisseur CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newbutton;
        private Label crudLabel;
        private Label supplierLabel;
        private Button importButton;
        private System.Windows.Forms.Timer dateTimer;
    }
}