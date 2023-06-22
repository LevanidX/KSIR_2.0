using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class OrderStatement : Form
    {
        private string _orderNumber;

        public OrderStatement(string orderNumber)
        {
            InitializeComponent();
            _orderNumber = orderNumber;
        }

        private void btnEndOrderCompletely_Click(object sender, EventArgs e)
        {
            this.Validate();
            completed_ordersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(stroidtelstvo_i_remontDataSet);

            this.Close();
        }

        private void OrderStatement_Load(object sender, EventArgs e)
        {
            this.completed_ordersTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.completed_orders);
            completed_ordersBindingSource.Filter = $"[completed_order_ID]='" + _orderNumber + "'";
        }

        private void btnSetTodaysDate_Click(object sender, EventArgs e)
        {
            completed_order_dateMaskedTextBox.Text = DateTime.Now.ToString();
        }
    }
}
