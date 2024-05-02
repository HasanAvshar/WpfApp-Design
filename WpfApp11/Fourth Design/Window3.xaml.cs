using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp11.Fourth_Design;

public partial class Window3 : Window
{
    public Window3()
    {
        InitializeComponent();
    }
    private void TextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        if (textBox.Text == "Type the order home"
            || textBox.Text == "How many do you want?"
            || textBox.Text == "Order opening day"
            || textBox.Text == "Day"
            || textBox.Text == "Month"
            || textBox.Text == "Year")
        {
            textBox.Text = "";
        }
    }

    private void TextBox_LostFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            textBox.Text = "Enter your data";
        }
    }

    private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        if (textBox.Text == "Enter your username" || textBox.Text == "Enter your password")
        {
            textBox.Text = "";
        }
    }
}
