using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp11.Third_Design;

public partial class Window2 : Window
{
    public Window2()
    {
        InitializeComponent();
    }
    private void TextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        if (textBox.Text == "What is the name of the client?"
            || textBox.Text == "What is the surname of the client?"
            || textBox.Text == "What is the phone number of the client?"
            || textBox.Text == "Which company does the person below to?"
            || textBox.Text == "Where did he/she found me?"
            || textBox.Text == "Day"
            || textBox.Text == "Month"
            || textBox.Text == "Year"
            || textBox.Text == "While how  do I know him/her")
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