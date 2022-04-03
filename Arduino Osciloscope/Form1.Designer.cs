
namespace Arduino_Osciloscope
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.osciloscope = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel_chControls = new System.Windows.Forms.Panel();
            this.lb_ch4 = new System.Windows.Forms.Label();
            this.lb_ch3 = new System.Windows.Forms.Label();
            this.lb_ch2 = new System.Windows.Forms.Label();
            this.lb_ch1 = new System.Windows.Forms.Label();
            this.chb_ch4 = new System.Windows.Forms.CheckBox();
            this.rad_ch4Digital = new System.Windows.Forms.RadioButton();
            this.rad_ch4Analog = new System.Windows.Forms.RadioButton();
            this.chb_ch3 = new System.Windows.Forms.CheckBox();
            this.rad_ch3Digital = new System.Windows.Forms.RadioButton();
            this.rad_ch3Analog = new System.Windows.Forms.RadioButton();
            this.chb_ch2 = new System.Windows.Forms.CheckBox();
            this.rad_ch2Digital = new System.Windows.Forms.RadioButton();
            this.rad_ch2Analog = new System.Windows.Forms.RadioButton();
            this.chb_ch1 = new System.Windows.Forms.CheckBox();
            this.rad_ch1Digital = new System.Windows.Forms.RadioButton();
            this.rad_ch1Analog = new System.Windows.Forms.RadioButton();
            this.panel_ch1 = new System.Windows.Forms.Panel();
            this.panel_ch2 = new System.Windows.Forms.Panel();
            this.panel_ch3 = new System.Windows.Forms.Panel();
            this.panel_ch4 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.osciloscope)).BeginInit();
            this.panel_chControls.SuspendLayout();
            this.panel_ch1.SuspendLayout();
            this.panel_ch2.SuspendLayout();
            this.panel_ch3.SuspendLayout();
            this.panel_ch4.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // osciloscope
            // 
            this.osciloscope.BackColor = System.Drawing.Color.Black;
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.BorderColor = System.Drawing.Color.Empty;
            chartArea6.Name = "ChartArea1";
            this.osciloscope.ChartAreas.Add(chartArea6);
            this.osciloscope.Dock = System.Windows.Forms.DockStyle.Left;
            legend6.BackColor = System.Drawing.Color.Black;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.osciloscope.Legends.Add(legend6);
            this.osciloscope.Location = new System.Drawing.Point(0, 0);
            this.osciloscope.Name = "osciloscope";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Color = System.Drawing.Color.Red;
            series21.Legend = "Legend1";
            series21.Name = "Channel1";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series22.Legend = "Legend1";
            series22.Name = "Channel2";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Color = System.Drawing.Color.Blue;
            series23.Legend = "Legend1";
            series23.Name = "Channel3";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Color = System.Drawing.Color.Yellow;
            series24.Legend = "Legend1";
            series24.Name = "Channel4";
            this.osciloscope.Series.Add(series21);
            this.osciloscope.Series.Add(series22);
            this.osciloscope.Series.Add(series23);
            this.osciloscope.Series.Add(series24);
            this.osciloscope.Size = new System.Drawing.Size(700, 601);
            this.osciloscope.TabIndex = 0;
            this.osciloscope.Text = "Osciloscope";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(3, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(265, 54);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel_chControls
            // 
            this.panel_chControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_chControls.Controls.Add(this.panel_ch4);
            this.panel_chControls.Controls.Add(this.lb_ch4);
            this.panel_chControls.Controls.Add(this.panel_ch3);
            this.panel_chControls.Controls.Add(this.lb_ch3);
            this.panel_chControls.Controls.Add(this.panel_ch2);
            this.panel_chControls.Controls.Add(this.lb_ch2);
            this.panel_chControls.Controls.Add(this.panel_ch1);
            this.panel_chControls.Controls.Add(this.lb_ch1);
            this.panel_chControls.Location = new System.Drawing.Point(3, 63);
            this.panel_chControls.Name = "panel_chControls";
            this.panel_chControls.Size = new System.Drawing.Size(265, 535);
            this.panel_chControls.TabIndex = 19;
            // 
            // lb_ch4
            // 
            this.lb_ch4.AutoSize = true;
            this.lb_ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ch4.ForeColor = System.Drawing.Color.White;
            this.lb_ch4.Location = new System.Drawing.Point(3, 272);
            this.lb_ch4.Name = "lb_ch4";
            this.lb_ch4.Size = new System.Drawing.Size(71, 17);
            this.lb_ch4.TabIndex = 33;
            this.lb_ch4.Text = "Ch4 : U = ";
            // 
            // lb_ch3
            // 
            this.lb_ch3.AutoSize = true;
            this.lb_ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ch3.ForeColor = System.Drawing.Color.White;
            this.lb_ch3.Location = new System.Drawing.Point(3, 253);
            this.lb_ch3.Name = "lb_ch3";
            this.lb_ch3.Size = new System.Drawing.Size(71, 17);
            this.lb_ch3.TabIndex = 32;
            this.lb_ch3.Text = "Ch3 : U = ";
            // 
            // lb_ch2
            // 
            this.lb_ch2.AutoSize = true;
            this.lb_ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ch2.ForeColor = System.Drawing.Color.White;
            this.lb_ch2.Location = new System.Drawing.Point(3, 234);
            this.lb_ch2.Name = "lb_ch2";
            this.lb_ch2.Size = new System.Drawing.Size(71, 17);
            this.lb_ch2.TabIndex = 31;
            this.lb_ch2.Text = "Ch2 : U = ";
            // 
            // lb_ch1
            // 
            this.lb_ch1.AutoSize = true;
            this.lb_ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ch1.ForeColor = System.Drawing.Color.White;
            this.lb_ch1.Location = new System.Drawing.Point(3, 215);
            this.lb_ch1.Name = "lb_ch1";
            this.lb_ch1.Size = new System.Drawing.Size(71, 17);
            this.lb_ch1.TabIndex = 30;
            this.lb_ch1.Text = "Ch1 : U = ";
            // 
            // chb_ch4
            // 
            this.chb_ch4.AutoSize = true;
            this.chb_ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ch4.ForeColor = System.Drawing.Color.White;
            this.chb_ch4.Location = new System.Drawing.Point(0, 0);
            this.chb_ch4.Name = "chb_ch4";
            this.chb_ch4.Size = new System.Drawing.Size(91, 21);
            this.chb_ch4.TabIndex = 29;
            this.chb_ch4.Text = "Channel 4";
            this.chb_ch4.UseVisualStyleBackColor = true;
            this.chb_ch4.CheckedChanged += new System.EventHandler(this.chb_ch4_CheckedChanged);
            // 
            // rad_ch4Digital
            // 
            this.rad_ch4Digital.AutoSize = true;
            this.rad_ch4Digital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch4Digital.ForeColor = System.Drawing.Color.White;
            this.rad_ch4Digital.Location = new System.Drawing.Point(76, 23);
            this.rad_ch4Digital.Name = "rad_ch4Digital";
            this.rad_ch4Digital.Size = new System.Drawing.Size(65, 21);
            this.rad_ch4Digital.TabIndex = 28;
            this.rad_ch4Digital.Text = "Digital";
            this.rad_ch4Digital.UseVisualStyleBackColor = true;
            this.rad_ch4Digital.CheckedChanged += new System.EventHandler(this.rad_ch4Digital_CheckedChanged);
            // 
            // rad_ch4Analog
            // 
            this.rad_ch4Analog.AutoSize = true;
            this.rad_ch4Analog.Checked = true;
            this.rad_ch4Analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch4Analog.ForeColor = System.Drawing.Color.White;
            this.rad_ch4Analog.Location = new System.Drawing.Point(1, 23);
            this.rad_ch4Analog.Name = "rad_ch4Analog";
            this.rad_ch4Analog.Size = new System.Drawing.Size(70, 21);
            this.rad_ch4Analog.TabIndex = 27;
            this.rad_ch4Analog.TabStop = true;
            this.rad_ch4Analog.Text = "Analog";
            this.rad_ch4Analog.UseVisualStyleBackColor = true;
            this.rad_ch4Analog.CheckedChanged += new System.EventHandler(this.rad_ch4Analog_CheckedChanged);
            // 
            // chb_ch3
            // 
            this.chb_ch3.AutoSize = true;
            this.chb_ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ch3.ForeColor = System.Drawing.Color.White;
            this.chb_ch3.Location = new System.Drawing.Point(0, -3);
            this.chb_ch3.Name = "chb_ch3";
            this.chb_ch3.Size = new System.Drawing.Size(91, 21);
            this.chb_ch3.TabIndex = 26;
            this.chb_ch3.Text = "Channel 3";
            this.chb_ch3.UseVisualStyleBackColor = true;
            this.chb_ch3.CheckedChanged += new System.EventHandler(this.chb_ch3_CheckedChanged);
            // 
            // rad_ch3Digital
            // 
            this.rad_ch3Digital.AutoSize = true;
            this.rad_ch3Digital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch3Digital.ForeColor = System.Drawing.Color.White;
            this.rad_ch3Digital.Location = new System.Drawing.Point(76, 20);
            this.rad_ch3Digital.Name = "rad_ch3Digital";
            this.rad_ch3Digital.Size = new System.Drawing.Size(65, 21);
            this.rad_ch3Digital.TabIndex = 25;
            this.rad_ch3Digital.Text = "Digital";
            this.rad_ch3Digital.UseVisualStyleBackColor = true;
            this.rad_ch3Digital.CheckedChanged += new System.EventHandler(this.rad_ch3Digital_CheckedChanged);
            // 
            // rad_ch3Analog
            // 
            this.rad_ch3Analog.AutoSize = true;
            this.rad_ch3Analog.Checked = true;
            this.rad_ch3Analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch3Analog.ForeColor = System.Drawing.Color.White;
            this.rad_ch3Analog.Location = new System.Drawing.Point(1, 20);
            this.rad_ch3Analog.Name = "rad_ch3Analog";
            this.rad_ch3Analog.Size = new System.Drawing.Size(70, 21);
            this.rad_ch3Analog.TabIndex = 24;
            this.rad_ch3Analog.TabStop = true;
            this.rad_ch3Analog.Text = "Analog";
            this.rad_ch3Analog.UseVisualStyleBackColor = true;
            this.rad_ch3Analog.CheckedChanged += new System.EventHandler(this.rad_ch3Analog_CheckedChanged);
            // 
            // chb_ch2
            // 
            this.chb_ch2.AutoSize = true;
            this.chb_ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ch2.ForeColor = System.Drawing.Color.White;
            this.chb_ch2.Location = new System.Drawing.Point(0, 0);
            this.chb_ch2.Name = "chb_ch2";
            this.chb_ch2.Size = new System.Drawing.Size(91, 21);
            this.chb_ch2.TabIndex = 23;
            this.chb_ch2.Text = "Channel 2";
            this.chb_ch2.UseVisualStyleBackColor = true;
            this.chb_ch2.CheckedChanged += new System.EventHandler(this.chb_ch2_CheckedChanged);
            // 
            // rad_ch2Digital
            // 
            this.rad_ch2Digital.AutoSize = true;
            this.rad_ch2Digital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch2Digital.ForeColor = System.Drawing.Color.White;
            this.rad_ch2Digital.Location = new System.Drawing.Point(76, 23);
            this.rad_ch2Digital.Name = "rad_ch2Digital";
            this.rad_ch2Digital.Size = new System.Drawing.Size(65, 21);
            this.rad_ch2Digital.TabIndex = 22;
            this.rad_ch2Digital.Text = "Digital";
            this.rad_ch2Digital.UseVisualStyleBackColor = true;
            this.rad_ch2Digital.CheckedChanged += new System.EventHandler(this.rad_ch2Digital_CheckedChanged);
            // 
            // rad_ch2Analog
            // 
            this.rad_ch2Analog.AutoSize = true;
            this.rad_ch2Analog.Checked = true;
            this.rad_ch2Analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch2Analog.ForeColor = System.Drawing.Color.White;
            this.rad_ch2Analog.Location = new System.Drawing.Point(1, 23);
            this.rad_ch2Analog.Name = "rad_ch2Analog";
            this.rad_ch2Analog.Size = new System.Drawing.Size(70, 21);
            this.rad_ch2Analog.TabIndex = 21;
            this.rad_ch2Analog.TabStop = true;
            this.rad_ch2Analog.Text = "Analog";
            this.rad_ch2Analog.UseVisualStyleBackColor = true;
            this.rad_ch2Analog.CheckedChanged += new System.EventHandler(this.rad_ch2Analog_CheckedChanged);
            // 
            // chb_ch1
            // 
            this.chb_ch1.AutoSize = true;
            this.chb_ch1.Checked = true;
            this.chb_ch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ch1.ForeColor = System.Drawing.Color.White;
            this.chb_ch1.Location = new System.Drawing.Point(0, 0);
            this.chb_ch1.Name = "chb_ch1";
            this.chb_ch1.Size = new System.Drawing.Size(91, 21);
            this.chb_ch1.TabIndex = 20;
            this.chb_ch1.Text = "Channel 1";
            this.chb_ch1.UseVisualStyleBackColor = true;
            this.chb_ch1.CheckedChanged += new System.EventHandler(this.chb_ch1_CheckedChanged);
            // 
            // rad_ch1Digital
            // 
            this.rad_ch1Digital.AutoSize = true;
            this.rad_ch1Digital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch1Digital.ForeColor = System.Drawing.Color.White;
            this.rad_ch1Digital.Location = new System.Drawing.Point(75, 27);
            this.rad_ch1Digital.Name = "rad_ch1Digital";
            this.rad_ch1Digital.Size = new System.Drawing.Size(65, 21);
            this.rad_ch1Digital.TabIndex = 19;
            this.rad_ch1Digital.Text = "Digital";
            this.rad_ch1Digital.UseVisualStyleBackColor = true;
            this.rad_ch1Digital.CheckedChanged += new System.EventHandler(this.rad_ch1Digital_CheckedChanged);
            // 
            // rad_ch1Analog
            // 
            this.rad_ch1Analog.AutoSize = true;
            this.rad_ch1Analog.Checked = true;
            this.rad_ch1Analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ch1Analog.ForeColor = System.Drawing.Color.White;
            this.rad_ch1Analog.Location = new System.Drawing.Point(0, 27);
            this.rad_ch1Analog.Name = "rad_ch1Analog";
            this.rad_ch1Analog.Size = new System.Drawing.Size(70, 21);
            this.rad_ch1Analog.TabIndex = 18;
            this.rad_ch1Analog.TabStop = true;
            this.rad_ch1Analog.Text = "Analog";
            this.rad_ch1Analog.UseVisualStyleBackColor = true;
            this.rad_ch1Analog.CheckedChanged += new System.EventHandler(this.rad_ch1Analog_CheckedChanged);
            // 
            // panel_ch1
            // 
            this.panel_ch1.Controls.Add(this.rad_ch1Analog);
            this.panel_ch1.Controls.Add(this.rad_ch1Digital);
            this.panel_ch1.Controls.Add(this.chb_ch1);
            this.panel_ch1.Location = new System.Drawing.Point(3, 3);
            this.panel_ch1.Name = "panel_ch1";
            this.panel_ch1.Size = new System.Drawing.Size(140, 50);
            this.panel_ch1.TabIndex = 34;
            // 
            // panel_ch2
            // 
            this.panel_ch2.Controls.Add(this.chb_ch2);
            this.panel_ch2.Controls.Add(this.rad_ch2Analog);
            this.panel_ch2.Controls.Add(this.rad_ch2Digital);
            this.panel_ch2.Location = new System.Drawing.Point(3, 59);
            this.panel_ch2.Name = "panel_ch2";
            this.panel_ch2.Size = new System.Drawing.Size(140, 50);
            this.panel_ch2.TabIndex = 34;
            // 
            // panel_ch3
            // 
            this.panel_ch3.Controls.Add(this.chb_ch3);
            this.panel_ch3.Controls.Add(this.rad_ch3Analog);
            this.panel_ch3.Controls.Add(this.rad_ch3Digital);
            this.panel_ch3.Location = new System.Drawing.Point(3, 115);
            this.panel_ch3.Name = "panel_ch3";
            this.panel_ch3.Size = new System.Drawing.Size(140, 50);
            this.panel_ch3.TabIndex = 34;
            // 
            // panel_ch4
            // 
            this.panel_ch4.Controls.Add(this.chb_ch4);
            this.panel_ch4.Controls.Add(this.rad_ch4Analog);
            this.panel_ch4.Controls.Add(this.rad_ch4Digital);
            this.panel_ch4.Location = new System.Drawing.Point(3, 162);
            this.panel_ch4.Name = "panel_ch4";
            this.panel_ch4.Size = new System.Drawing.Size(140, 50);
            this.panel_ch4.TabIndex = 34;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.btn_start);
            this.panel_main.Controls.Add(this.panel_chControls);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_main.Location = new System.Drawing.Point(753, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(271, 601);
            this.panel_main.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.osciloscope);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Osciloscope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.osciloscope)).EndInit();
            this.panel_chControls.ResumeLayout(false);
            this.panel_chControls.PerformLayout();
            this.panel_ch1.ResumeLayout(false);
            this.panel_ch1.PerformLayout();
            this.panel_ch2.ResumeLayout(false);
            this.panel_ch2.PerformLayout();
            this.panel_ch3.ResumeLayout(false);
            this.panel_ch3.PerformLayout();
            this.panel_ch4.ResumeLayout(false);
            this.panel_ch4.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart osciloscope;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel_chControls;
        private System.Windows.Forms.Label lb_ch4;
        private System.Windows.Forms.Label lb_ch3;
        private System.Windows.Forms.Label lb_ch2;
        private System.Windows.Forms.Label lb_ch1;
        private System.Windows.Forms.CheckBox chb_ch4;
        private System.Windows.Forms.RadioButton rad_ch4Digital;
        private System.Windows.Forms.RadioButton rad_ch4Analog;
        private System.Windows.Forms.CheckBox chb_ch3;
        private System.Windows.Forms.RadioButton rad_ch3Digital;
        private System.Windows.Forms.RadioButton rad_ch3Analog;
        private System.Windows.Forms.CheckBox chb_ch2;
        private System.Windows.Forms.RadioButton rad_ch2Digital;
        private System.Windows.Forms.RadioButton rad_ch2Analog;
        private System.Windows.Forms.CheckBox chb_ch1;
        private System.Windows.Forms.RadioButton rad_ch1Digital;
        private System.Windows.Forms.RadioButton rad_ch1Analog;
        private System.Windows.Forms.Panel panel_ch4;
        private System.Windows.Forms.Panel panel_ch3;
        private System.Windows.Forms.Panel panel_ch2;
        private System.Windows.Forms.Panel panel_ch1;
        private System.Windows.Forms.Panel panel_main;
    }
}

