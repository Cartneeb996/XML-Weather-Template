using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {

            DateTime d = Convert.ToDateTime(Form1.days[0].date);
            string s = "th";
            if (d.Day == 1 || d.Day == 21 || d.Day == 31) s = "st";
            else if (d.Day == 2 || d.Day == 22) s = "nd";
            else if (d.Day == 3 || d.Day == 23) s = "rd";
            dateLabel.Text = d.DayOfWeek.ToString() + "\nthe " + d.Day + s;         
            
            System.Console.WriteLine(Form1.days[0].sunRise);
            cityOutput.Text = Form1.days[0].location;
            currentTemp.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
           
            currentOutput.Text = Form1.days[0].currentTemp;
            sunRiseOut.Text = Form1.days[0].sunRise;
            sunSetOut.Text = Form1.days[0].sunSet;
            windDirectionOut.Text = Form1.days[0].windDirection;
            windSpeedOut.Text = Form1.days[0].windSpeed + " m/s";
            
            if (Form1.days[0].condVal >= 200 && Form1.days[0].condVal < 300) weatherSymbol.BackgroundImage = Properties.Resources.Storm;
            else if (Form1.days[0].condVal >= 300 && Form1.days[0].condVal < 600) weatherSymbol.BackgroundImage = Properties.Resources.rain;
            else if (Form1.days[0].condVal >= 600 && Form1.days[0].condVal < 700) weatherSymbol.BackgroundImage = Properties.Resources.snow;
            else if (Form1.days[0].condVal == 800) weatherSymbol.BackgroundImage = Properties.Resources.Sunny;
            else if (Form1.days[0].condVal == 801) weatherSymbol.BackgroundImage = Properties.Resources.CloudySunny;
            else if (Form1.days[0].condVal >= 802 && Form1.days[0].condVal < 805) weatherSymbol.BackgroundImage = Properties.Resources.cloudy;
            
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }    
    }
}
