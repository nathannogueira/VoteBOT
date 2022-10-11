namespace VoteBOT
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.timerContador = new System.Windows.Forms.Timer(this.components);
            this.labelContador = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonLigar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonDesligar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.LabelStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerContador
            // 
            this.timerContador.Enabled = true;
            this.timerContador.Interval = 1000;
            this.timerContador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelContador
            // 
            this.labelContador.AutoEllipsis = false;
            this.labelContador.AutoSize = false;
            this.labelContador.CursorType = null;
            this.labelContador.Font = new System.Drawing.Font("Trebuchet MS", 26F);
            this.labelContador.ForeColor = System.Drawing.Color.White;
            this.labelContador.Location = new System.Drawing.Point(316, 332);
            this.labelContador.Name = "labelContador";
            this.labelContador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelContador.Size = new System.Drawing.Size(149, 52);
            this.labelContador.TabIndex = 17;
            this.labelContador.Text = "0";
            this.labelContador.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labelContador.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(358, 384);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(65, 29);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "VOTOS";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PanelHeader.Controls.Add(this.bunifuImageButton4);
            this.PanelHeader.Controls.Add(this.pictureBox1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(780, 229);
            this.PanelHeader.TabIndex = 23;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(737, 12);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 22;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // buttonLigar
            // 
            this.buttonLigar.AllowToggling = false;
            this.buttonLigar.AnimationSpeed = 200;
            this.buttonLigar.AutoGenerateColors = false;
            this.buttonLigar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLigar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonLigar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLigar.BackgroundImage")));
            this.buttonLigar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonLigar.ButtonText = "INICIAR";
            this.buttonLigar.ButtonTextMarginLeft = 0;
            this.buttonLigar.ColorContrastOnClick = 45;
            this.buttonLigar.ColorContrastOnHover = 45;
            this.buttonLigar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonLigar.CustomizableEdges = borderEdges2;
            this.buttonLigar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonLigar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.buttonLigar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonLigar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonLigar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonLigar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLigar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.buttonLigar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLigar.IconMarginLeft = 11;
            this.buttonLigar.IconPadding = 10;
            this.buttonLigar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLigar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.buttonLigar.IdleBorderRadius = 40;
            this.buttonLigar.IdleBorderThickness = 1;
            this.buttonLigar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonLigar.IdleIconLeftImage = null;
            this.buttonLigar.IdleIconRightImage = null;
            this.buttonLigar.IndicateFocus = false;
            this.buttonLigar.Location = new System.Drawing.Point(235, 515);
            this.buttonLigar.Name = "buttonLigar";
            this.buttonLigar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.buttonLigar.onHoverState.BorderRadius = 40;
            this.buttonLigar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonLigar.onHoverState.BorderThickness = 1;
            this.buttonLigar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.buttonLigar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonLigar.onHoverState.IconLeftImage = null;
            this.buttonLigar.onHoverState.IconRightImage = null;
            this.buttonLigar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLigar.OnIdleState.BorderRadius = 40;
            this.buttonLigar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonLigar.OnIdleState.BorderThickness = 1;
            this.buttonLigar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonLigar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.buttonLigar.OnIdleState.IconLeftImage = null;
            this.buttonLigar.OnIdleState.IconRightImage = null;
            this.buttonLigar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonLigar.OnPressedState.BorderRadius = 40;
            this.buttonLigar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonLigar.OnPressedState.BorderThickness = 1;
            this.buttonLigar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonLigar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonLigar.OnPressedState.IconLeftImage = null;
            this.buttonLigar.OnPressedState.IconRightImage = null;
            this.buttonLigar.Size = new System.Drawing.Size(150, 45);
            this.buttonLigar.TabIndex = 21;
            this.buttonLigar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLigar.TextMarginLeft = 0;
            this.buttonLigar.UseDefaultRadiusAndThickness = true;
            this.buttonLigar.Click += new System.EventHandler(this.buttonLigar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 41);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(42, 41);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 22;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(72, 41);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 22;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // buttonDesligar
            // 
            this.buttonDesligar.AllowToggling = false;
            this.buttonDesligar.AnimationSpeed = 200;
            this.buttonDesligar.AutoGenerateColors = false;
            this.buttonDesligar.BackColor = System.Drawing.Color.Transparent;
            this.buttonDesligar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonDesligar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDesligar.BackgroundImage")));
            this.buttonDesligar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonDesligar.ButtonText = "PARAR";
            this.buttonDesligar.ButtonTextMarginLeft = 0;
            this.buttonDesligar.ColorContrastOnClick = 45;
            this.buttonDesligar.ColorContrastOnHover = 45;
            this.buttonDesligar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonDesligar.CustomizableEdges = borderEdges1;
            this.buttonDesligar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonDesligar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.buttonDesligar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDesligar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonDesligar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonDesligar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesligar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.buttonDesligar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDesligar.IconMarginLeft = 11;
            this.buttonDesligar.IconPadding = 10;
            this.buttonDesligar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDesligar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.buttonDesligar.IdleBorderRadius = 40;
            this.buttonDesligar.IdleBorderThickness = 1;
            this.buttonDesligar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonDesligar.IdleIconLeftImage = null;
            this.buttonDesligar.IdleIconRightImage = null;
            this.buttonDesligar.IndicateFocus = false;
            this.buttonDesligar.Location = new System.Drawing.Point(400, 515);
            this.buttonDesligar.Name = "buttonDesligar";
            this.buttonDesligar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.buttonDesligar.onHoverState.BorderRadius = 40;
            this.buttonDesligar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonDesligar.onHoverState.BorderThickness = 1;
            this.buttonDesligar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.buttonDesligar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonDesligar.onHoverState.IconLeftImage = null;
            this.buttonDesligar.onHoverState.IconRightImage = null;
            this.buttonDesligar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonDesligar.OnIdleState.BorderRadius = 40;
            this.buttonDesligar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonDesligar.OnIdleState.BorderThickness = 1;
            this.buttonDesligar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonDesligar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.buttonDesligar.OnIdleState.IconLeftImage = null;
            this.buttonDesligar.OnIdleState.IconRightImage = null;
            this.buttonDesligar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonDesligar.OnPressedState.BorderRadius = 40;
            this.buttonDesligar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonDesligar.OnPressedState.BorderThickness = 1;
            this.buttonDesligar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.buttonDesligar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonDesligar.OnPressedState.IconLeftImage = null;
            this.buttonDesligar.OnPressedState.IconRightImage = null;
            this.buttonDesligar.Size = new System.Drawing.Size(150, 45);
            this.buttonDesligar.TabIndex = 21;
            this.buttonDesligar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonDesligar.TextMarginLeft = 0;
            this.buttonDesligar.UseDefaultRadiusAndThickness = true;
            this.buttonDesligar.Click += new System.EventHandler(this.buttonDesligar_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 20;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(290, 263);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.bunifuCircleProgressbar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar1.TabIndex = 24;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = false;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = true;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.8D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuProgressBar1.BorderRadius = 10;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(207, 47);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(366, 18);
            this.bunifuProgressBar1.TabIndex = 27;
            this.bunifuProgressBar1.Value = 0;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoEllipsis = false;
            this.LabelStatus.AutoSize = false;
            this.LabelStatus.CursorType = null;
            this.LabelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelStatus.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.LabelStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelStatus.Location = new System.Drawing.Point(0, 14);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelStatus.Size = new System.Drawing.Size(780, 63);
            this.LabelStatus.TabIndex = 16;
            this.LabelStatus.Text = "Inicie o processo!";
            this.LabelStatus.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.LabelStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuProgressBar1);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.LabelStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 77);
            this.panel1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(780, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.buttonDesligar);
            this.Controls.Add(this.buttonLigar);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.PanelHeader);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoteBOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timerContador;
        private Bunifu.UI.WinForms.BunifuLabel labelContador;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonLigar;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonDesligar;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.UI.WinForms.BunifuLabel LabelStatus;
        public Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
    }
}

