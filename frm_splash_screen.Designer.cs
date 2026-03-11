namespace myClinic
{
    partial class frm_splash_screen
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
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle1 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash_screen));
            this.timer_splash_screen = new System.Windows.Forms.Timer(this.components);
            this.progressB_splash_screen = new MetroFramework.Controls.MetroProgressSpinner();
            this.elLabel1 = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.elLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_splash_screen
            // 
            this.timer_splash_screen.Tick += new System.EventHandler(this.timer_splash_screen_Tick);
            // 
            // progressB_splash_screen
            // 
            this.progressB_splash_screen.Location = new System.Drawing.Point(107, 43);
            this.progressB_splash_screen.Maximum = 100;
            this.progressB_splash_screen.Name = "progressB_splash_screen";
            this.progressB_splash_screen.Size = new System.Drawing.Size(119, 85);
            this.progressB_splash_screen.TabIndex = 1;
            this.progressB_splash_screen.UseSelectable = true;
            // 
            // elLabel1
            // 
            this.elLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.elLabel1.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elLabel1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elLabel1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.elLabel1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elLabel1.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            paintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle1.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elLabel1.FlashStyle = paintStyle1;
            this.elLabel1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elLabel1.Location = new System.Drawing.Point(58, 134);
            this.elLabel1.Name = "elLabel1";
            this.elLabel1.Size = new System.Drawing.Size(214, 30);
            this.elLabel1.TabIndex = 4;
            this.elLabel1.TabStop = false;
            this.elLabel1.TextStyle.BackColor = System.Drawing.Color.DarkBlue;
            this.elLabel1.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elLabel1.TextStyle.ForeColor = System.Drawing.Color.White;
            this.elLabel1.TextStyle.Text = "wellcome";
            this.elLabel1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elLabel1.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow;
            this.elLabel1.TransparentStyle.BackColor = System.Drawing.Color.Transparent;
            this.elLabel1.TransparentStyle.TransparencyType = Klik.Windows.Forms.v1.Common.TransparencyTypes.SolidBackColor;
            this.elLabel1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.RosyBrown;
            this.metroLabel1.Location = new System.Drawing.Point(71, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(201, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "...به نرم افزار کلینیک خوش آمدین";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 184);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.elLabel1);
            this.Controls.Add(this.progressB_splash_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_splash_screen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frm_splash_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_splash_screen;
        private MetroFramework.Controls.MetroProgressSpinner progressB_splash_screen;
        private Klik.Windows.Forms.v1.EntryLib.ELLabel elLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

