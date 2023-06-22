namespace Main_System_Stroitelstvo_I_Remont
{
    partial class OrderStatement
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
            this.statementComboBox = new System.Windows.Forms.ComboBox();
            this.completed_ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stroidtelstvo_i_remontDataSet = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSet();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndOrderCompletely = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.completed_ordersTableAdapter = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.completed_ordersTableAdapter();
            this.tableAdapterManager = new Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager();
            this.btnSetTodaysDate = new System.Windows.Forms.Button();
            this.completed_order_dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.completed_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statementComboBox
            // 
            this.statementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.completed_ordersBindingSource, "completed_order_statement", true));
            this.statementComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statementComboBox.FormattingEnabled = true;
            this.statementComboBox.Items.AddRange(new object[] {
            "Выполнен",
            "Отменен"});
            this.statementComboBox.Location = new System.Drawing.Point(184, 56);
            this.statementComboBox.Name = "statementComboBox";
            this.statementComboBox.Size = new System.Drawing.Size(347, 41);
            this.statementComboBox.TabIndex = 0;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Статус заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата выполнения работ";
            // 
            // btnEndOrderCompletely
            // 
            this.btnEndOrderCompletely.BackColor = System.Drawing.Color.Red;
            this.btnEndOrderCompletely.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndOrderCompletely.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEndOrderCompletely.Location = new System.Drawing.Point(12, 152);
            this.btnEndOrderCompletely.Name = "btnEndOrderCompletely";
            this.btnEndOrderCompletely.Size = new System.Drawing.Size(519, 82);
            this.btnEndOrderCompletely.TabIndex = 17;
            this.btnEndOrderCompletely.Text = "Завершить заказ";
            this.btnEndOrderCompletely.UseVisualStyleBackColor = false;
            this.btnEndOrderCompletely.Click += new System.EventHandler(this.btnEndOrderCompletely_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Завершение заказа";
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
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = null;
            // 
            // btnSetTodaysDate
            // 
            this.btnSetTodaysDate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetTodaysDate.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetTodaysDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetTodaysDate.Location = new System.Drawing.Point(418, 105);
            this.btnSetTodaysDate.Name = "btnSetTodaysDate";
            this.btnSetTodaysDate.Size = new System.Drawing.Size(113, 40);
            this.btnSetTodaysDate.TabIndex = 21;
            this.btnSetTodaysDate.Text = "Текущая дата";
            this.btnSetTodaysDate.UseVisualStyleBackColor = false;
            this.btnSetTodaysDate.Click += new System.EventHandler(this.btnSetTodaysDate_Click);
            // 
            // completed_order_dateMaskedTextBox
            // 
            this.completed_order_dateMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.completed_ordersBindingSource, "completed_order_date", true));
            this.completed_order_dateMaskedTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completed_order_dateMaskedTextBox.Location = new System.Drawing.Point(289, 105);
            this.completed_order_dateMaskedTextBox.Mask = "00/00/0000";
            this.completed_order_dateMaskedTextBox.Name = "completed_order_dateMaskedTextBox";
            this.completed_order_dateMaskedTextBox.Size = new System.Drawing.Size(123, 40);
            this.completed_order_dateMaskedTextBox.TabIndex = 20;
            this.completed_order_dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // OrderStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(551, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btnSetTodaysDate);
            this.Controls.Add(this.completed_order_dateMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEndOrderCompletely);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.statementComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завершение заказа";
            this.Load += new System.EventHandler(this.OrderStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completed_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stroidtelstvo_i_remontDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statementComboBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndOrderCompletely;
        private System.Windows.Forms.Label label2;
        private stroidtelstvo_i_remontDataSet stroidtelstvo_i_remontDataSet;
        private System.Windows.Forms.BindingSource completed_ordersBindingSource;
        private stroidtelstvo_i_remontDataSetTableAdapters.completed_ordersTableAdapter completed_ordersTableAdapter;
        private stroidtelstvo_i_remontDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSetTodaysDate;
        private System.Windows.Forms.MaskedTextBox completed_order_dateMaskedTextBox;
    }
}