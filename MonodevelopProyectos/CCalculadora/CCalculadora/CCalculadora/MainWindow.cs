﻿using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    int contador;
    int num1 = 0;
    int num2 = 0;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBCeroClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "0");
    }

    protected void OnBUnoClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "1");
    }

    protected void OnBDosClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "2");
    }

    protected void OnBTresClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "3");
    }

    protected void OnBCuatroClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "4");
    }

    protected void OnBCincoClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "5");
    }

    protected void OnBSeisClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "6");
    }
    protected void OnBSieteClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "7");
    }

    protected void OnBOchoClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "8");
    }

    protected void OnBNueveClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "9");
    }

    protected void OnBComaClicked(object sender, EventArgs e)
    {
        if (contador == 0)
        {
            String display = Pantalla.Text.ToString();
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            Pantalla.InsertText(display + ",");
            contador++;
        }
    }

    protected void OnBVaciarClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
    }

    protected void OnBCClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(Pantalla.Text.Length - 1, Pantalla.Text.Length);

        String display = Pantalla.Text.ToString();
        if (!display.Contains(","))
        {
            contador = 0;
        }
    }

    protected void OnBSumaClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToInt32(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
    }

    protected void OnBIgualClicked(object sender, EventArgs e)
    {
        num2 = Convert.ToInt32(Pantalla.Text);
        int num3 = suma(num1, num2);

    }

}