namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.myEllipse = new System.Windows.Forms.Button();
            this.buttonDrawPryamougolnik = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelColor = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(70, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 444);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTools.Controls.Add(this.buttonSelect);
            this.panelTools.Controls.Add(this.buttonFill);
            this.panelTools.Controls.Add(this.button1);
            this.panelTools.Controls.Add(this.myEllipse);
            this.panelTools.Controls.Add(this.buttonDrawPryamougolnik);
            this.panelTools.Controls.Add(this.trackBar1);
            this.panelTools.Controls.Add(this.panelColor);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTools.Location = new System.Drawing.Point(0, 24);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(68, 444);
            this.panelTools.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelect.BackgroundImage")));
            this.buttonSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelect.Location = new System.Drawing.Point(4, 353);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(60, 61);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFill.BackgroundImage")));
            this.buttonFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFill.Location = new System.Drawing.Point(4, 309);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(60, 38);
            this.buttonFill.TabIndex = 5;
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(4, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 38);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myEllipse
            // 
            this.myEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.myEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myEllipse.BackgroundImage")));
            this.myEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myEllipse.Location = new System.Drawing.Point(4, 170);
            this.myEllipse.Name = "myEllipse";
            this.myEllipse.Size = new System.Drawing.Size(60, 40);
            this.myEllipse.TabIndex = 3;
            this.myEllipse.UseVisualStyleBackColor = false;
            this.myEllipse.Click += new System.EventHandler(this.myEllipse_Click);
            // 
            // buttonDrawPryamougolnik
            // 
            this.buttonDrawPryamougolnik.BackColor = System.Drawing.Color.Moccasin;
            this.buttonDrawPryamougolnik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDrawPryamougolnik.BackgroundImage")));
            this.buttonDrawPryamougolnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDrawPryamougolnik.Location = new System.Drawing.Point(4, 216);
            this.buttonDrawPryamougolnik.Name = "buttonDrawPryamougolnik";
            this.buttonDrawPryamougolnik.Size = new System.Drawing.Size(60, 43);
            this.buttonDrawPryamougolnik.TabIndex = 2;
            this.buttonDrawPryamougolnik.UseVisualStyleBackColor = false;
            this.buttonDrawPryamougolnik.Click += new System.EventHandler(this.buttonDrawPryamougolnik_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBar1.Location = new System.Drawing.Point(4, 68);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 101);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Maroon;
            this.panelColor.Location = new System.Drawing.Point(3, 3);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(61, 59);
            this.panelColor.TabIndex = 0;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button myEllipse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDrawPryamougolnik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
    }
}

