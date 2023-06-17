using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConvert
{
    class DateTimeConvert
    {
        public static string bettertime(string CreatedAt)
        {
            string[] tempSplit = CreatedAt.Split('T');
            string[] timerearange = tempSplit[1].Split('.');
            return timerearange[0];
        }
        public static string betterdate(string CreatedAt)
        {
            string[] tempSplit = CreatedAt.Split('T');
            string[] datarearange = tempSplit[0].Split('-');
            return datarearange[2] + "-" + datarearange[1] + "-" + datarearange[0];
        }
    }
}
