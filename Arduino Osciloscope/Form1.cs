using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Arduino_Osciloscope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osciloscope.Series["Channel1"].Enabled = chb_ch1.Checked;
            osciloscope.Series["Channel2"].Enabled = chb_ch2.Checked;
            osciloscope.Series["Channel3"].Enabled = chb_ch3.Checked;
            osciloscope.Series["Channel4"].Enabled = chb_ch4.Checked;

            lb_ch1.Enabled = chb_ch1.Checked;
            lb_ch2.Enabled = chb_ch2.Checked;
            lb_ch3.Enabled = chb_ch3.Checked;
            lb_ch4.Enabled = chb_ch4.Checked;

            serialPort1.Open();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            osciloscope.Series["Channel1"].Points.AddXY(0, 0);
            osciloscope.Series["Channel2"].Points.AddXY(0, 0);
            osciloscope.Series["Channel3"].Points.AddXY(0, 0);
            osciloscope.Series["Channel4"].Points.AddXY(0, 0);

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = (int)osciloscope.Series["Channel1"].Points[osciloscope.Series["Channel1"].Points.Count - 1].XValue;
            double y = (Convert.ToDouble(data[0]) / 1023) * 5;

            if (osciloscope.Series["Channel1"].Points.Count > maxPoints)
                osciloscope.Series["Channel1"].Points.RemoveAt(0);

            osciloscope.Series["Channel1"].Points.AddXY(x + 1, y);
            osciloscope.ResetAutoValues();

            if (chb_ch1.Checked)
                lb_ch1.Invoke(new MethodInvoker(delegate { lb_ch1.Text = "Ch1 : U = " + y + " V"; }));

            y = (Convert.ToDouble(data[1]) / 1023) * 5;

            if (osciloscope.Series["Channel2"].Points.Count > maxPoints)
                osciloscope.Series["Channel2"].Points.RemoveAt(0);

            osciloscope.Series["Channel2"].Points.AddXY(x + 1, y);
            osciloscope.ResetAutoValues();

            if (chb_ch2.Checked)
                lb_ch2.Invoke(new MethodInvoker(delegate { lb_ch2.Text = "Ch2 : U = " + y + " V"; }));

            y = (Convert.ToDouble(data[2]) / 1023) * 5;

            if (osciloscope.Series["Channel3"].Points.Count > maxPoints)
                osciloscope.Series["Channel3"].Points.RemoveAt(0);

            osciloscope.Series["Channel3"].Points.AddXY(x + 1, y);
            osciloscope.ResetAutoValues();

            if (chb_ch3.Checked)
                lb_ch3.Invoke(new MethodInvoker(delegate { lb_ch3.Text = "Ch3 : U = " + y + " V"; }));

            y = (Convert.ToDouble(data[3]) / 1023) * 5;

            if (osciloscope.Series["Channel4"].Points.Count > maxPoints)
                osciloscope.Series["Channel4"].Points.RemoveAt(0);

            osciloscope.Series["Channel4"].Points.AddXY(x + 1, y);
            osciloscope.ResetAutoValues();

            if (chb_ch4.Checked)
                lb_ch4.Invoke(new MethodInvoker(delegate { lb_ch4.Text = "Ch4 : U = " + y + " V"; }));
        }

        #region CH and A/D controls

        private void rad_ch1Analog_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel1"].ChartType = SeriesChartType.Spline;
        }

        private void rad_ch1Digital_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel1"].ChartType = SeriesChartType.StepLine;
        }

        private void rad_ch2Analog_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel2"].ChartType = SeriesChartType.Spline;
        }

        private void rad_ch2Digital_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel2"].ChartType = SeriesChartType.StepLine;
        }

        private void rad_ch3Analog_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel3"].ChartType = SeriesChartType.Spline;
        }

        private void rad_ch3Digital_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel3"].ChartType = SeriesChartType.StepLine;
        }

        private void rad_ch4Analog_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel4"].ChartType = SeriesChartType.Spline;
        }

        private void rad_ch4Digital_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                osciloscope.Series["Channel4"].ChartType = SeriesChartType.StepLine;
        }

        private void chb_ch1_CheckedChanged(object sender, EventArgs e)
        {
            osciloscope.Series["Channel1"].Enabled = ((CheckBox)sender).Checked;
            lb_ch1.Enabled = ((CheckBox)sender).Checked;
        }

        private void chb_ch2_CheckedChanged(object sender, EventArgs e)
        {
            osciloscope.Series["Channel2"].Enabled = ((CheckBox)sender).Checked;
            lb_ch2.Enabled = ((CheckBox)sender).Checked;
        }

        private void chb_ch3_CheckedChanged(object sender, EventArgs e)
        {
            osciloscope.Series["Channel3"].Enabled = ((CheckBox)sender).Checked;
            lb_ch3.Enabled = ((CheckBox)sender).Checked;
        }

        private void chb_ch4_CheckedChanged(object sender, EventArgs e)
        {
            osciloscope.Series["Channel4"].Enabled = ((CheckBox)sender).Checked;
            lb_ch4.Enabled = ((CheckBox)sender).Checked;
        }

        #endregion

        int maxPoints = 20;
        string rawData = String.Empty;
        string[] data = new string[4];

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                rawData = serialPort1.ReadLine();
                rawData = rawData.Substring(0, rawData.Length - 1);

                data = rawData.Split(';');

                string temp = String.Empty;

                foreach (string s in data)
                    temp += s + "\n";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            osciloscope.Size = new Size(this.Size.Width - panel_main.Width - 10, osciloscope.Height);
            panel_main.Size = new Size(panel_main.Width, this.Height - 10);
            panel_chControls.Size = new Size(panel_chControls.Width, panel_main.Height - btn_start.Height - 15);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}