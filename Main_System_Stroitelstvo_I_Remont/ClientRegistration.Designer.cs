namespace Main_System_Stroitelstvo_I_Remont
{
    partial class ClientRegistration
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
            System.Windows.Forms.Label client_phone_numberLabel;
            System.Windows.Forms.Label client_home_addressLabel;
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.client_nameTextBox = new System.Windows.Forms.TextBox();
            this.client_home_addressTextBox = new System.Windows.Forms.TextBox();
            this.client_phone_numberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BtnNewClientSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnExitForm = new System.Windows.Forms.Button();
            client_nameLabel = new System.Windows.Forms.Label();
            client_phone_numberLabel = new System.Windows.Forms.Label();
            client_home_addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // client_nameLabel
            // 
            client_nameLabel.AutoSize = true;
            client_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            client_nameLabel.Location = new System.Drawing.Point(6, 48);
            client_nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            client_nameLabel.Name = "client_nameLabel";
            client_nameLabel.Size = new System.Drawing.Size(156, 33);
            client_nameLabel.TabIndex = 1;
            client_nameLabel.Text = "ФИО клиента";
            // 
            // client_phone_numberLabel
            // 
            client_phone_numberLabel.AutoSize = true;
            client_phone_numberLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_phone_numberLabel.ForeColor = System.Drawing.SystemColors.Control;
            client_phone_numberLabel.Location = new System.Drawing.Point(6, 93);
            client_phone_numberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            client_phone_numberLabel.Name = "client_phone_numberLabel";
            client_phone_numberLabel.Size = new System.Drawing.Size(191, 33);
            client_phone_numberLabel.TabIndex = 3;
            client_phone_numberLabel.Text = "Номер телефона";
            // 
            // client_home_addressLabel
            // 
            client_home_addressLabel.AutoSize = true;
            client_home_addressLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_home_addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            client_home_addressLabel.Location = new System.Drawing.Point(6, 138);
            client_home_addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            client_home_addressLabel.Name = "client_home_addressLabel";
            client_home_addressLabel.Size = new System.Drawing.Size(198, 33);
            client_home_addressLabel.TabIndex = 5;
            client_home_addressLabel.Text = "Домашний адрес";
            // 
            // stroidtelstvo_i_remontDataSet
            // 
            this.stroidtelstvo_i_remontDataSet.DataSetName = "stroidtelstvo_i_remontDataSet";
            this.stroidtelstvo_i_remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.companiesTableAdapter = null;
            this.tableAdapterManager.completed_ordersTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = null;
            // 
            // client_nameTextBox
            // 
            this.client_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_name", true));
            this.client_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_nameTextBox.Location = new System.Drawing.Point(174, 45);
            this.client_nameTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.client_nameTextBox.Name = "client_nameTextBox";
            this.client_nameTextBox.Size = new System.Drawing.Size(593, 40);
            this.client_nameTextBox.TabIndex = 2;
            // 
            // client_home_addressTextBox
            // 
            this.client_home_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_home_address", true));
            this.client_home_addressTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_home_addressTextBox.Location = new System.Drawing.Point(209, 135);
            this.client_home_addressTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.client_home_addressTextBox.Name = "client_home_addressTextBox";
            this.client_home_addressTextBox.Size = new System.Drawing.Size(558, 40);
            this.client_home_addressTextBox.TabIndex = 6;
            // 
            // client_phone_numberTextBox
            // 
            this.client_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_phone_number", true));
            this.client_phone_numberTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_phone_numberTextBox.Location = new System.Drawing.Point(209, 90);
            this.client_phone_numberTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.client_phone_numberTextBox.Mask = "79000000000";
            this.client_phone_numberTextBox.Name = "client_phone_numberTextBox";
            this.client_phone_numberTextBox.Size = new System.Drawing.Size(558, 40);
            this.client_phone_numberTextBox.TabIndex = 7;
            // 
            // BtnNewClientSave
            // 
            this.BtnNewClientSave.BackColor = System.Drawing.Color.Green;
            this.BtnNewClientSave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewClientSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNewClientSave.Location = new System.Drawing.Point(12, 186);
            this.BtnNewClientSave.Name = "BtnNewClientSave";
            this.BtnNewClientSave.Size = new System.Drawing.Size(755, 82);
            this.BtnNewClientSave.TabIndex = 8;
            this.BtnNewClientSave.Text = "Зарегистрировать";
            this.BtnNewClientSave.UseVisualStyleBackColor = false;
            this.BtnNewClientSave.Click += new System.EventHandler(this.BtnNewClientSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(6, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 33);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Регистрация нового клиента";
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.BackColor = System.Drawing.Color.Red;
            this.BtnExitForm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExitForm.Location = new System.Drawing.Point(569, 2);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(198, 40);
            this.BtnExitForm.TabIndex = 10;
            this.BtnExitForm.Text = "Выход из окна";
            this.BtnExitForm.UseVisualStyleBackColor = false;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // ClientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(777, 276);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExitForm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnNewClientSave);
            this.Controls.Add(this.client_phone_numberTextBox);
            this.Controls.Add(client_home_addressLabel);
            this.Controls.Add(this.client_home_addressTextBox);
            this.Controls.Add(client_phone_numberLabel);
            this.Controls.Add(client_nameLabel);
            this.Controls.Add(this.client_nameTextBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ClientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового клиента";
            this.Load += new System.EventHandler(this.ClientRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox client_nameTextBox;
        private System.Windows.Forms.TextBox client_home_addressTextBox;
        private System.Windows.Forms.MaskedTextBox client_phone_numberTextBox;
        private System.Windows.Forms.Button BtnNewClientSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnExitForm;
    }
}