using System;
using CBingo;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Bombo bombo = new Bombo();
    Panel panel;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        panel = new Panel(vBox1);
        /*BJugar.Clicked += delegate
        {
            bombo.sacarBola();
        };*/
    }


    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBJugarClicked(object sender, EventArgs e)
    {
        int numero = bombo.sacarBola();
        panel.Marcar(numero);
    }
}
