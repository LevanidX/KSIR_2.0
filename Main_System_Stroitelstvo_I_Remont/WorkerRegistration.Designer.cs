namespace Main_System_Stroitelstvo_I_Remont
{
    partial class WorkerRegistration
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
            System.Windows.Forms.Label client_phone_numberLabel;
            System.Windows.Forms.Label client_nameLabel;
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.workersTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.worker_nameTextBox = new System.Windows.Forms.TextBox();
            this.BtnExitForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnNewClientSave = new System.Windows.Forms.Button();
            this.worker_phone_numberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            client_phone_numberLabel = new System.Windows.Forms.Label();
            client_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stroidtelstvo_i_remontDataSet
            // 
            this.stroidtelstvo_i_remontDataSet.DataSetName = "stroidtelstvo_i_remontDataSet";
            this.stroidtelstvo_i_remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.companiesTableAdapter = null;
            this.tableAdapterManager.completed_ordersTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // worker_nameTextBox
            // 
            this.worker_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "worker_name", true));
            this.worker_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worker_nameTextBox.Location = new System.Drawing.Point(190, 48);
            this.worker_nameTextBox.Name = "worker_nameTextBox";
            this.worker_nameTextBox.Size = new System.Drawing.Size(577, 40);
            this.worker_nameTextBox.TabIndex = 2;
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.BackColor = System.Drawing.Color.Red;
            this.BtnExitForm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExitForm.Location = new System.Drawing.Point(569, 5);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(198, 40);
            this.BtnExitForm.TabIndex = 15;
            this.BtnExitForm.Text = "Выход из окна";
            this.BtnExitForm.UseVisualStyleBackColor = false;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 33);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Регистрация нового работника";
            // 
            // BtnNewClientSave
            // 
            this.BtnNewClientSave.BackColor = System.Drawing.Color.Green;
            this.BtnNewClientSave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewClientSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNewClientSave.Location = new System.Drawing.Point(12, 140);
            this.BtnNewClientSave.Name = "BtnNewClientSave";
            this.BtnNewClientSave.Size = new System.Drawing.Size(755, 82);
            this.BtnNewClientSave.TabIndex = 13;
            this.BtnNewClientSave.Text = "Зарегистрировать";
            this.BtnNewClientSave.UseVisualStyleBackColor = false;
            this.BtnNewClientSave.Click += new System.EventHandler(this.BtnNewClientSave_Click);
            // 
            // client_phone_numberLabel
            // 
            client_phone_numberLabel.AutoSize = true;
            client_phone_numberLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_phone_numberLabel.ForeColor = System.Drawing.SystemColors.Control;
            client_phone_numberLabel.Location = new System.Drawing.Point(6, 94);
            client_phone_numberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            client_phone_numberLabel.Name = "client_phone_numberLabel";
            client_phone_numberLabel.Size = new System.Drawing.Size(191, 33);
            client_phone_numberLabel.TabIndex = 12;
            client_phone_numberLabel.Text = "Номер телефона";
            // 
            // client_nameLabel
            // 
            client_nameLabel.AutoSize = true;
            client_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            client_nameLabel.Location = new System.Drawing.Point(6, 51);
            client_nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            client_nameLabel.Name = "client_nameLabel";
            client_nameLabel.Size = new System.Drawing.Size(175, 33);
            client_nameLabel.TabIndex = 11;
            client_nameLabel.Text = "Имя работника";
            // 
            // worker_phone_numberMaskedTextBox
            // 
            this.worker_phone_numberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "worker_phone_number", true));
            this.worker_phone_numberMaskedTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worker_phone_numberMaskedTextBox.Location = new System.Drawing.Point(209, 91);
            this.worker_phone_numberMaskedTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.worker_phone_numberMaskedTextBox.Mask = "79000000000";
            this.worker_phone_numberMaskedTextBox.Name = "worker_phone_numberMaskedTextBox";
            this.worker_phone_numberMaskedTextBox.Size = new System.Drawing.Size(558, 40);
            this.worker_phone_numberMaskedTextBox.TabIndex = 16;
            // 
            // WorkerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(774, 228);
            this.ControlBox = false;
            this.Controls.Add(this.worker_phone_numberMaskedTextBox);
            this.Controls.Add(this.BtnExitForm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnNewClientSave);
            this.Controls.Add(client_phone_numberLabel);
            this.Controls.Add(client_nameLabel);
            this.Controls.Add(this.worker_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового работника";
            this.Load += new System.EventHandler(this.WorkerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox worker_nameTextBox;
        private System.Windows.Forms.Button BtnExitForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnNewClientSave;
        private System.Windows.Forms.MaskedTextBox worker_phone_numberMaskedTextBox;
    }
}