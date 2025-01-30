using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public class Enum
    {
        public enum Days
        {
            [Description("This is monday")]
            Monday = 10,
            [Description("This is monday")]
            Tuesday, // 1 >> Bipin >> >> 11 >> Yatri
            [Description("This is monday")]
            Wednesday = 20,
            [Description("This is monday")]
            Thursday,
            [Description("This is monday")]
            Friday = 30,
            [Description("This is monday")]
            Saturday,
            [Description("This is monday")]
            Sunday
        }



    }
}
