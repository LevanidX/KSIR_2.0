namespace Main_System_Stroitelstvo_I_Remont
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClientRegistration = new System.Windows.Forms.Button();
            this.btnWorkerRegistration = new System.Windows.Forms.Button();
            this.btnCompanyRegistration = new System.Windows.Forms.Button();
            this.btnOrderCreation = new System.Windows.Forms.Button();
            this.btnCompletedOrders = new System.Windows.Forms.Button();
            this.btnApplicationExit = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnViewDataBase = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.btnViewActiveOrders = new System.Windows.Forms.Button();
            this.btnViewClients = new System.Windows.Forms.Button();
            this.btnViewWorkers = new System.Windows.Forms.Button();
            this.btnViewCompanies = new System.Windows.Forms.Button();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.MyUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(463, 66);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Муниципальное автономное учреждение \r\n«Капитальное строительство и ремонт»";
            // 
            // btnClientRegistration
            // 
            this.btnClientRegistration.BackColor = System.Drawing.Color.Green;
            this.btnClientRegistration.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClientRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientRegistration.Location = new System.Drawing.Point(6, 32);
            this.btnClientRegistration.Name = "btnClientRegistration";
            this.btnClientRegistration.Size = new System.Drawing.Size(484, 90);
            this.btnClientRegistration.TabIndex = 1;
            this.btnClientRegistration.Text = "Регистрация нового клиента";
            this.btnClientRegistration.UseVisualStyleBackColor = false;
            this.btnClientRegistration.Visible = false;
            this.btnClientRegistration.Click += new System.EventHandler(this.btnClientRegistration_Click);
            // 
            // btnWorkerRegistration
            // 
            this.btnWorkerRegistration.BackColor = System.Drawing.Color.Green;
            this.btnWorkerRegistration.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkerRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWorkerRegistration.Location = new System.Drawing.Point(6, 128);
            this.btnWorkerRegistration.Name = "btnWorkerRegistration";
            this.btnWorkerRegistration.Size = new System.Drawing.Size(484, 90);
            this.btnWorkerRegistration.TabIndex = 2;
            this.btnWorkerRegistration.Text = "Регистрация нового сотрудника";
            this.btnWorkerRegistration.UseVisualStyleBackColor = false;
            this.btnWorkerRegistration.Visible = false;
            this.btnWorkerRegistration.Click += new System.EventHandler(this.btnWorkerRegistration_Click);
            // 
            // btnCompanyRegistration
            // 
            this.btnCompanyRegistration.BackColor = System.Drawing.Color.Green;
            this.btnCompanyRegistration.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCompanyRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompanyRegistration.Location = new System.Drawing.Point(6, 224);
            this.btnCompanyRegistration.Name = "btnCompanyRegistration";
            this.btnCompanyRegistration.Size = new System.Drawing.Size(484, 98);
            this.btnCompanyRegistration.TabIndex = 3;
            this.btnCompanyRegistration.Text = "Регистрация новой компании";
            this.btnCompanyRegistration.UseVisualStyleBackColor = false;
            this.btnCompanyRegistration.Visible = false;
            this.btnCompanyRegistration.Click += new System.EventHandler(this.btnCompanyRegistration_Click);
            // 
            // btnOrderCreation
            // 
            this.btnOrderCreation.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOrderCreation.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrderCreation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderCreation.Location = new System.Drawing.Point(6, 32);
            this.btnOrderCreation.Name = "btnOrderCreation";
            this.btnOrderCreation.Size = new System.Drawing.Size(484, 90);
            this.btnOrderCreation.TabIndex = 4;
            this.btnOrderCreation.Text = "Оформление заказа";
            this.btnOrderCreation.UseVisualStyleBackColor = false;
            this.btnOrderCreation.Visible = false;
            this.btnOrderCreation.Click += new System.EventHandler(this.btnOrderCreation_Click);
            // 
            // btnCompletedOrders
            // 
            this.btnCompletedOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCompletedOrders.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCompletedOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompletedOrders.Location = new System.Drawing.Point(6, 224);
            this.btnCompletedOrders.Name = "btnCompletedOrders";
            this.btnCompletedOrders.Size = new System.Drawing.Size(484, 100);
            this.btnCompletedOrders.TabIndex = 5;
            this.btnCompletedOrders.Text = "Выполненные заказы";
            this.btnCompletedOrders.UseVisualStyleBackColor = false;
            this.btnCompletedOrders.Visible = false;
            this.btnCompletedOrders.Click += new System.EventHandler(this.btnCompletedOrders_Click);
            // 
            // btnApplicationExit
            // 
            this.btnApplicationExit.BackColor = System.Drawing.Color.Red;
            this.btnApplicationExit.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplicationExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApplicationExit.Location = new System.Drawing.Point(481, 12);
            this.btnApplicationExit.Name = "btnApplicationExit";
            this.btnApplicationExit.Size = new System.Drawing.Size(278, 63);
            this.btnApplicationExit.TabIndex = 6;
            this.btnApplicationExit.Text = "Выход из программы";
            this.btnApplicationExit.UseVisualStyleBackColor = false;
            this.btnApplicationExit.Click += new System.EventHandler(this.btnApplicationExit_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Green;
            this.btnRegistration.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistration.Location = new System.Drawing.Point(12, 78);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(245, 106);
            this.btnRegistration.TabIndex = 7;
            this.btnRegistration.Text = "Регистрация в систему";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnViewDataBase
            // 
            this.btnViewDataBase.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewDataBase.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewDataBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewDataBase.Location = new System.Drawing.Point(12, 190);
            this.btnViewDataBase.Name = "btnViewDataBase";
            this.btnViewDataBase.Size = new System.Drawing.Size(245, 106);
            this.btnViewDataBase.TabIndex = 8;
            this.btnViewDataBase.Text = "Просмотр базы данных";
            this.btnViewDataBase.UseVisualStyleBackColor = false;
            this.btnViewDataBase.Click += new System.EventHandler(this.btnViewDataBase_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOrders.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrders.Location = new System.Drawing.Point(12, 302);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(245, 106);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // groupButtons
            // 
            this.groupButtons.Controls.Add(this.btnViewClients);
            this.groupButtons.Controls.Add(this.btnViewWorkers);
            this.groupButtons.Controls.Add(this.btnViewCompanies);
            this.groupButtons.Controls.Add(this.btnClientRegistration);
            this.groupButtons.Controls.Add(this.btnWorkerRegistration);
            this.groupButtons.Controls.Add(this.btnCompanyRegistration);
            this.groupButtons.Controls.Add(this.btnCompletedOrders);
            this.groupButtons.Controls.Add(this.btnViewActiveOrders);
            this.groupButtons.Controls.Add(this.btnOrderCreation);
            this.groupButtons.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupButtons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupButtons.Location = new System.Drawing.Point(263, 78);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(496, 330);
            this.groupButtons.TabIndex = 10;
            this.groupButtons.TabStop = false;
            this.groupButtons.Text = "Выбор действия";
            // 
            // btnViewActiveOrders
            // 
            this.btnViewActiveOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.btnViewActiveOrders.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewActiveOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewActiveOrders.Location = new System.Drawing.Point(6, 128);
            this.btnViewActiveOrders.Name = "btnViewActiveOrders";
            this.btnViewActiveOrders.Size = new System.Drawing.Size(484, 90);
            this.btnViewActiveOrders.TabIndex = 14;
            this.btnViewActiveOrders.Text = "Просмотр активных заказов";
            this.btnViewActiveOrders.UseVisualStyleBackColor = false;
            this.btnViewActiveOrders.Visible = false;
            this.btnViewActiveOrders.Click += new System.EventHandler(this.btnViewActiveOrders_Click);
            // 
            // btnViewClients
            // 
            this.btnViewClients.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewClients.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewClients.Location = new System.Drawing.Point(6, 32);
            this.btnViewClients.Name = "btnViewClients";
            this.btnViewClients.Size = new System.Drawing.Size(484, 90);
            this.btnViewClients.TabIndex = 11;
            this.btnViewClients.Text = "Просмотр базы данных клиентов";
            this.btnViewClients.UseVisualStyleBackColor = false;
            this.btnViewClients.Visible = false;
            this.btnViewClients.Click += new System.EventHandler(this.btnViewClients_Click);
            // 
            // btnViewWorkers
            // 
            this.btnViewWorkers.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewWorkers.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewWorkers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewWorkers.Location = new System.Drawing.Point(6, 128);
            this.btnViewWorkers.Name = "btnViewWorkers";
            this.btnViewWorkers.Size = new System.Drawing.Size(484, 90);
            this.btnViewWorkers.TabIndex = 12;
            this.btnViewWorkers.Text = "Просмотр базы данных сотрудников";
            this.btnViewWorkers.UseVisualStyleBackColor = false;
            this.btnViewWorkers.Visible = false;
            this.btnViewWorkers.Click += new System.EventHandler(this.btnViewWorkers_Click);
            // 
            // btnViewCompanies
            // 
            this.btnViewCompanies.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewCompanies.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewCompanies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewCompanies.Location = new System.Drawing.Point(6, 224);
            this.btnViewCompanies.Name = "btnViewCompanies";
            this.btnViewCompanies.Size = new System.Drawing.Size(484, 98);
            this.btnViewCompanies.TabIndex = 13;
            this.btnViewCompanies.Text = "Просмотр базы данных компаний";
            this.btnViewCompanies.UseVisualStyleBackColor = false;
            this.btnViewCompanies.Visible = false;
            this.btnViewCompanies.Click += new System.EventHandler(this.btnViewCompanies_Click);
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarningMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWarningMessage.Location = new System.Drawing.Point(83, 411);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(590, 33);
            this.lblWarningMessage.TabIndex = 11;
            this.lblWarningMessage.Text = "Для дальнейшей работы выберите пункт меню слева";
            // 
            // MyUpdate
            // 
            this.MyUpdate.Enabled = true;
            this.MyUpdate.Tick += new System.EventHandler(this.MyUpdate_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(765, 451);
            this.ControlBox = false;
            this.Controls.Add(this.lblWarningMessage);
            this.Controls.Add(this.groupButtons);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnViewDataBase);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnApplicationExit);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.groupButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClientRegistration;
        private System.Windows.Forms.Button btnWorkerRegistration;
        private System.Windows.Forms.Button btnCompanyRegistration;
        private System.Windows.Forms.Button btnOrderCreation;
        private System.Windows.Forms.Button btnCompletedOrders;
        private System.Windows.Forms.Button btnApplicationExit;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnViewDataBase;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.GroupBox groupButtons;
        private System.Windows.Forms.Label lblWarningMessage;
        private System.Windows.Forms.Button btnViewCompanies;
        private System.Windows.Forms.Button btnViewWorkers;
        private System.Windows.Forms.Button btnViewClients;
        private System.Windows.Forms.Button btnViewActiveOrders;
        private System.Windows.Forms.Timer MyUpdate;
    }
}

