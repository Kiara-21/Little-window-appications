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
        entry7.Text = ((Convert.ToDouble(entry5.Text) - Convert.ToDouble(entry4.Text))*Convert.ToDouble(entry6.Text)).ToString();
    }

    protected void killapp(object sender, EventArgs e)
    {
        Application.Quit();    
    }
}
