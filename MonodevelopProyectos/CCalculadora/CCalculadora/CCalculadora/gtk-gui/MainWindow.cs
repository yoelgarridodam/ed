
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Label label1;

	private global::Gtk.Entry Pantalla;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Button BVaciar;

	private global::Gtk.Button BC;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Button BSiete;

	private global::Gtk.Button BOcho;

	private global::Gtk.Button BNueve;

	private global::Gtk.Button BDivision;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Button BCuatro;

	private global::Gtk.Button BCinco;

	private global::Gtk.Button BSeis;

	private global::Gtk.Button BMultiplicacion;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button BUno;

	private global::Gtk.Button BDos;

	private global::Gtk.Button BTres;

	private global::Gtk.Button BResta;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Button BComa;

	private global::Gtk.Button BCero;

	private global::Gtk.Button BIgual;

	private global::Gtk.Button BSuma;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("MI CALCULADORA");
		this.vbox1.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.Pantalla = new global::Gtk.Entry();
		this.Pantalla.CanFocus = true;
		this.Pantalla.Name = "Pantalla";
		this.Pantalla.IsEditable = true;
		this.Pantalla.InvisibleChar = '•';
		this.vbox1.Add(this.Pantalla);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.Pantalla]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.BVaciar = new global::Gtk.Button();
		this.BVaciar.WidthRequest = 120;
		this.BVaciar.CanFocus = true;
		this.BVaciar.Name = "BVaciar";
		this.BVaciar.UseUnderline = true;
		this.BVaciar.Label = global::Mono.Unix.Catalog.GetString("Vaciar");
		this.hbox5.Add(this.BVaciar);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.BVaciar]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.BC = new global::Gtk.Button();
		this.BC.WidthRequest = 35;
		this.BC.HeightRequest = 35;
		this.BC.CanFocus = true;
		this.BC.Name = "BC";
		this.BC.UseUnderline = true;
		this.BC.Label = global::Mono.Unix.Catalog.GetString("C");
		this.hbox5.Add(this.BC);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.BC]));
		w4.Position = 1;
		w4.Fill = false;
		this.vbox1.Add(this.hbox5);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.BSiete = new global::Gtk.Button();
		this.BSiete.WidthRequest = 35;
		this.BSiete.HeightRequest = 35;
		this.BSiete.CanFocus = true;
		this.BSiete.Name = "BSiete";
		this.BSiete.UseUnderline = true;
		this.BSiete.Label = global::Mono.Unix.Catalog.GetString("7");
		this.hbox1.Add(this.BSiete);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.BSiete]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.BOcho = new global::Gtk.Button();
		this.BOcho.WidthRequest = 35;
		this.BOcho.HeightRequest = 35;
		this.BOcho.CanFocus = true;
		this.BOcho.Name = "BOcho";
		this.BOcho.UseUnderline = true;
		this.BOcho.Label = global::Mono.Unix.Catalog.GetString("8");
		this.hbox1.Add(this.BOcho);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.BOcho]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.BNueve = new global::Gtk.Button();
		this.BNueve.WidthRequest = 35;
		this.BNueve.HeightRequest = 35;
		this.BNueve.CanFocus = true;
		this.BNueve.Name = "BNueve";
		this.BNueve.UseUnderline = true;
		this.BNueve.Label = global::Mono.Unix.Catalog.GetString("9");
		this.hbox1.Add(this.BNueve);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.BNueve]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.BDivision = new global::Gtk.Button();
		this.BDivision.WidthRequest = 35;
		this.BDivision.HeightRequest = 35;
		this.BDivision.CanFocus = true;
		this.BDivision.Name = "BDivision";
		this.BDivision.UseUnderline = true;
		this.BDivision.Label = global::Mono.Unix.Catalog.GetString("/");
		this.hbox1.Add(this.BDivision);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.BDivision]));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.BCuatro = new global::Gtk.Button();
		this.BCuatro.WidthRequest = 35;
		this.BCuatro.HeightRequest = 35;
		this.BCuatro.CanFocus = true;
		this.BCuatro.Name = "BCuatro";
		this.BCuatro.UseUnderline = true;
		this.BCuatro.Label = global::Mono.Unix.Catalog.GetString("4");
		this.hbox2.Add(this.BCuatro);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.BCuatro]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.BCinco = new global::Gtk.Button();
		this.BCinco.WidthRequest = 35;
		this.BCinco.HeightRequest = 35;
		this.BCinco.CanFocus = true;
		this.BCinco.Name = "BCinco";
		this.BCinco.UseUnderline = true;
		this.BCinco.Label = global::Mono.Unix.Catalog.GetString("5");
		this.hbox2.Add(this.BCinco);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.BCinco]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.BSeis = new global::Gtk.Button();
		this.BSeis.WidthRequest = 35;
		this.BSeis.HeightRequest = 35;
		this.BSeis.CanFocus = true;
		this.BSeis.Name = "BSeis";
		this.BSeis.UseUnderline = true;
		this.BSeis.Label = global::Mono.Unix.Catalog.GetString("6");
		this.hbox2.Add(this.BSeis);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.BSeis]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.BMultiplicacion = new global::Gtk.Button();
		this.BMultiplicacion.WidthRequest = 35;
		this.BMultiplicacion.HeightRequest = 35;
		this.BMultiplicacion.CanFocus = true;
		this.BMultiplicacion.Name = "BMultiplicacion";
		this.BMultiplicacion.UseUnderline = true;
		this.BMultiplicacion.Label = global::Mono.Unix.Catalog.GetString("*");
		this.hbox2.Add(this.BMultiplicacion);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.BMultiplicacion]));
		w14.Position = 3;
		w14.Expand = false;
		w14.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w15.Position = 4;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.BUno = new global::Gtk.Button();
		this.BUno.WidthRequest = 35;
		this.BUno.HeightRequest = 35;
		this.BUno.CanFocus = true;
		this.BUno.Name = "BUno";
		this.BUno.UseUnderline = true;
		this.BUno.Label = global::Mono.Unix.Catalog.GetString("1");
		this.hbox3.Add(this.BUno);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BUno]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.BDos = new global::Gtk.Button();
		this.BDos.WidthRequest = 35;
		this.BDos.HeightRequest = 35;
		this.BDos.CanFocus = true;
		this.BDos.Name = "BDos";
		this.BDos.UseUnderline = true;
		this.BDos.Label = global::Mono.Unix.Catalog.GetString("2");
		this.hbox3.Add(this.BDos);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BDos]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.BTres = new global::Gtk.Button();
		this.BTres.WidthRequest = 35;
		this.BTres.HeightRequest = 35;
		this.BTres.CanFocus = true;
		this.BTres.Name = "BTres";
		this.BTres.UseUnderline = true;
		this.BTres.Label = global::Mono.Unix.Catalog.GetString("3");
		this.hbox3.Add(this.BTres);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BTres]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.BResta = new global::Gtk.Button();
		this.BResta.WidthRequest = 35;
		this.BResta.HeightRequest = 35;
		this.BResta.CanFocus = true;
		this.BResta.Name = "BResta";
		this.BResta.UseUnderline = true;
		this.BResta.Label = global::Mono.Unix.Catalog.GetString("-");
		this.hbox3.Add(this.BResta);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BResta]));
		w19.PackType = ((global::Gtk.PackType)(1));
		w19.Position = 3;
		w19.Fill = false;
		this.vbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w20.Position = 5;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.BComa = new global::Gtk.Button();
		this.BComa.WidthRequest = 35;
		this.BComa.HeightRequest = 35;
		this.BComa.CanFocus = true;
		this.BComa.Name = "BComa";
		this.BComa.UseUnderline = true;
		this.BComa.Label = global::Mono.Unix.Catalog.GetString(".");
		this.hbox4.Add(this.BComa);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.BComa]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.BCero = new global::Gtk.Button();
		this.BCero.WidthRequest = 35;
		this.BCero.HeightRequest = 35;
		this.BCero.CanFocus = true;
		this.BCero.Name = "BCero";
		this.BCero.UseUnderline = true;
		this.BCero.Label = global::Mono.Unix.Catalog.GetString("0");
		this.hbox4.Add(this.BCero);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.BCero]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.BIgual = new global::Gtk.Button();
		this.BIgual.WidthRequest = 35;
		this.BIgual.HeightRequest = 35;
		this.BIgual.CanFocus = true;
		this.BIgual.Name = "BIgual";
		this.BIgual.UseUnderline = true;
		this.BIgual.Label = global::Mono.Unix.Catalog.GetString("=");
		this.hbox4.Add(this.BIgual);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.BIgual]));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.BSuma = new global::Gtk.Button();
		this.BSuma.WidthRequest = 35;
		this.BSuma.HeightRequest = 35;
		this.BSuma.CanFocus = true;
		this.BSuma.Name = "BSuma";
		this.BSuma.UseUnderline = true;
		this.BSuma.Label = global::Mono.Unix.Catalog.GetString("+");
		this.hbox4.Add(this.BSuma);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.BSuma]));
		w24.Position = 3;
		w24.Expand = false;
		w24.Fill = false;
		this.vbox1.Add(this.hbox4);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w25.Position = 6;
		w25.Expand = false;
		w25.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 161;
		this.DefaultHeight = 275;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.BVaciar.Clicked += new global::System.EventHandler(this.OnBVaciarClicked);
		this.BC.Clicked += new global::System.EventHandler(this.OnBCClicked);
		this.BSiete.Clicked += new global::System.EventHandler(this.OnBSieteClicked);
		this.BOcho.Clicked += new global::System.EventHandler(this.OnBOchoClicked);
		this.BNueve.Clicked += new global::System.EventHandler(this.OnBNueveClicked);
		this.BCuatro.Clicked += new global::System.EventHandler(this.OnBCuatroClicked);
		this.BCinco.Clicked += new global::System.EventHandler(this.OnBCincoClicked);
		this.BSeis.Clicked += new global::System.EventHandler(this.OnBSeisClicked);
		this.BUno.Clicked += new global::System.EventHandler(this.OnBUnoClicked);
		this.BDos.Clicked += new global::System.EventHandler(this.OnBDosClicked);
		this.BTres.Clicked += new global::System.EventHandler(this.OnBTresClicked);
		this.BComa.Clicked += new global::System.EventHandler(this.OnBComaClicked);
		this.BCero.Clicked += new global::System.EventHandler(this.OnBCeroClicked);
		this.BSuma.Clicked += new global::System.EventHandler(this.OnBSumaClicked);
	}
}
