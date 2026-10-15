namespace InTenYears;

public partial class InTenYears1 : ContentPage
{
	public InTenYears1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		int age= 10 +int.Parse(entryAge.Text);
        xyz.Text="In ten years from now "+ entryName.Text+ " will be "+ age + " years old";
    }
}