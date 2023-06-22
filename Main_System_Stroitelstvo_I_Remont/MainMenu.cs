using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class MainMenu : Form
    {
        AppNavigation appNavigation = new AppNavigation();

        private static event Action<bool> OnRegistrationOpened;
        private static event Action<bool> OnViewingOpened;
        private static event Action<bool> OnOrderingOpened;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnClientRegistration_Click(object sender, EventArgs e)
        {
            ClientRegistration clientRegistration = new ClientRegistration();
            appNavigation.OpenNewWindow(this, clientRegistration);
        }

        private void btnWorkerRegistration_Click(object sender, EventArgs e)
        {
            WorkerRegistration workerRegistration = new WorkerRegistration();
            appNavigation.OpenNewWindow(this, workerRegistration);
        }

        private void btnCompanyRegistration_Click(object sender, EventArgs e)
        {
            CompanyRegistration companyRegistration = new CompanyRegistration();
            appNavigation.OpenNewWindow(this, companyRegistration);
        }

        private void btnOrderCreation_Click(object sender, EventArgs e)
        {
            OrderCreation orderCreation = new OrderCreation();
            appNavigation.OpenNewWindow(this, orderCreation);
        }

        private void btnViewActiveOrders_Click(object sender, EventArgs e)
        {
            ActiveOrders activeOrders = new ActiveOrders();
            appNavigation.OpenNewWindow(this, activeOrders);
        }

        private void btnCompletedOrders_Click(object sender, EventArgs e)
        {
            CompletedOrders completedOrders = new CompletedOrders();
            appNavigation.OpenNewWindow(this, completedOrders);
        }

        private void btnViewClients_Click(object sender, EventArgs e)
        {
            ClientsDataBase clientsDataBase = new ClientsDataBase();
            appNavigation.OpenNewWindow(this, clientsDataBase);
        }

        private void btnViewWorkers_Click(object sender, EventArgs e)
        {
            WorkersDataBase workersDataBase = new WorkersDataBase();
            appNavigation.OpenNewWindow(this, workersDataBase);
        }

        private void btnViewCompanies_Click(object sender, EventArgs e)
        {
            CompaniesDataBase companiesDataBase = new CompaniesDataBase();
            appNavigation.OpenNewWindow(this, companiesDataBase);
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            OnRegistrationOpened?.Invoke(true);
            OnViewingOpened?.Invoke(false);
            OnOrderingOpened?.Invoke(false);
        }

        private void btnViewDataBase_Click(object sender, EventArgs e)
        {
            OnRegistrationOpened?.Invoke(false);
            OnViewingOpened?.Invoke(true);
            OnOrderingOpened?.Invoke(false);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OnRegistrationOpened?.Invoke(false);
            OnViewingOpened?.Invoke(false);
            OnOrderingOpened?.Invoke(true);
        }

        private void MyUpdate_Tick(object sender, EventArgs e)
        {
            OnRegistrationOpened += RegistrationButtons;
            OnViewingOpened += ViewingButtons;
            OnOrderingOpened += OrderButtons;
        }

        private void RegistrationButtons(bool isShow)
        {
            btnClientRegistration.Visible = isShow;
            btnWorkerRegistration.Visible = isShow;
            btnCompanyRegistration.Visible = isShow;
        }

        private void ViewingButtons(bool isShow)
        {
            btnViewClients.Visible = isShow;
            btnViewWorkers.Visible = isShow;
            btnViewCompanies.Visible = isShow;
        }

        private void OrderButtons(bool isShow)
        {
            btnOrderCreation.Visible = isShow;
            btnViewActiveOrders.Visible = isShow;
            btnCompletedOrders.Visible = isShow;
        }
    }
}
