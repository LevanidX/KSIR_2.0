using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class WorkerRegistration : Form
    {
        Registration registration = new Registration();
        AppNavigation appNavigation = new AppNavigation();

        public WorkerRegistration()
        {
            InitializeComponent();
        }

        private void WorkerRegistration_Load(object sender, EventArgs e)
        {
            registration.BeginRegistration(workersBindingSource);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }

        private void BtnNewClientSave_Click(object sender, EventArgs e)
        {
            if (worker_nameTextBox.Text != "" && worker_phone_numberMaskedTextBox.Text != "")
            {
                registration.SaveNewRegistration(this, workersBindingSource, tableAdapterManager, stroidtelstvo_i_remontDataSet);
            }
            else
            {
                registration.ShowWarningMessage();
            }
        }
    }
}
