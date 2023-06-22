namespace Main_System_Stroitelstvo_I_Remont
{
    partial class CompanyRegistration
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
            System.Windows.Forms.Label client_nameLabel;
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.companiesTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.company_nameTextBox = new System.Windows.Forms.TextBox();
            this.BtnExitForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnNewCompanySave = new System.Windows.Forms.Button();
            client_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stroidtelstvo_i_remontDataSet
            // 
            this.stroidtelstvo_i_remontDataSet.DataSetName = "stroidtelstvo_i_remontDataSet";
            this.stroidtelstvo_i_remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.companiesTableAdapter = this.companiesTableAdapter;
            this.tableAdapterManager.completed_ordersTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = null;
            // 
            // company_nameTextBox
            // 
            this.company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "company_name", true));
            this.company_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_nameTextBox.Location = new System.Drawing.Point(302, 45);
            this.company_nameTextBox.Name = "company_nameTextBox";
            this.company_nameTextBox.Size = new System.Drawing.Size(463, 40);
            this.company_nameTextBox.TabIndex = 2;
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.BackColor = System.Drawing.Color.Red;
            this.BtnExitForm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExitForm.Location = new System.Drawing.Point(567, 1);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(198, 40);
            this.BtnExitForm.TabIndex = 14;
            this.BtnExitForm.Text = "Выход из окна";
            this.BtnExitForm.UseVisualStyleBackColor = false;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(329, 33);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Регистрация новой компании";
            // 
            // BtnNewCompanySave
            // 
            this.BtnNewCompanySave.BackColor = System.Drawing.Color.Green;
            this.BtnNewCompanySave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewCompanySave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNewCompanySave.Location = new System.Drawing.Point(10, 91);
            this.BtnNewCompanySave.Name = "BtnNewCompanySave";
            this.BtnNewCompanySave.Size = new System.Drawing.Size(755, 82);
            this.BtnNewCompanySave.TabIndex = 12;
            this.BtnNewCompanySave.Text = "Зарегистрировать";
            this.BtnNewCompanySave.UseVisualStyleBackColor = false;
            this.BtnNewCompanySave.Click += new System.EventHandler(this.BtnNewCompanySave_Click);
            // 
            // client_nameLabel
            // 
            client_nameLabel.AutoSize = true;
            client_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            client_nameLabel.Location = new System.Drawing.Point(12, 48);
            client_nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            client_nameLabel.Name = "client_nameLabel";
            client_nameLabel.Size = new System.Drawing.Size(281, 33);
            client_nameLabel.TabIndex = 11;
            client_nameLabel.Text = "Наименование компании";
            // 
            // CompanyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(769, 178);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExitForm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnNewCompanySave);
            this.Controls.Add(client_nameLabel);
            this.Controls.Add(this.company_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompanyRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация новой компании";
            this.Load += new System.EventHandler(this.CompanyRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox company_nameTextBox;
        private System.Windows.Forms.Button BtnExitForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnNewCompanySave;
    }
}