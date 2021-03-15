using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        combobox1.AppendText("92");
        combobox1.AppendText("95");
        combobox1.AppendText("98");
        combobox1.AppendText("ДТ");

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void calculate(object sender, EventArgs e)
    {
        entry1.Text = Convert.ToString(Convert.ToDouble(entry4.Text)*Convert.ToDouble(entry2.Text));
    }

    protected void killapp(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void combdrop(object sender, EventArgs e)
    {
        if (combobox1.ActiveText == "92")
        {
            entry2.Text = "20";
        }
        else
        {
            if (combobox1.ActiveText == "95")
            {
                entry2.Text = "30";
            }
            else 
            {
                if (combobox1.ActiveText == "98")
                {
                    entry2.Text = "40";
                }
                else
                {
                    if (combobox1.ActiveText == "ДТ")
                    {
                        entry2.Text = "50";
                    }
                }
            }
        }
    }
}

