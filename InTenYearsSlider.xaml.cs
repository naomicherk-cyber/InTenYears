
namespace InTenYears;

public partial class InTenYearsSlider : ContentPage
{
    private int age = 0;
	public InTenYearsSlider()
	{
		InitializeComponent();
        entryAge.Text = "0";

    }

    private void sliderAge_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age = (int)sliderAge.Value;
        entryAge.Text = age.ToString();
    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
    {
        xyz.Text = "In ten years from now " + entryName.Text + " will be " + (age + 10) + " years old";
    }

}