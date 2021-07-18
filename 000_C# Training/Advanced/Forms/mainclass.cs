using System;
using System.Windows.Forms;

public class MainClass
{
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}

public class MainForm : Form
{
    public Button button;
    //public delegate void onEvent(object sender, EventArgs e);

    public MainForm()
    {
        button = new Button();
        button.Size = new System.Drawing.Size(50, 50);
        button.Location = new System.Drawing.Point (0, 20);
        button.Text = "Button";
        //button.Click += new onEvent(OnButtonClick);
        button.Click += delegate(object sender, EventArgs e) 
        {
            OnButtonClick(sender, e);
        };
        this.Controls.Add(button);
    }

    public void OnButtonClick(object sender, EventArgs e)
    {
        MessageBox.Show("Click");
    }
}