namespace Main_System_Stroitelstvo_I_Remont
{
    partial class CompletedOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.completed_ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.completed_ordersTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.completed_ordersTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.completed_orders_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.completed_orders_viewTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.completed_orders_viewTableAdapter();
            this.completed_orders_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnExitForm = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.completed_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completed_orders_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completed_orders_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // completed_ordersBindingSource
            // 
            this.completed_ordersBindingSource.DataMember = "completed_orders";
            this.completed_ordersBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // stroidtelstvo_i_remontDataSet
            // 
            this.stroidtelstvo_i_remontDataSet.DataSetName = "stroidtelstvo_i_remontDataSet";
            this.stroidtelstvo_i_remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // completed_ordersTableAdapter
            // 
            this.completed_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.companiesTableAdapter = null;
            this.tableAdapterManager.completed_ordersTableAdapter = this.completed_ordersTableAdapter;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = null;
            // 
            // completed_orders_viewBindingSource
            // 
            this.completed_orders_viewBindingSource.DataMember = "completed_orders_view";
            this.completed_orders_viewBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
            // 
            // completed_orders_viewTableAdapter
            // 
            this.completed_orders_viewTableAdapter.ClearBeforeFill = true;
            // 
            // completed_orders_viewDataGridView
            // 
            this.completed_orders_viewDataGridView.AllowUserToAddRows = false;
            this.completed_orders_viewDataGridView.AllowUserToDeleteRows = false;
            this.completed_orders_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.completed_orders_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.completed_orders_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completed_orders_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.job_name,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.completed_orders_viewDataGridView.DataSource = this.completed_orders_viewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.completed_orders_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.completed_orders_viewDataGridView.Location = new System.Drawing.Point(12, 46);
            this.completed_orders_viewDataGridView.Name = "completed_orders_viewDataGridView";
            this.completed_orders_viewDataGridView.ReadOnly = true;
            this.completed_orders_viewDataGridView.Size = new System.Drawing.Size(1073, 408);
            this.completed_orders_viewDataGridView.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Выполненные заказы";
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.BackColor = System.Drawing.Color.Red;
            this.BtnExitForm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExitForm.Location = new System.Drawing.Point(887, 5);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(198, 40);
            this.BtnExitForm.TabIndex = 19;
            this.BtnExitForm.Text = "Выход из окна";
            this.BtnExitForm.UseVisualStyleBackColor = false;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "completed_order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "client_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО клиента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "company_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование компании";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // job_name
            // 
            this.job_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.job_name.DataPropertyName = "job_name";
            this.job_name.HeaderText = "Наименование работ";
            this.job_name.Name = "job_name";
            this.job_name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "completed_order_address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Место проведенных работ (адрес)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "completed_order_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена за услугу";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "worker_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Закрепленный работник";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "completed_order_statement";
            this.dataGridViewTextBoxColumn8.HeaderText = "Статус заказа";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "completed_order_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "День окончания заказа";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // CompletedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1097, 466);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExitForm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.completed_orders_viewDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompletedOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполненные заказы";
            this.Load += new System.EventHandler(this.CompletedOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completed_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completed_orders_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completed_orders_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource completed_ordersBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.completed_ordersTableAdapter completed_ordersTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource completed_orders_viewBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.completed_orders_viewTableAdapter completed_orders_viewTableAdapter;
        private System.Windows.Forms.DataGridView completed_orders_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnExitForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}