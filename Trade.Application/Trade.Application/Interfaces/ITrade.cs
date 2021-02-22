using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Application.Interfaces
{
    interface ITrade
    {
        double Value { get; set; }
        string ClientSector { get; set; }
    }
}
