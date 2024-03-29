namespace WebslingyThingy {
    partial class Overlay {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.engineTimer = new System.Windows.Forms.Timer(this.components);
            this.pbSpider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpider)).BeginInit();
            this.SuspendLayout();
            // 
            // engineTimer
            // 
            this.engineTimer.Enabled = true;
            this.engineTimer.Interval = 1;
            this.engineTimer.Tick += new System.EventHandler(this.engineTimer_Tick);
            // 
            // pbSpider
            // 
            this.pbSpider.BackColor = System.Drawing.Color.Transparent;
            this.pbSpider.Image = global::WebslingyThingy.Properties.Resources.SpiderDeathLeft;
            this.pbSpider.Location = new System.Drawing.Point(0, 0);
            this.pbSpider.Name = "pbSpider";
            this.pbSpider.Size = new System.Drawing.Size(256, 256);
            this.pbSpider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSpider.TabIndex = 0;
            this.pbSpider.TabStop = false;
            this.pbSpider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.pbSpider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.pbSpider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.ControlBox = false;
            this.Controls.Add(this.pbSpider);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.Text = "WebslingyThingy";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Overlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer engineTimer;
        private System.Windows.Forms.PictureBox pbSpider;
    }
}

