using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataProject
{
    internal class LineData
    {
        /* "id":"SEM:1696","name":"Grenoble, Chavant","lon":5.73233,"lat":45.18502,"zone":"SEM_GENCHAVANT","lines":["SEM:13","SEM:C4" */
        public int id;
        public string name;
        public double lon;
        public double lat;
        public string zone;
        public string lines;
        public LineData(int id, string name, double lon, double lat, string zone, string lines)
        {
            this.id = id;
            this.name = name;
            this.lon = lon;
            this.lat = lat;
            this.zone = zone;
            this.lines = lines;
        }
    }
}
