using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class ActiveOrders : Form
    {
        AppNavigation appNavigation = new AppNavigation();

        private static int _selectedIndex;
        private static string _orderNumber;
        private static bool _isCellClicked;

        public ActiveOrders()
        {
            InitializeComponent();
        }

        private void ActiveOrders_Load(object sender, EventArgs e)
        {
            this.orders_viewTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.orders_view);
            this.ordersTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.orders);

            _isCellClicked = false;
        }

        private void btnEndOrder_Click(object sender, EventArgs e)
        {
            if (_isCellClicked)
            {
                var messageText = MessageBox.Show(
                    "Вы действительно хотите завершить заказ номер - " + _orderNumber + "?",
                    "Муниципальное автономное учреждение «Капитальное строительство и ремонт»",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (messageText == DialogResult.Yes)
                {
                    ordersBindingSource.RemoveAt(_selectedIndex);
                    orders_viewDataGridView.Rows.RemoveAt(_selectedIndex);

                    this.Validate();
                    orders_viewBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(stroidtelstvo_i_remontDataSet);

                    OrderStatement orderStatement = new OrderStatement(_orderNumber);
                    orderStatement.Show();
                }
            }
        }

        private void orders_viewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isCellClicked = true;

            _selectedIndex = e.RowIndex;
            if (_selectedIndex >= 0)
            {
                DataGridViewRow row = orders_viewDataGridView.Rows[_selectedIndex];
                _orderNumber = row.Cells[0].Value.ToString();
            }
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }
    }
}
