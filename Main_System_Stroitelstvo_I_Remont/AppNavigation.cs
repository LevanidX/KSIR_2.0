using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    internal class AppNavigation
    {
        public void QuitToMainMenu(Form currentWindow)
        {
            MainMenu mainMenu = new MainMenu();
            currentWindow.Close();
            mainMenu.Show();
        }

        public void OpenNewWindow(MainMenu mainMenu, Form chosenWindow)
        {
            mainMenu.Hide();
            chosenWindow.Show();
        }
    }
}
