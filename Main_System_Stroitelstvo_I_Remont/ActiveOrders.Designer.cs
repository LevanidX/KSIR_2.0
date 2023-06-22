namespace Main_System_Stroitelstvo_I_Remont
{
    partial class ActiveOrders
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
            this.btnEndOrder = new System.Windows.Forms.Button();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExitForm = new System.Windows.Forms.Button();
            this.orders_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.orders_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.orders_viewTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.orders_viewTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orders_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndOrder
            // 
            this.btnEndOrder.BackColor = System.Drawing.Color.Red;
            this.btnEndOrder.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEndOrder.Location = new System.Drawing.Point(12, 269);
            this.btnEndOrder.Name = "btnEndOrder";
            this.btnEndOrder.Size = new System.Drawing.Size(875, 92);
            this.btnEndOrder.TabIndex = 2;
            this.btnEndOrder.Text = "Завершить заказ";
            this.btnEndOrder.UseVisualStyleBackColor = false;
            this.btnEndOrder.Click += new System.EventHandler(this.btnEndOrder_Click);
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarningMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWarningMessage.Location = new System.Drawing.Point(176, 364);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(559, 33);
            this.lblWarningMessage.TabIndex = 12;
            this.lblWarningMessage.Text = "Для завершения заказа выберите заказ из списка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Активные заказы";
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.BackColor = System.Drawing.Color.Red;
            this.BtnExitForm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExitForm.Location = new System.Drawing.Point(689, 2);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(198, 40);
            this.BtnExitForm.TabIndex = 18;
            this.BtnExitForm.Text = "Выход из окна";
            this.BtnExitForm.UseVisualStyleBackColor = false;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // orders_viewDataGridView
            // 
            this.orders_viewDataGridView.AllowUserToAddRows = false;
            this.orders_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orders_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.job_name,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.orders_viewDataGridView.DataSource = this.orders_viewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orders_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.orders_viewDataGridView.Location = new System.Drawing.Point(12, 45);
            this.orders_viewDataGridView.Name = "orders_viewDataGridView";
            this.orders_viewDataGridView.ReadOnly = true;
            this.orders_viewDataGridView.Size = new System.Drawing.Size(875, 218);
            this.orders_viewDataGridView.TabIndex = 1;
            this.orders_viewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_viewDataGridView_CellClick);
            // 
            // orders_viewBindingSource
            // 
            this.orders_viewBindingSource.DataMember = "orders_view";
            this.orders_viewBindingSource.DataSource = this.stroidtelstvo_i_remontDataSet;
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
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.companiesTableAdapter = null;
            this.tableAdapterManager.completed_ordersTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = null;
            // 
            // orders_viewTableAdapter
            // 
            this.orders_viewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // job_name
            // 
            this.job_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.job_name.DataPropertyName = "job_name";
            this.job_name.HeaderText = "Наименование работ";
            this.job_name.Name = "job_name";
            this.job_name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена за услугу";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "order_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата заказа работ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ActiveOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(899, 406);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExitForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarningMessage);
            this.Controls.Add(this.btnEndOrder);
            this.Controls.Add(this.orders_viewDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ActiveOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Активные заказы";
            this.Load += new System.EventHandler(this.ActiveOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource orders_viewBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.orders_viewTableAdapter orders_viewTableAdapter;
        private System.Windows.Forms.Button btnEndOrder;
        private System.Windows.Forms.Label lblWarningMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExitForm;
        private System.Windows.Forms.DataGridView orders_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}