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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            
            //Form1.days[1].date = d.DayOfWeek.ToString();
            for (int x = 1; x < 4; x++)
            {
                
            }
           
            locationLabel.Text = Form1.days[0].location;

            day1CurrentOut.Text = Form1.days[1].currentTemp;
            day2CurrentOut.Text = Form1.days[2].currentTemp;
            day3CurrentOut.Text = Form1.days[3].currentTemp;
            min1.Text = Form1.days[1].tempLow;
            min2.Text = Form1.days[2].tempLow;
            min3.Text = Form1.days[3].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            max2.Text = Form1.days[2].tempHigh;
            max3.Text = Form1.days[3].tempHigh;
            day1Out.Text = Convert.ToDateTime(Form1.days[1].date).DayOfWeek.ToString();
            day2Out.Text = Convert.ToDateTime(Form1.days[2].date).DayOfWeek.ToString();
            day3Out.Text = Convert.ToDateTime(Form1.days[3].date).DayOfWeek.ToString();

            if (Form1.days[1].condVal >= 200 && Form1.days[1].condVal < 300) day1Cond.BackgroundImage = Properties.Resources.Storm;
            else if (Form1.days[1].condVal >= 300 && Form1.days[1].condVal < 600) day1Cond.BackgroundImage = Properties.Resources.rain;
            else if (Form1.days[1].condVal >= 600 && Form1.days[1].condVal < 700) day1Cond.BackgroundImage = Properties.Resources.snow;
            else if (Form1.days[1].condVal == 800) day1Cond.BackgroundImage = Properties.Resources.Sunny;
            else if (Form1.days[1].condVal == 801) day1Cond.BackgroundImage = Properties.Resources.CloudySunny;
            else if (Form1.days[1].condVal >= 802 && Form1.days[1].condVal < 805) day1Cond.BackgroundImage = Properties.Resources.cloudy;

            if (Form1.days[2].condVal >= 200 && Form1.days[2].condVal < 300) day2Cond.BackgroundImage = Properties.Resources.Storm;
            else if (Form1.days[2].condVal >= 300 && Form1.days[2].condVal < 600) day2Cond.BackgroundImage = Properties.Resources.rain;
            else if (Form1.days[2].condVal >= 600 && Form1.days[2].condVal < 700) day2Cond.BackgroundImage = Properties.Resources.snow;
            else if (Form1.days[2].condVal == 800) day2Cond.BackgroundImage = Properties.Resources.Sunny;
            else if (Form1.days[2].condVal == 801) day2Cond.BackgroundImage = Properties.Resources.CloudySunny;
            else if (Form1.days[2].condVal >= 802 && Form1.days[2].condVal < 805) day2Cond.BackgroundImage = Properties.Resources.cloudy;

            if (Form1.days[3].condVal >= 200 && Form1.days[3].condVal < 300) day3Cond.BackgroundImage = Properties.Resources.Storm;
            else if (Form1.days[3].condVal >= 300 && Form1.days[3].condVal < 600) day3Cond.BackgroundImage = Properties.Resources.rain;
            else if (Form1.days[3].condVal >= 600 && Form1.days[3].condVal < 700) day3Cond.BackgroundImage = Properties.Resources.snow;
            else if (Form1.days[3].condVal == 800) day3Cond.BackgroundImage = Properties.Resources.Sunny;
            else if (Form1.days[3].condVal == 801) day3Cond.BackgroundImage = Properties.Resources.CloudySunny;
            else if (Form1.days[3].condVal >= 802 && Form1.days[3].condVal < 805) day3Cond.BackgroundImage = Properties.Resources.cloudy;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
