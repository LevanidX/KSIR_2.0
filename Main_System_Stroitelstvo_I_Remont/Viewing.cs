using System.Drawing;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    internal class Viewing
    {
        private int _itemsFound;

        public void Searching(DataGridView dataGridView, TextBox searchTextBox)
        {
            if (searchTextBox.Text != "")
            {
                SetCellsColor(dataGridView, searchTextBox, Color.White, Color.Black, false);
                SetCellsColor(dataGridView, searchTextBox, Color.Black, Color.White, true);

                if (_itemsFound > 0)
                {
                    MessageBox.Show(
                        "Всего найденных результатов - " + _itemsFound + ".",
                        "Муниципальное автономное учреждение «Капитальное строительство и ремонт»",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "По вашему запросу результатов не найдено!",
                        "Муниципальное автономное учреждение «Капитальное строительство и ремонт»",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                _itemsFound = 0;
            }
            else
            {
                MessageBox.Show(
                    "Для поиска, введите запрос в текстовом поле!",
                    "Муниципальное автономное учреждение «Капитальное строительство и ремонт»",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void ClearAll(DataGridView dataGridView, BindingSource bindingSource, TextBox searchTextBox)
        {
            SetCellsColor(dataGridView, searchTextBox, Color.White, Color.Black, false);
            bindingSource.Filter = "";
            searchTextBox.Text = "";

            _itemsFound = 0;
        }

        private void SetCellsColor(DataGridView dataGridView, TextBox searchTextBox, Color backColor, Color foreColor, bool isSearching)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (isSearching)
                    {
                        if (dataGridView[i, j].Value.ToString().IndexOf(searchTextBox.Text) != -1)
                        {
                            dataGridView[i, j].Style.BackColor = backColor;
                            dataGridView[i, j].Style.ForeColor = foreColor; 

                            _itemsFound++;
                        }
                    }
                    else
                    {
                        dataGridView[i, j].Style.BackColor = backColor;
                        dataGridView[i, j].Style.ForeColor = foreColor;
                    }
                }
            }
        }
    }
}
