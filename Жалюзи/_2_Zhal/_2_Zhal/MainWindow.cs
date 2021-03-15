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
        if (radiobutton1.Active == true)
        {
            entry3.Text = Convert.ToString((Convert.ToDouble(entry1.Text) * Convert.ToDouble(entry2.Text))*100);
        }
        else
        {
            entry3.Text = Convert.ToString((Convert.ToDouble(entry1.Text) * Convert.ToDouble(entry2.Text)) * 50);
        }
    }

    protected void killapp(object sender, EventArgs e)
    {
        Application.Quit();
    }

}
