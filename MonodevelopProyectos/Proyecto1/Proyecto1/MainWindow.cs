﻿using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    private Random random = new Random();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnSalirClicked(object sender, EventArgs e)
    {
        this.Destroy();
    }

    protected void OnSaludarClicked(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, " Hola " + text.text);
        md.Run();
        md.Destroy();
     }

    protected void OnRandomClicked(object sender, EventArgs e)
    {
        int indexAleatorio = random.Next(1, 10);
        MessageDialog a = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.Close, "Número aleatorio: " + indexAleatorio);
        a.Run();
        a.Destroy();
    }
}
