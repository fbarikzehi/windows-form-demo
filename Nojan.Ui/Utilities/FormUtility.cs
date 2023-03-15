namespace Nojan.Ui.Utilities;
public static class FormUtility
{
    public static void CloseIfExistForm(string formName)
    {
        Form form = Application.OpenForms[formName];
        form?.Close();
    }
}
