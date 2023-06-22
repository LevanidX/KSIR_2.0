using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class CompanyRegistration : Form
    {
        Registration registration = new Registration();
        AppNavigation appNavigation = new AppNavigation();

        public CompanyRegistration()
        {
            InitializeComponent();
        }

        private void CompanyRegistration_Load(object sender, EventArgs e)
        {
            registration.BeginRegistration(companiesBindingSource);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }

        private void BtnNewCompanySave_Click(object sender, EventArgs e)
        {
            if (company_nameTextBox.Text != "")
            {
                registration.SaveNewRegistration(this, companiesBindingSource, tableAdapterManager, stroidtelstvo_i_remontDataSet);
            }
            else
            {
                registration.ShowWarningMessage();
            }
        }
    }
}
