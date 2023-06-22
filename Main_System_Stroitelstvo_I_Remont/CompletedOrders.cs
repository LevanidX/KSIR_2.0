using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class CompletedOrders : Form
    {
        AppNavigation appNavigation = new AppNavigation();

        public CompletedOrders()
        {
            InitializeComponent();
        }

        private void CompletedOrders_Load(object sender, EventArgs e)
        {
            this.completed_orders_viewTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.completed_orders_view);
            this.completed_ordersTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.completed_orders);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }
    }
}
