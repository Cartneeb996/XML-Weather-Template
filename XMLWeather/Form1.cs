using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();
            for (int x = 0; x< 7; x++)
            {
                days.Add(new Day());
            }
            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractCurrent()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {             
                if(reader.NodeType == XmlNodeType.Text)
                {
                    days[0].location = reader.ReadString();
                    reader.ReadToFollowing("sun");
                    days[0].sunSet = reader.GetAttribute("set");
                    days[0].sunRise = reader.GetAttribute("rise");
                    reader.ReadToFollowing("time");
                    days[0].date = reader.GetAttribute("day");
                    reader.ReadToFollowing("symbol");
                    days[0].condVal = Convert.ToInt16(reader.GetAttribute("number"));
                    //days[x].currentTime = reader.ReadString();
                    reader.ReadToFollowing("precipitation");
                    days[0].condition = reader.GetAttribute("type");
                    days[0].precipitation = reader.GetAttribute("value");
                    reader.ReadToNextSibling("windDirection");
                    days[0].windDirection = reader.GetAttribute("name");
                    reader.ReadToFollowing("windSpeed");
                    days[0].windSpeed = reader.GetAttribute("mps");
                    reader.ReadToNextSibling("temperature");
                    days[0].currentTemp = reader.GetAttribute("day");
                    days[0].tempHigh = reader.GetAttribute("max");
                    days[0].tempLow = reader.GetAttribute("min");
                    Form1.days[0].sunRise = Convert.ToString(Convert.ToDateTime(Form1.days[0].sunRise).Subtract(new DateTime(1, 1, 1, 4, 1, 0, DateTimeKind.Unspecified))).Remove(0, 7);
                    Form1.days[0].sunSet = Convert.ToString(Convert.ToDateTime(Form1.days[0].sunSet).Subtract(new DateTime(1, 1, 1, 4, 1, 0, DateTimeKind.Unspecified))).Remove(0, 7);
                    Form1.days[0].currentTemp = Convert.ToString(Convert.ToInt16(Convert.ToDouble(Form1.days[0].currentTemp))) + "°C";
                    Form1.days[0].tempHigh = Convert.ToString(Convert.ToInt16(Convert.ToDouble(Form1.days[0].tempHigh))) + "°C";
                    Form1.days[0].tempLow = Convert.ToString(Convert.ToInt16(Convert.ToDouble(Form1.days[0].tempLow))) + "°C";
                }
            }

            reader.Close();
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            for (int x = 0; x < 7; x++)
            {
                reader.ReadToFollowing("time");
                days[x].date = reader.GetAttribute("day");
                reader.ReadToFollowing("symbol");
                days[x].condVal = Convert.ToInt16(reader.GetAttribute("number"));
                days[x].condition = reader.GetAttribute("name");
                reader.ReadToFollowing("precipitation");

                string s = reader.GetAttribute("type");

                if (s != null) days[x].precipitation = reader.GetAttribute("value");

                reader.ReadToFollowing("windDirection");
                days[x].windDirection = reader.GetAttribute("name");
                reader.ReadToFollowing("windSpeed");
                days[x].windSpeed = reader.GetAttribute("mps");
                reader.ReadToFollowing("temperature");
                days[x].currentTemp = reader.GetAttribute("day");
                days[x].tempHigh = reader.GetAttribute("max");
                days[x].tempLow = reader.GetAttribute("min");

                DateTime d = Convert.ToDateTime(Form1.days[x].date);
                Form1.days[x].currentTemp = Convert.ToString(Convert.ToInt16(Convert.ToDouble(Form1.days[x].currentTemp))) + "°C";
                Form1.days[x].tempHigh = Convert.ToString(Convert.ToInt16(Convert.ToDouble(Form1.days[x].tempHigh))) + "°C";
                Form1.days[x].tempLow = Convert.ToString(Convert.ToInt16(Convert.ToDouble(Form1.days[x].tempLow))) + "°C";               
            }

            reader.Close();
        }

    }
}
