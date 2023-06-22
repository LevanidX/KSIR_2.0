using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class ClientsDataBase : Form
    {
        AppNavigation appNavigation = new AppNavigation();
        Viewing viewing = new Viewing();

        public ClientsDataBase()
        {
            InitializeComponent();
        }

        private void ClientsDataBase_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.clients);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewing.Searching(clientsDataGridView, searchTextBox);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewing.ClearAll(clientsDataGridView, clientsBindingSource, searchTextBox);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }
    }
}
