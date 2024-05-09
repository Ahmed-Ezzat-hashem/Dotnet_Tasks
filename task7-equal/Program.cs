using System;
using System.Windows.Forms;

interface ICalculator
{
    double Add(double x, double y);
    double Subtract(double x, double y);
    double Multiply(double x, double y);
    double Divide(double x, double y);
}

class BasicCalculator : ICalculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Subtract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public double Divide(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return x / y;
    }
}

class CalculatorForm : Form
{
    private ICalculator calculator;

    private TextBox xTextBox;
    private TextBox yTextBox;
    private Button addButton;
    private Button subtractButton;
    private Button multiplyButton;
    private Button divideButton;
    private Label resultLabel;

    public CalculatorForm(ICalculator calculator)
    {
        this.calculator = calculator;

        this.Text = "Calculator";
        this.ClientSize = new System.Drawing.Size(200, 200);

        xTextBox = new TextBox();
        xTextBox.Location = new System.Drawing.Point(10, 10);
        this.Controls.Add(xTextBox);

        yTextBox = new TextBox();
        yTextBox.Location = new System.Drawing.Point(10, 40);
        this.Controls.Add(yTextBox);

        addButton = new Button();
        addButton.Text = "+";
        addButton.Location = new System.Drawing.Point(10, 70);
        addButton.Click += new EventHandler(AddButton_Click);
        this.Controls.Add(addButton);

        subtractButton = new Button();
        subtractButton.Text = "-";
        subtractButton.Location = new System.Drawing.Point(60, 70);
        subtractButton.Click += new EventHandler(SubtractButton_Click);
        this.Controls.Add(subtractButton);

        multiplyButton = new Button();
        multiplyButton.Text = "*";
        multiplyButton.Location = new System.Drawing.Point(110, 70);
        multiplyButton.Click += new EventHandler(MultiplyButton_Click);
        this.Controls.Add(multiplyButton);

        divideButton = new Button();
        divideButton.Text = "/";
        divideButton.Location = new System.Drawing.Point(160, 70);
        divideButton.Click += new EventHandler(DivideButton_Click);
        this.Controls.Add(divideButton);

        resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(10, 100);
        this.Controls.Add(resultLabel);
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        double x, y;
        if (double.TryParse(xTextBox.Text, out x) && double.TryParse(yTextBox.Text, out y))
        {
            double result = calculator.Add(x, y);
            resultLabel.Text = $"Result: {result}";
        }
        else
        {
            resultLabel.Text = "Invalid input.";
        }
    }

    private void SubtractButton_Click(object sender, EventArgs e)
    {
        double x, y;
        if (double.TryParse(xTextBox.Text, out x) && double.TryParse(yTextBox.Text, out y))
        {
            double result = calculator.Subtract(x, y);
            resultLabel.Text = $"Result: {result}";
        }
        else
        {
            resultLabel.Text = "Invalid input.";
        }
    }

    private void MultiplyButton_Click(object sender, EventArgs e)
    {
        double x, y;
        if (double.TryParse(xTextBox.Text, out x) && double.TryParse(yTextBox.Text, out y))
        {
            double result = calculator.Multiply(x, y);
            resultLabel.Text = $"Result: {result}";
        }
        else
        {
            resultLabel.Text = "Invalid input.";
        }
    }

    private void DivideButton_Click(object sender, EventArgs e)
    {
        double x, y;
        if (double.TryParse(xTextBox.Text, out x) && double.TryParse(yTextBox.Text, out y))
        {
            try
            {
                double result = calculator.Divide(x, y);
                resultLabel.Text = $"Result: {result}";
            }
            catch (DivideByZeroException ex)
            {
                resultLabel.Text = ex.Message;
            }
        }
        else
        {
            resultLabel.Text = "Invalid input.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new BasicCalculator();
        Application.Run(new CalculatorForm(calculator));
    }
}