
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label label1;

	private global::Gtk.CheckButton checkbutton1;

	private global::Gtk.CheckButton checkbutton2;

	private global::Gtk.RadioButton radiobutton1;

	private global::Gtk.RadioButton radiobutton2;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entry3;

	private global::Gtk.Button button1;

	private global::Gtk.Label label2;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entry1;

	private global::Gtk.Entry entry2;

	private global::Gtk.RadioButton radiobutton3;

	private global::Gtk.Label label5;

	private global::Gtk.Button button2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Размер окна");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w1.X = 20;
		w1.Y = 19;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton1 = new global::Gtk.CheckButton();
		this.checkbutton1.CanFocus = true;
		this.checkbutton1.Name = "checkbutton1";
		this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("Доставка (100грн)");
		this.checkbutton1.DrawIndicator = true;
		this.checkbutton1.UseUnderline = true;
		this.fixed1.Add(this.checkbutton1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton1]));
		w2.X = 50;
		w2.Y = 188;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton2 = new global::Gtk.CheckButton();
		this.checkbutton2.CanFocus = true;
		this.checkbutton2.Name = "checkbutton2";
		this.checkbutton2.Label = global::Mono.Unix.Catalog.GetString("Подоконник (200грн)");
		this.checkbutton2.DrawIndicator = true;
		this.checkbutton2.UseUnderline = true;
		this.fixed1.Add(this.checkbutton2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton2]));
		w3.X = 50;
		w3.Y = 229;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Однокамерный (50грн)"));
		this.radiobutton1.CanFocus = true;
		this.radiobutton1.Name = "radiobutton1";
		this.radiobutton1.DrawIndicator = true;
		this.radiobutton1.UseUnderline = true;
		this.radiobutton1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.fixed1.Add(this.radiobutton1);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton1]));
		w4.X = 332;
		w4.Y = 56;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Двухкамерный (100грн)"));
		this.radiobutton2.CanFocus = true;
		this.radiobutton2.Name = "radiobutton2";
		this.radiobutton2.DrawIndicator = true;
		this.radiobutton2.UseUnderline = true;
		this.radiobutton2.Group = this.radiobutton1.Group;
		this.fixed1.Add(this.radiobutton2);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton2]));
		w5.X = 331;
		w5.Y = 86;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Стеклопакет");
		this.fixed1.Add(this.label4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
		w6.X = 373;
		w6.Y = 24;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.fixed1.Add(this.entry3);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry3]));
		w7.X = 355;
		w7.Y = 195;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Расчет");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w8.X = 177;
		w8.Y = 298;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Ширина (см)");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w9.X = 9;
		w9.Y = 64;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Высота (см)");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w10.X = 9;
		w10.Y = 111;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.fixed1.Add(this.entry1);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
		w11.X = 105;
		w11.Y = 56;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.fixed1.Add(this.entry2);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry2]));
		w12.X = 105;
		w12.Y = 103;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton3 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Энергосберегающий (150грн)"));
		this.radiobutton3.CanFocus = true;
		this.radiobutton3.Name = "radiobutton3";
		this.radiobutton3.DrawIndicator = true;
		this.radiobutton3.UseUnderline = true;
		this.radiobutton3.Group = this.radiobutton1.Group;
		this.fixed1.Add(this.radiobutton3);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton3]));
		w13.X = 331;
		w13.Y = 116;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Стоимость");
		this.fixed1.Add(this.label5);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label5]));
		w14.X = 267;
		w14.Y = 202;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Выход");
		this.fixed1.Add(this.button2);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
		w15.X = 306;
		w15.Y = 296;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 571;
		this.DefaultHeight = 364;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.calculate);
		this.button2.Clicked += new global::System.EventHandler(this.killapp);
	}
}
