using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    int contador;
    float num1;
    float num2;
    String opcion;
    float resultado;
    float contadorigual;
    Calculadora operacion = new Calculadora();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        BVaciar.ModifyBg(StateType.Normal, new Gdk.Color(100, 240, 240));
        BSuma.ModifyBg(StateType.Normal, new Gdk.Color(100, 240, 240));
        BResta.ModifyBg(StateType.Normal, new Gdk.Color(100, 240, 240));
        BMultiplicacion.ModifyBg(StateType.Normal, new Gdk.Color(100, 240, 240));
        BDivision.ModifyBg(StateType.Normal, new Gdk.Color(100, 240, 240));
        BIgual.ModifyBg(StateType.Normal, new Gdk.Color(100, 240, 240));

        ModifyBg(StateType.Normal, new Gdk.Color(69, 69, 69));
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
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
        num1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        opcion = "+";
    }

    protected void OnBRestaClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        opcion = "-";
    }

    protected void OnBMultiplicacionClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        opcion = "*";
    }

    protected void OnBDivisionClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        opcion = "/";
    }

    protected void OnBIgualClicked(object sender, EventArgs e)
    {
        num2 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);


        switch (opcion)
        {
            case ("+"):
                resultado = operacion.suma(num1, num2);
                this.Pantalla.Text = (Convert.ToString(resultado));
                contadorigual++;
                break;
            case ("-"):
                resultado = operacion.resta(num1, num2);
                this.Pantalla.Text = (Convert.ToString(resultado));
                contadorigual++;
                break;
            case ("*"):
                resultado = operacion.multiplicacion(num1, num2);
                this.Pantalla.Text = (Convert.ToString(resultado));
                contadorigual++;
                break;
            case ("/"):
                resultado = operacion.division(num1, num2);
                this.Pantalla.Text = (Convert.ToString(resultado));
                contadorigual++;
                break;
        }
    }

    //NUMEROS
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
}











