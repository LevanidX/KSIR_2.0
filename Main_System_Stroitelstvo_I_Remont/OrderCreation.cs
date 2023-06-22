using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class OrderCreation : Form
    {
        Registration registration = new Registration();
        AppNavigation appNavigation = new AppNavigation();

        public OrderCreation()
        {
            InitializeComponent();
        }

        private void OrderCreation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stroidtelstvo_i_remontDataSet.jobs". При необходимости она может быть перемещена или удалена.
            this.jobsTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.jobs);
            this.clientsTableAdapter.Fill(stroidtelstvo_i_remontDataSet.clients);
            this.companiesTableAdapter.Fill(stroidtelstvo_i_remontDataSet.companies);
            this.workersTableAdapter.Fill(stroidtelstvo_i_remontDataSet.workers);

            registration.BeginRegistration(ordersBindingSource);
        }

        private void BtnNewCompanySave_Click(object sender, EventArgs e)
        {
            if (order_client_IDComboBox.Text != "" && order_company_IDComboBox.Text != "" &&
                order_job_nameComboBox.Text != "" && order_addressTextBox.Text != "" &&
                order_priceTextBox.Text != "" && order_worker_IDComboBox.Text != "" && 
                order_dateMaskedTextBox.Text != "")
            {
                registration.SaveNewRegistration(this, ordersBindingSource, tableAdapterManager, stroidtelstvo_i_remontDataSet);
            }
            else
            {
                registration.ShowWarningMessage();
            }
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }

        private void btnSetTodaysDate_Click(object sender, EventArgs e)
        {
            order_dateMaskedTextBox.Text = DateTime.Now.ToString();
        }
    }
}
