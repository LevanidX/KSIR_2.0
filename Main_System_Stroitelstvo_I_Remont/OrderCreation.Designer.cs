namespace Main_System_Stroitelstvo_I_Remont
{
    partial class OrderCreation
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
            System.Windows.Forms.Label order_client_IDLabel;
            System.Windows.Forms.Label order_company_IDLabel;
            System.Windows.Forms.Label order_job_nameLabel;
            System.Windows.Forms.Label order_addressLabel;
            System.Windows.Forms.Label order_priceLabel;
            System.Windows.Forms.Label order_worker_IDLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label lblTitle;
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.clientsTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.clientsTableAdapter();
            this.companiesTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.companiesTableAdapter();
            this.workersTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.workersTableAdapter();
            this.order_client_IDComboBox = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_company_IDComboBox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stroidtelstvoiremontDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_addressTextBox = new System.Windows.Forms.TextBox();
            this.order_worker_IDComboBox = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNewCompanySave = new System.Windows.Forms.Button();
            this.BtnExitForm = new System.Windows.Forms.Button();
            this.order_priceTextBox = new System.Windows.Forms.TextBox();
            this.order_dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnSetTodaysDate = new System.Windows.Forms.Button();
            this.order_job_nameComboBox = new System.Windows.Forms.ComboBox();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.jobsTableAdapter();
            order_client_IDLabel = new System.Windows.Forms.Label();
            order_company_IDLabel = new System.Windows.Forms.Label();
            order_job_nameLabel = new System.Windows.Forms.Label();
            order_addressLabel = new System.Windows.Forms.Label();
            order_priceLabel = new System.Windows.Forms.Label();
            order_worker_IDLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvoiremontDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // order_client_IDLabel
            // 
            order_client_IDLabel.AutoSize = true;
            order_client_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_client_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_client_IDLabel.Location = new System.Drawing.Point(7, 51);
            order_client_IDLabel.Name = "order_client_IDLabel";
            order_client_IDLabel.Size = new System.Drawing.Size(156, 33);
            order_client_IDLabel.TabIndex = 1;
            order_client_IDLabel.Text = "ФИО клиента";
            // 
            // order_company_IDLabel
            // 
            order_company_IDLabel.AutoSize = true;
            order_company_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_company_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_company_IDLabel.Location = new System.Drawing.Point(7, 98);
            order_company_IDLabel.Name = "order_company_IDLabel";
            order_company_IDLabel.Size = new System.Drawing.Size(281, 33);
            order_company_IDLabel.TabIndex = 3;
            order_company_IDLabel.Text = "Наименование компании";
            // 
            // order_job_nameLabel
            // 
            order_job_nameLabel.AutoSize = true;
            order_job_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_job_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_job_nameLabel.Location = new System.Drawing.Point(7, 145);
            order_job_nameLabel.Name = "order_job_nameLabel";
            order_job_nameLabel.Size = new System.Drawing.Size(377, 33);
            order_job_nameLabel.TabIndex = 5;
            order_job_nameLabel.Text = "Наименование проводимых работ";
            // 
            // order_addressLabel
            // 
            order_addressLabel.AutoSize = true;
            order_addressLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_addressLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_addressLabel.Location = new System.Drawing.Point(7, 191);
            order_addressLabel.Name = "order_addressLabel";
            order_addressLabel.Size = new System.Drawing.Size(369, 33);
            order_addressLabel.TabIndex = 7;
            order_addressLabel.Text = "Место проведения работ (адрес)";
            // 
            // order_priceLabel
            // 
            order_priceLabel.AutoSize = true;
            order_priceLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_priceLabel.Location = new System.Drawing.Point(7, 237);
            order_priceLabel.Name = "order_priceLabel";
            order_priceLabel.Size = new System.Drawing.Size(176, 33);
            order_priceLabel.TabIndex = 9;
            order_priceLabel.Text = "Цена за услугу";
            // 
            // order_worker_IDLabel
            // 
            order_worker_IDLabel.AutoSize = true;
            order_worker_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_worker_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_worker_IDLabel.Location = new System.Drawing.Point(7, 283);
            order_worker_IDLabel.Name = "order_worker_IDLabel";
            order_worker_IDLabel.Size = new System.Drawing.Size(280, 33);
            order_worker_IDLabel.TabIndex = 11;
            order_worker_IDLabel.Text = "Закрепленный работник";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            order_dateLabel.Location = new System.Drawing.Point(7, 333);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(213, 33);
            order_dateLabel.TabIndex = 13;
            order_dateLabel.Text = "Дата заказа работ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblTitle.Location = new System.Drawing.Point(7, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(306, 33);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Оформление нового заказа";
            // 
            // stroidtelstvo_i_remontDataSet
            // 
            this.stroidtelstvo_i_remontDataSet.DataSetName = "stroidtelstvo_i_remontDataSet";
            this.stroidtelstvo_i_remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.companiesTableAdapter = this.companiesTableAdapter;
            this.tableAdapterManager.completed_ordersTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // order_client_IDComboBox
            // 
            this.order_client_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "order_client_ID", true));
            this.order_client_IDComboBox.DataSource = this.clientsBindingSource;
            this.order_client_IDComboBox.DisplayMember = "client_name";
            this.order_client_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_client_IDComboBox.FormattingEnabled = true;
            this.order_client_IDComboBox.Location = new System.Drawing.Point(169, 48);
            this.order_client_IDComboBox.Name = "order_client_IDComboBox";
            this.order_client_IDComboBox.Size = new System.Drawing.Size(598, 41);
            this.order_client_IDComboBox.TabIndex = 3;
            this.order_client_IDComboBox.ValueMember = "client_ID";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // order_company_IDComboBox
            // 
            this.order_company_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "order_company_ID", true));
            this.order_company_IDComboBox.DataSource = this.companiesBindingSource;
            this.order_company_IDComboBox.DisplayMember = "company_name";
            this.order_company_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_company_IDComboBox.FormattingEnabled = true;
            this.order_company_IDComboBox.Location = new System.Drawing.Point(294, 95);
            this.order_company_IDComboBox.Name = "order_company_IDComboBox";
            this.order_company_IDComboBox.Size = new System.Drawing.Size(473, 41);
            this.order_company_IDComboBox.TabIndex = 4;
            this.order_company_IDComboBox.ValueMember = "company_ID";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.stroidtelstvoiremontDataSetBindingSource;
            // 
            // stroidtelstvoiremontDataSetBindingSource
            // 
            this.stroidtelstvoiremontDataSetBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            this.stroidtelstvoiremontDataSetBindingSource.Position = 0;
            // 
            // order_addressTextBox
            // 
            this.order_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_address", true));
            this.order_addressTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_addressTextBox.Location = new System.Drawing.Point(382, 188);
            this.order_addressTextBox.Name = "order_addressTextBox";
            this.order_addressTextBox.Size = new System.Drawing.Size(385, 40);
            this.order_addressTextBox.TabIndex = 8;
            // 
            // order_worker_IDComboBox
            // 
            this.order_worker_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "order_worker_ID", true));
            this.order_worker_IDComboBox.DataSource = this.workersBindingSource;
            this.order_worker_IDComboBox.DisplayMember = "worker_name";
            this.order_worker_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_worker_IDComboBox.FormattingEnabled = true;
            this.order_worker_IDComboBox.Location = new System.Drawing.Point(294, 280);
            this.order_worker_IDComboBox.Name = "order_worker_IDComboBox";
            this.order_worker_IDComboBox.Size = new System.Drawing.Size(473, 41);
            this.order_worker_IDComboBox.TabIndex = 12;
            this.order_worker_IDComboBox.ValueMember = "worker_ID";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // BtnNewCompanySave
            // 
            this.BtnNewCompanySave.BackColor = System.Drawing.Color.Green;
            this.BtnNewCompanySave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewCompanySave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNewCompanySave.Location = new System.Drawing.Point(12, 373);
            this.BtnNewCompanySave.Name = "BtnNewCompanySave";
            this.BtnNewCompanySave.Size = new System.Drawing.Size(755, 82);
            this.BtnNewCompanySave.TabIndex = 16;
            this.BtnNewCompanySave.Text = "Оформить заказ";
            this.BtnNewCompanySave.UseVisualStyleBackColor = false;
            this.BtnNewCompanySave.Click += new System.EventHandler(this.BtnNewCompanySave_Click);
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.BackColor = System.Drawing.Color.Red;
            this.BtnExitForm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExitForm.Location = new System.Drawing.Point(569, 2);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(198, 40);
            this.BtnExitForm.TabIndex = 17;
            this.BtnExitForm.Text = "Выход из окна";
            this.BtnExitForm.UseVisualStyleBackColor = false;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // order_priceTextBox
            // 
            this.order_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_price", true));
            this.order_priceTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_priceTextBox.Location = new System.Drawing.Point(189, 234);
            this.order_priceTextBox.Name = "order_priceTextBox";
            this.order_priceTextBox.Size = new System.Drawing.Size(578, 40);
            this.order_priceTextBox.TabIndex = 10;
            // 
            // order_dateMaskedTextBox
            // 
            this.order_dateMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_date", true));
            this.order_dateMaskedTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_dateMaskedTextBox.Location = new System.Drawing.Point(226, 330);
            this.order_dateMaskedTextBox.Mask = "00/00/0000";
            this.order_dateMaskedTextBox.Name = "order_dateMaskedTextBox";
            this.order_dateMaskedTextBox.Size = new System.Drawing.Size(416, 40);
            this.order_dateMaskedTextBox.TabIndex = 18;
            this.order_dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // btnSetTodaysDate
            // 
            this.btnSetTodaysDate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetTodaysDate.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetTodaysDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetTodaysDate.Location = new System.Drawing.Point(648, 330);
            this.btnSetTodaysDate.Name = "btnSetTodaysDate";
            this.btnSetTodaysDate.Size = new System.Drawing.Size(119, 40);
            this.btnSetTodaysDate.TabIndex = 19;
            this.btnSetTodaysDate.Text = "Текущая дата";
            this.btnSetTodaysDate.UseVisualStyleBackColor = false;
            this.btnSetTodaysDate.Click += new System.EventHandler(this.btnSetTodaysDate_Click);
            // 
            // order_job_nameComboBox
            // 
            this.order_job_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "order_job_name", true));
            this.order_job_nameComboBox.DataSource = this.jobsBindingSource;
            this.order_job_nameComboBox.DisplayMember = "job_name";
            this.order_job_nameComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_job_nameComboBox.FormattingEnabled = true;
            this.order_job_nameComboBox.Location = new System.Drawing.Point(390, 142);
            this.order_job_nameComboBox.Name = "order_job_nameComboBox";
            this.order_job_nameComboBox.Size = new System.Drawing.Size(377, 41);
            this.order_job_nameComboBox.TabIndex = 20;
            this.order_job_nameComboBox.ValueMember = "job_ID";
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "jobs";
            this.jobsBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // OrderCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(777, 462);
            this.ControlBox = false;
            this.Controls.Add(this.order_job_nameComboBox);
            this.Controls.Add(this.btnSetTodaysDate);
            this.Controls.Add(this.order_dateMaskedTextBox);
            this.Controls.Add(this.BtnExitForm);
            this.Controls.Add(this.BtnNewCompanySave);
            this.Controls.Add(lblTitle);
            this.Controls.Add(order_dateLabel);
            this.Controls.Add(this.order_worker_IDComboBox);
            this.Controls.Add(order_worker_IDLabel);
            this.Controls.Add(order_priceLabel);
            this.Controls.Add(this.order_priceTextBox);
            this.Controls.Add(order_addressLabel);
            this.Controls.Add(this.order_addressTextBox);
            this.Controls.Add(order_job_nameLabel);
            this.Controls.Add(this.order_company_IDComboBox);
            this.Controls.Add(order_company_IDLabel);
            this.Controls.Add(this.order_client_IDComboBox);
            this.Controls.Add(order_client_IDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление нового заказа";
            this.Load += new System.EventHandler(this.OrderCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvoiremontDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private stroidtelstvo_i_remontDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox order_client_IDComboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.ComboBox order_company_IDComboBox;
        private System.Windows.Forms.BindingSource stroidtelstvoiremontDataSetBindingSource;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.TextBox order_addressTextBox;
        private System.Windows.Forms.ComboBox order_worker_IDComboBox;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.Button BtnNewCompanySave;
        private System.Windows.Forms.Button BtnExitForm;
        private System.Windows.Forms.TextBox order_priceTextBox;
        private System.Windows.Forms.MaskedTextBox order_dateMaskedTextBox;
        private System.Windows.Forms.Button btnSetTodaysDate;
        private System.Windows.Forms.ComboBox order_job_nameComboBox;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.jobsTableAdapter jobsTableAdapter;
    }
}