namespace Fortnite_Design
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.slidemenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();

            this.skinTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Fortnite_Design.DatabaseDataSet();
            Form1 form1 = this;
            form1.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
           // this.skinTableTableAdapter = new Fortnite_Design.DatabaseDataSetTableAdapters.SkinTableTableAdapter();
          //  this.contactPage1 = new Fortnite_Design.ContactPage();

            this.button1 = new System.Windows.Forms.Button();
            this.fortniteSkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fortniteDataSet = new Fortnite_Design.FortniteDataSet();
            this.SkinNaam = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.fortnite_SkinTableAdapter = new Fortnite_Design.FortniteDataSetTableAdapters.Fortnite_SkinTableAdapter();
            this.fortniteDataSet1 = new Fortnite_Design.FortniteDataSet1();
            this.fortniteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fortniteTableAdapter = new Fortnite_Design.FortniteDataSet1TableAdapters.FortniteTableAdapter();
            this.button4 = new System.Windows.Forms.Button();

            this.slidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNmenu)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.skinTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.fortniteSkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // slidemenu
            // 
            this.slidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.slidemenu.Controls.Add(this.bunifuFlatButton1);
            this.slidemenu.Controls.Add(this.label1);
            this.slidemenu.Controls.Add(this.bunifuFlatButton3);
            this.slidemenu.Controls.Add(this.bunifuFlatButton2);
            this.slidemenu.Controls.Add(this.BTNmenu);
            this.PanelAnimator.SetDecoration(this.slidemenu, BunifuAnimatorNS.DecorationType.None);
            this.slidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidemenu.Location = new System.Drawing.Point(0, 59);
            this.slidemenu.Margin = new System.Windows.Forms.Padding(2);
            this.slidemenu.MinimumSize = new System.Drawing.Size(38, 501);
            this.slidemenu.Name = "slidemenu";
            this.slidemenu.Size = new System.Drawing.Size(214, 502);
            this.slidemenu.TabIndex = 0;
            this.slidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton3.AutoSize = true;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "            Collectie";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 35D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1, 166);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(278, 50);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "            Collectie";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton2.AutoSize = true;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "            Contact";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1, 229);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(313, 50);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "            Contact";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton1.AutoSize = true;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "            Skins";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 35D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 102);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(314, 50);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "            Skins";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // BTNmenu
            // 
            this.BTNmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.BTNmenu, BunifuAnimatorNS.DecorationType.None);
            this.BTNmenu.Image = ((System.Drawing.Image)(resources.GetObject("BTNmenu.Image")));
            this.BTNmenu.ImageActive = null;
            this.BTNmenu.Location = new System.Drawing.Point(9, 47);
            this.BTNmenu.Margin = new System.Windows.Forms.Padding(2);
            this.BTNmenu.Name = "BTNmenu";

            this.BTNmenu.Size = new System.Drawing.Size(28, 41);

            this.BTNmenu.Size = new System.Drawing.Size(37, 41);

            this.BTNmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNmenu.TabIndex = 0;
            this.BTNmenu.TabStop = false;
            this.BTNmenu.Zoom = 10;
            this.BTNmenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 

            // pictureBox1
            // 
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Fortnite_Design.Properties.Resources.Wit;
            this.pictureBox1.Location = new System.Drawing.Point(2, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 

            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.label2);
            this.Header.Controls.Add(this.bunifuImageButton2);
            this.PanelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1084, 59);
            this.Header.TabIndex = 1;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1002, 7);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Fortnite_Design.Properties.Resources.Wit;
            this.pictureBox1.Location = new System.Drawing.Point(2, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fortnite Skins";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1043, 9);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation1;
            this.PanelAnimator.Interval = 0;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Elite agent",
            "Scarlet Defender"});
            this.bunifuCustomTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bunifuCustomTextbox1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomTextbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuCustomTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(932, 64);
            this.bunifuCustomTextbox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(143, 23);
            this.bunifuCustomTextbox1.TabIndex = 2;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 

            // skinTableBindingSource
            // 
            this.skinTableBindingSource.DataMember = "SkinTable";
            this.skinTableBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
          //  this.databaseDataSet.DataSetName = "DatabaseDataSet";
           // this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // button1
            // 
            this.PanelAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(525, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "GetData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fortniteSkinBindingSource
            // 
            this.fortniteSkinBindingSource.DataMember = "Fortnite_Skin";
            this.fortniteSkinBindingSource.DataSource = this.fortniteDataSet;
            // 
            // fortniteDataSet
            // 
            this.fortniteDataSet.DataSetName = "FortniteDataSet";
            this.fortniteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SkinNaam
            // 
            this.SkinNaam.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.SkinNaam, BunifuAnimatorNS.DecorationType.None);
            this.SkinNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinNaam.Location = new System.Drawing.Point(219, 61);
            this.SkinNaam.Name = "SkinNaam";
            this.SkinNaam.Size = new System.Drawing.Size(214, 40);
            this.SkinNaam.TabIndex = 5;
            this.SkinNaam.Text = "\r\nSkin Prijzen zijn in vbucks";
            this.SkinNaam.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // button2
            // 
            this.PanelAnimator.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(255, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 81);
            this.button2.TabIndex = 7;
            this.button2.Text = "Select image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(719, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // button3
            // 
            this.PanelAnimator.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Location = new System.Drawing.Point(242, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 110);
            this.button3.TabIndex = 8;
            this.button3.Text = "Form switch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 

            // skinTableTableAdapter
            // 
          //  this.skinTableTableAdapter.ClearBeforeFill = true;
            // 
            // contactPage1
            // 
         //   this.PanelAnimator.SetDecoration(this.contactPage1, BunifuAnimatorNS.DecorationType.None);
         //   this.contactPage1.Location = new System.Drawing.Point(285, 118);
         //   this.contactPage1.Name = "contactPage1";
         //   this.contactPage1.Size = new System.Drawing.Size(763, 423);
         //   this.contactPage1.TabIndex = 3;

            // fortnite_SkinTableAdapter
            // 
            this.fortnite_SkinTableAdapter.ClearBeforeFill = true;
            // 
            // fortniteDataSet1
            // 
            this.fortniteDataSet1.DataSetName = "FortniteDataSet1";
            this.fortniteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fortniteBindingSource
            // 
            this.fortniteBindingSource.DataMember = "Fortnite";
            this.fortniteBindingSource.DataSource = this.fortniteDataSet1;
            // 
            // fortniteTableAdapter
            // 
            this.fortniteTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.PanelAnimator.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Location = new System.Drawing.Point(242, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 92);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);

            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SkinNaam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomTextbox1);

            this.Controls.Add(this.slidemenu);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.Header);
          //  this.Controls.Add(this.contactPage1);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";

            this.Text = "Menu";

       //     this.Load += new System.EventHandler(this.Form1_Load);
            this.slidemenu.ResumeLayout(false);
            this.slidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNmenu)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.skinTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.fortniteSkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteBindingSource)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel slidemenu;
        private Bunifu.Framework.UI.BunifuImageButton BTNmenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource skinTableBindingSource;
       // private DatabaseDataSetTableAdapters.SkinTableTableAdapter skinTableTableAdapter;
       // private ContactPage contactPage1;

        private System.Windows.Forms.Button button1;
        private FortniteDataSet fortniteDataSet;
        private System.Windows.Forms.BindingSource fortniteSkinBindingSource;
        private FortniteDataSetTableAdapters.Fortnite_SkinTableAdapter fortnite_SkinTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel SkinNaam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private FortniteDataSet1 fortniteDataSet1;
        private System.Windows.Forms.BindingSource fortniteBindingSource;
        private FortniteDataSet1TableAdapters.FortniteTableAdapter fortniteTableAdapter;
        private System.Windows.Forms.Button button4;

    }
}

