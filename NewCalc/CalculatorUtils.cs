using System.Windows.Forms;

public class CalculatorUtils
{
    private readonly Form calculatorForm;

    public CalculatorUtils(Form form)
    {
        calculatorForm = form;
    }

    public void DisableButtons()
    {
        foreach (Control control in calculatorForm.Controls)
        {
            if (control is Button && control.Name != "btnclear")
            {
                control.Enabled = false;
            }
        }
    }

    public void EnableButtons()
    {
        foreach (Control control in calculatorForm.Controls)
        {
            if (control is Button)
            {
                control.Enabled = true;
            }
        }
    }
}
