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
            this.Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fortniteDataSet2 = new Fortnite_Design.FortniteDataSet2();
            this.collection1 = new Fortnite_Design.Collection();
            this.fortniteSkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fortniteDataSet = new Fortnite_Design.FortniteDataSet();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.fortnite_SkinTableAdapter = new Fortnite_Design.FortniteDataSetTableAdapters.Fortnite_SkinTableAdapter();
            this.fortniteDataSet1 = new Fortnite_Design.FortniteDataSet1();
            this.fortniteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fortniteTableAdapter = new Fortnite_Design.FortniteDataSet1TableAdapters.FortniteTableAdapter();
            this.fortniteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Fortnite_Design.FortniteDataSet2TableAdapters.AccountTableAdapter();
            this.dataSet11 = new Fortnite_Design.DataSet1();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Skins = new Fortnite_Design.UserControl2();
            this.slidemenu.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteSkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
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
            this.slidemenu.Controls.Add(this.button7);
            this.slidemenu.Controls.Add(this.button3);
            this.slidemenu.Controls.Add(this.button5);
            this.slidemenu.Controls.Add(this.button2);
            this.slidemenu.Controls.Add(this.button1);
            this.slidemenu.Controls.Add(this.label1);
            this.slidemenu.Controls.Add(this.bunifuFlatButton3);
            this.slidemenu.Controls.Add(this.bunifuFlatButton2);
            this.slidemenu.Controls.Add(this.bunifuFlatButton1);
            this.slidemenu.Controls.Add(this.BTNmenu);
            this.PanelAnimator.SetDecoration(this.slidemenu, BunifuAnimatorNS.DecorationType.None);
            this.slidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidemenu.Location = new System.Drawing.Point(0, 59);
            this.slidemenu.Margin = new System.Windows.Forms.Padding(2);
            this.slidemenu.MinimumSize = new System.Drawing.Size(38, 501);
            this.slidemenu.Name = "slidemenu";
            this.slidemenu.Size = new System.Drawing.Size(214, 631);
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
            this.Header.Size = new System.Drawing.Size(1274, 59);
            this.Header.TabIndex = 1;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // button1
            // 
            this.PanelAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(29, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "GetData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.PanelAnimator.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(12, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 81);
            this.button2.TabIndex = 7;
            this.button2.Text = "Select image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.fortniteDataSet2;
            // 
            // fortniteDataSet2
            // 
            this.fortniteDataSet2.DataSetName = "FortniteDataSet2";
            this.fortniteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collection1
            // 
            this.PanelAnimator.SetDecoration(this.collection1, BunifuAnimatorNS.DecorationType.None);
            this.collection1.Location = new System.Drawing.Point(208, 59);
            this.collection1.Name = "collection1";
            this.collection1.Size = new System.Drawing.Size(1063, 628);
            this.collection1.TabIndex = 14;
            this.collection1.Load += new System.EventHandler(this.collection1_Load);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
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
            // fortniteBindingSource1
            // 
            this.fortniteBindingSource1.DataMember = "Fortnite";
            this.fortniteBindingSource1.DataSource = this.fortniteDataSet1;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.PanelAnimator.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button5.Location = new System.Drawing.Point(12, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 25);
            this.button5.TabIndex = 10;
            this.button5.Text = "Add account";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.PanelAnimator.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Location = new System.Drawing.Point(9, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 110);
            this.button3.TabIndex = 8;
            this.button3.Text = "Form switch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.PanelAnimator.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.Location = new System.Drawing.Point(9, 292);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 75);
            this.button7.TabIndex = 13;
            this.button7.Text = "Test";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(278, 57);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "            Collectie";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
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
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(313, 57);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "            Contact";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton1.AutoSize = true;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
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
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(314, 57);
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
            this.BTNmenu.Size = new System.Drawing.Size(37, 41);
            this.BTNmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNmenu.TabIndex = 0;
            this.BTNmenu.TabStop = false;
            this.BTNmenu.Zoom = 10;
            this.BTNmenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1184, 9);
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
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1226, 11);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Skins
            // 
            this.PanelAnimator.SetDecoration(this.Skins, BunifuAnimatorNS.DecorationType.None);
            this.Skins.Location = new System.Drawing.Point(211, 59);
            this.Skins.Name = "Skins";
            this.Skins.Size = new System.Drawing.Size(1063, 631);
            this.Skins.TabIndex = 15;
            this.Skins.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 690);
            this.Controls.Add(this.Skins);
            this.Controls.Add(this.slidemenu);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.collection1);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.slidemenu.ResumeLayout(false);
            this.slidemenu.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteSkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortniteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private FortniteDataSet fortniteDataSet;
        private System.Windows.Forms.BindingSource fortniteSkinBindingSource;
        private FortniteDataSetTableAdapters.Fortnite_SkinTableAdapter fortnite_SkinTableAdapter;
        private System.Windows.Forms.Button button2;
        private FortniteDataSet1 fortniteDataSet1;
        private System.Windows.Forms.BindingSource fortniteBindingSource;
        private FortniteDataSet1TableAdapters.FortniteTableAdapter fortniteTableAdapter;
        private System.Windows.Forms.BindingSource fortniteBindingSource1;
        private FortniteDataSet2 fortniteDataSet2;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private FortniteDataSet2TableAdapters.AccountTableAdapter accountTableAdapter;
        private DataSet1 dataSet11;
        private Collection collection1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private UserControl2 Skins;
    }
}

