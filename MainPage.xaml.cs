namespace XICodeEditor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    public string Get_HoverContent()
    {
        try
        {

            return "text";
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public string Get_ContractContent(int ID, string boName)
    {
        try
        {

            return "ContractConten";
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
