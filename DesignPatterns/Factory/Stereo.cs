﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Stereo : IElectronicDevice
    {
        public bool batteries {get;}

        public Stereo() {
            batteries = false;
        }

    }
}
