namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxConnection = new System.Windows.Forms.ComboBox();
            this.textBoxBataryaSıcaklığı = new System.Windows.Forms.TextBox();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.Black;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.GaugeArcColor = System.Drawing.Color.RoyalBlue;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableColor = System.Drawing.Color.Black;
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.GaugeValueColor = System.Drawing.Color.Black;
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.Black;
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.Black;
            this.radialGauge1.Location = new System.Drawing.Point(-1, 121);
            this.radialGauge1.MajorTickMarkColor = System.Drawing.Color.Black;
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.MinorTickMarkColor = System.Drawing.Color.Black;
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.NeedleColor = System.Drawing.Color.Black;
            this.radialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.Navy;
            this.radialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.Navy;
            this.radialGauge1.ScaleLabelColor = System.Drawing.Color.Black;
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(287, 287);
            this.radialGauge1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-1, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(618, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 45);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1219, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 111);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // comboBoxConnection
            // 
            this.comboBoxConnection.FormattingEnabled = true;
            this.comboBoxConnection.Location = new System.Drawing.Point(1105, 28);
            this.comboBoxConnection.Name = "comboBoxConnection";
            this.comboBoxConnection.Size = new System.Drawing.Size(121, 24);
            this.comboBoxConnection.TabIndex = 4;
            // 
            // textBoxBataryaSıcaklığı
            // 
            this.textBoxBataryaSıcaklığı.Location = new System.Drawing.Point(30, 485);
            this.textBoxBataryaSıcaklığı.Multiline = true;
            this.textBoxBataryaSıcaklığı.Name = "textBoxBataryaSıcaklığı";
            this.textBoxBataryaSıcaklığı.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBataryaSıcaklığı.Size = new System.Drawing.Size(168, 102);
            this.textBoxBataryaSıcaklığı.TabIndex = 10;
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(1003, 12);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(75, 55);
            this.buttonBaglan.TabIndex = 11;
            this.buttonBaglan.Text = "Bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // radialGauge2
            // 
            this.radialGauge2.ArcThickness = 2F;
            this.radialGauge2.BackgroundGradientEndColor = System.Drawing.Color.Black;
            this.radialGauge2.EnableCustomNeedles = false;
            this.radialGauge2.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge2.ForeColor = System.Drawing.Color.Red;
            this.radialGauge2.FrameThickness = 12;
            this.radialGauge2.GaugeArcColor = System.Drawing.Color.Red;
            this.radialGauge2.GaugeLabel = "Gauge";
            this.radialGauge2.GaugeLableColor = System.Drawing.Color.Red;
            this.radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.GaugeValueColor = System.Drawing.Color.Red;
            this.radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.InterLinesColor = System.Drawing.Color.Red;
            this.radialGauge2.Location = new System.Drawing.Point(304, 121);
            this.radialGauge2.MajorTickMarkColor = System.Drawing.Color.Red;
            this.radialGauge2.MaximumValue = 80F;
            this.radialGauge2.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge2.MinorTickMarkColor = System.Drawing.Color.Red;
            this.radialGauge2.Name = "radialGauge2";
            this.radialGauge2.NeedleColor = System.Drawing.Color.Navy;
            this.radialGauge2.OuterFrameGradientEndColor = System.Drawing.Color.Black;
            this.radialGauge2.OuterFrameGradientStartColor = System.Drawing.Color.Black;
            this.radialGauge2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radialGauge2.ScaleLabelColor = System.Drawing.Color.Red;
            this.radialGauge2.ShowGaugeValue = true;
            this.radialGauge2.ShowTicks = true;
            this.radialGauge2.Size = new System.Drawing.Size(287, 287);
            this.radialGauge2.TabIndex = 14;
            this.radialGauge2.RightToLeftChanged += new System.EventHandler(this.radialGauge2_RightToLeftChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gelen Veriler";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(1003, 73);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 55);
            this.buttonDisconnect.TabIndex = 31;
            this.buttonDisconnect.Text = "Bağlantı Kes";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(922, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 32;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digitalGauge1.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digitalGauge1.DisplayRecordIndex = 0;
            this.digitalGauge1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.digitalGauge1.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.digitalGauge1.Location = new System.Drawing.Point(670, 9);
            this.digitalGauge1.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge1.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.digitalGauge1.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.digitalGauge1.Size = new System.Drawing.Size(186, 90);
            this.digitalGauge1.TabIndex = 33;
            this.digitalGauge1.Value = "0";
            this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(396, 45);
            this.progressBar2.Maximum = 1024;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(125, 23);
            this.progressBar2.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 485);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 102);
            this.textBox2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "2.Veri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 937);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.digitalGauge1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radialGauge2);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.textBoxBataryaSıcaklığı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBoxConnection);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radialGauge1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxConnection;
        private System.Windows.Forms.TextBox textBoxBataryaSıcaklığı;
        private System.Windows.Forms.Button buttonBaglan;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button button2;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

