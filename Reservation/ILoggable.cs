﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public interface ILoggable
    {
        LogMessage LogMessage { get; }
    }
}
