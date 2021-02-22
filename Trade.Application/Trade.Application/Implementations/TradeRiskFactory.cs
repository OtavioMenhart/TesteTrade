using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Interfaces;
using Trade.Application.Interfaces.Factory;
using Trade.Application.Risks;

namespace Trade.Application.Implementations
{
    class TradeRiskFactory : ITradeFactory
    {
        public string ReturnRisk(ITrade trade)
        {
            LowRisk lowRisk = new LowRisk();
            MediumRisk mediumRisk = new MediumRisk();
            HighRisk highRisk = new HighRisk();

            if (lowRisk.Validation(trade))
                return lowRisk.NameRisk;

            if (mediumRisk.Validation(trade))
                return mediumRisk.NameRisk;

            if (highRisk.Validation(trade))
                return highRisk.NameRisk;

            return "UNDEFINEDRISK";

        }
    }
}
