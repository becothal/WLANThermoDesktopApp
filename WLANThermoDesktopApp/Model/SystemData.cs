﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLANThermoDesktopApp.Model
{
    class SystemData
    {
        public long time { get; set; }
        public char unit { get; set; }
        public int soc { get; set; }
        public bool charge { get; set; }
        public int rssi { get; set; }
        public int online { get; set; }
    }
}
