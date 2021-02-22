using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Application.Interfaces.Factory
{
    interface ITradeFactory
    {
        string ReturnRisk(ITrade trade);
    }
}
