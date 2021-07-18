using System.Windows.Forms;
using System.Drawing;
using System;

class MyForm : Form 
{
    Button button = new Button();

    public MyForm() 
    {
        FrameSettings();
        ButtonSettings();
        EventHandler();

        base.Controls.Add(button);
    }

    private void FrameSettings() 
    {
        base.Size = new Size(500, 500);
    }

    private void ButtonSettings() 
    {
        button.Text = "Click me";
        button.BackColor = Color.FromArgb(252, 204, 116);
        button.ForeColor = Color.Red;
        button.Size = new Size(150, 50);
        button.Location = new Point(20, 20);
    }

    private void EventHandler() 
    {
        button.Click += delegate(object sender, EventArgs e)
        {
            new MyFunctionality().Run();
        };
    }
}
