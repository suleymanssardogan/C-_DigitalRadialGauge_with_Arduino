using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Library for connection with port
using System.IO.Ports;
using Syncfusion.Pdf.Interactive;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //İnstroduction int and bool value
        private bool buttonPress = false;

        private int radialValue = 0;
        //Instroduction string data
        private String data;

        public Form1()
        {
            InitializeComponent();
            //Trackbar max limit
            trackBar1.Maximum = 120;
            //İncoming information from trackbar send to textboxt text
           
        }
        
        
        //Trackbar scrool function
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            //assigment trackbar value to radialGauge value
           radialGauge1.Value = trackBar1.Value;
            //assigment trackbar valuet to  textbox text
            textBox1.Text = trackBar1.Value.ToString();
            //assigment trackbar value to progresbar value
            progressBar1.Value = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxBataryaSıcaklığı.ReadOnly = true;

            //ınstroduction for ports and it gets port names who connects to pc
            string[] ports = SerialPort.GetPortNames();
            // I add port to comobobox with foreach loop
            foreach(string port in ports) 
            { 

                comboBoxConnection.Items.Add(port);
                
            }
            //İncoming data from arduino 
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //read data and assigment to data

            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displaydata));
        }
        //Display data function
        private void displaydata(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(data) && data.Contains("/"))
            {
                string[] deger = data.Split('/');
                if (deger.Length == 2 && int.TryParse(deger[0], out int value1) && int.TryParse(deger[1], out int value2))
                {
                    radialGauge1.Value = value1;
                    radialGauge2.Value = value2;
                    digitalGauge1.Value = data;
                    textBoxBataryaSıcaklığı.Clear();
                    textBoxBataryaSıcaklığı.Text += value1;
                    textBox2.Clear();
                    textBox2.Text += value2;
                }
                else
                {
                    // Data is not in expected format, error handling code can go here
                    MessageBox.Show("Gelen veri beklenen formatta değil.", "Hata");
                }
            }
            else
            {
                // There is something unexpected in the incoming data, error handling code can go here
                MessageBox.Show("Gelen veri boş veya beklenmeyen formatta.", "Hata");
            }

            // İncoming 2 data seperate You can use this code but it is not very effective

            //string[] deger = data.Split('/');
            //radialGauge1.Value = Convert.ToInt32(deger[0]);
            //radialGauge2.Value = Convert.ToInt32(deger[1]);

            ///*if (Convert.ToInt16(data) < 80) {Sy
            //    radialGauge2.Value = Convert.ToInt16(data);

            //}*/

            //digitalGauge1.Value = data;
            ////progressBar2.Value = Convert.ToInt32(data);
            //textBoxBataryaSıcaklığı.Clear();
            //textBoxBataryaSıcaklığı.Text += data;

        }

        //private void button1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    //if we don't touch button buttonPress assigment false value
        //    buttonPress = false;

        //    while (radialValue > 0)
        //    {
        //        radialValue--;

        //        radialGauge1.Value = radialValue;
        //        progressBar1.Value = radialValue;

        //        //System.Threading.Thread.Sleep(10);
        //    }
        //}

        //private async void button1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    //if we hold mouse on button buttonpres== true
        //    buttonPress = true;

        //    while(buttonPress)
        //    {
        //        //Every second radialgauge value is incerasing
        //        radialValue++;

        //        radialGauge1.Value = radialValue;

        //        progressBar1.Value = radialValue;
        //        //if dont keep  hand from button value incereas slowly

        //        await Task.Delay(10);
        //    }
        //}

        

       
        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                //There is a any com name assigment to combobox
                serialPort1.PortName = comboBoxConnection.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                buttonBaglan.Enabled = false;
                buttonDisconnect.Enabled = true;   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            buttonDisconnect.Enabled = false;
            buttonBaglan.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if button2 click or kaydetbutton incoming data will record textfile
            try
            {
                string filelocation = @"C:\Users\Süleyman Sardoğan\OneDrive\Masaüstü\data2.txt";
                string filename = "data.txt";
                System.IO.File.WriteAllText(filelocation + filename,"Zaman\t\t\tDeğer\n"+textBoxBataryaSıcaklığı.Text);
              

                MessageBox.Show("Dosya oluşuturuldu");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Hata");
                
            }

        }
       
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if(serialPort1.IsOpen)
               serialPort1.Close();
        }

        private void radialGauge2_RightToLeftChanged(object sender, EventArgs e)
        {

           if (Convert.ToInt16(data) >= 80)
            {
                radialGauge2.Value = 80;

            }
        }

       

       
    }
}
