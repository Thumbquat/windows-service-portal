﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteServiceManager.Models
{
    public interface IMachines
    {
        List<IMachine> MachineList { get; set; }
    }
}
