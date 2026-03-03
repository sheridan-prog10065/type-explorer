namespace TypeExplorer;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTypeSelected(object sender, SelectionChangedEventArgs e)
	{
        string typeName = (string)_lstTypes.SelectedItem;
        switch (typeName)
        {
            case "int":
                ShowIntValue();
                break;
        }
    }

    private void ShowIntValue()
    {
        //declare an int local variable
        int intVar;

        //initialize the variable to a sample value
        intVar = -125;

        //display the sample value
        _txtSampleValue.Text = intVar.ToString();

        //display the size of the variable in bytes
        _txtSize.Text = sizeof(int).ToString();
    }

    private void OnClearTypeInfo(object sender, EventArgs e)
    {
        _txtSampleValue.Text = "";
        _txtSize.Text = "";
        _lstTypes.SelectedItem = null;
    }
}