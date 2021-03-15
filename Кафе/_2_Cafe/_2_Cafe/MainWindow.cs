using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void calculate(object sender, EventArgs e)
    {
        int sum = 0;
        if (checkbutton1.Active == true)
        {
            sum = sum + 10;
        }
        if (checkbutton2.Active == true)
        {
            sum = sum + 20;
        }
        if (checkbutton3.Active == true)
        {
            sum = sum + 7;
        }
        if (checkbutton4.Active == true)
        {
            sum = sum + 5;
        }
        entry1.Text = Convert.ToString(sum);
    }

    protected void killapp(object sender, EventArgs e)
    {
        Application.Quit();
    }
}
