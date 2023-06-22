using Main_System_Stroitelstvo_I_Remont.stroidtelstvo_i_remontDataSetTableAdapters;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    internal class Registration
    {
        AppNavigation appNavigation = new AppNavigation();

        public void BeginRegistration(BindingSource currentBindingSource)
        {
            currentBindingSource.AddNew();
        }

        public void SaveNewRegistration(Form currentForm, BindingSource bindingSource, 
            TableAdapterManager tableAdapterManager, stroidtelstvo_i_remontDataSet stroidtelstvo_I_RemontDataSet)
        {
            currentForm.Validate();
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(stroidtelstvo_I_RemontDataSet);

            ShowQuestionMessage(currentForm, bindingSource);
        }

        public void ShowWarningMessage()
        {
            MessageBox.Show(
                "Перед сохранением, все данные должны быть введены!",
                "Муниципальное автономное учреждение «Капитальное строительство и ремонт»",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void ShowQuestionMessage(Form currentForm, BindingSource bindingSource)
        {
            var messageText = MessageBox.Show(
                "Хотите ли вы добавить ещё один объект?",
                "Муниципальное автономное учреждение «Капитальное строительство и ремонт»",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (messageText == DialogResult.Yes)
            {
                BeginRegistration(bindingSource);
            }
            else
            {
                appNavigation.QuitToMainMenu(currentForm);
            }
        }
    }
}
