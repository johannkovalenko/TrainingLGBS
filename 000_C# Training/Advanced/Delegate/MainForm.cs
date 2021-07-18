using System.Windows.Forms;
using System;

public class MainForm : Form
{
    Button myButton;
    delegate void MyDelegate(object sender, EventArgs e);

    public MainForm()
    {
        myButton = new Button();
        //MyDelegate myDelegate = new MyDelegate(ButtonClick);

        myButton.Click += delegate(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        };
        //myButton.Click += new EventHandler(ButtonClick);
        Controls.Add(myButton);
    }

    

    public void ButtonClick(object sender, EventArgs e)
    {
        MessageBox.Show("in");
    }
}