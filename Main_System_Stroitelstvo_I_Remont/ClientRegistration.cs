using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class ClientRegistration : Form
    {
        Registration registration = new Registration();
        AppNavigation appNavigation = new AppNavigation();

        public ClientRegistration()
        {
            InitializeComponent();
        }

        private void ClientRegistration_Load(object sender, EventArgs e)
        {
            registration.BeginRegistration(clientsBindingSource);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }

        private void BtnNewClientSave_Click(object sender, EventArgs e)
        {
            if (client_nameTextBox.Text != "" && client_phone_numberTextBox.Text != "" && client_home_addressTextBox.Text != "") 
            {
                registration.SaveNewRegistration(this, clientsBindingSource, tableAdapterManager, stroidtelstvo_i_remontDataSet);
            }
            else
            {
                registration.ShowWarningMessage();
            }
        }
    }
}
