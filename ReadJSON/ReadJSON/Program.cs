using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadJSON
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Time
    {
        public string obsTime { get; set; }
    }

    public class ElementValue
    {
        public string value { get; set; }
    }

    public class WeatherElement
    {
        public string elementName { get; set; }
        public ElementValue elementValue { get; set; }
    }

    public class Parameter
    {
        public string parameterName { get; set; }
        public string parameterValue { get; set; }
    }

    public class Location
    {
        public string lat { get; set; }
        public string lon { get; set; }
        public string lat_wgs84 { get; set; }
        public string lon_wgs84 { get; set; }
        public string locationName { get; set; }
        public string stationId { get; set; }
        public Time time { get; set; }
        public List<WeatherElement> weatherElement { get; set; }
        public List<Parameter> parameter { get; set; }
    }

    public class Cwbopendata
    {
        public string @xmlns { get; set; }
        public string identifier { get; set; }
        public string sender { get; set; }
        public string sent { get; set; }
        public string status { get; set; }
        public string msgType { get; set; }
        public string dataid { get; set; }
        public string scope { get; set; }
        public string dataset { get; set; }
        public List<Location> location { get; set; }
    }

    public class RootObject
    {
        public Cwbopendata cwbopendata { get; set; }
    }

}
