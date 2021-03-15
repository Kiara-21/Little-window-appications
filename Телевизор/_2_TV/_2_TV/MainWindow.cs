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

    protected void killapp(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void setut(object sender, EventArgs e)
    {
        if (radiobutton3.Active == true)
        {
            image1.Visible = true;
            image2.Visible = false;
            image3.Visible = false;
            image4.Visible = false;
        }
    }

    protected void setinter(object sender, EventArgs e)
    {
        if (radiobutton4.Active == true)
        {
            image1.Visible = false;
            image2.Visible = true;
            image3.Visible = false;
            image4.Visible = false;

        }
    }

    protected void setplus(object sender, EventArgs e)
    {
        if (radiobutton5.Active == true)
        {
            image1.Visible = false;
            image2.Visible = false;
            image3.Visible = true;
            image4.Visible = false;

        }
    }

    protected void setstb(object sender, EventArgs e)
    {
        if (radiobutton6.Active == true)
        {
            image1.Visible = false;
            image2.Visible = false;
            image3.Visible = false;
            image4.Visible = true;

        }
    }
}
