using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Interfaces;

namespace Trade.Application.Implementations
{
    class TradeImplementation : ITrade
    {
        public TradeImplementation(double value, string clientSector)
        {
            Value = value;
            ClientSector = clientSector;
        }

        public double Value { get ; set ; }
        public string ClientSector { get ; set ; }
    }
}
