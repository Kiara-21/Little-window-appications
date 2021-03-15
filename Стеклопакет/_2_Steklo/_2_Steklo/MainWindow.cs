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
        double sum = 0;
        double squarewindow = (Convert.ToDouble(entry1.Text) * Convert.ToDouble(entry2.Text));
        if (radiobutton1.Active == true)
        {
            sum = squarewindow * 50;
        }
           else 
            {
                if (radiobutton2.Active == true)
                {
                    sum = squarewindow * 100;
                }
                else
                {
                    sum = squarewindow * 150;
                }

            }
        

        if (checkbutton1.Active == true)
        {
            sum = sum + 100;
        }

        if (checkbutton2.Active == true)
        {
            sum = sum + 200;
        }

        entry3.Text = Convert.ToString(sum);
    }

    protected void killapp(object sender, EventArgs e)
    {
        Application.Quit();
    }
}
