using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Interfaces;

namespace Trade.Application.Factory
{
    abstract class TradeFactory
    {
        public abstract string ReturnRisk(ITrade trade);
    }
}
