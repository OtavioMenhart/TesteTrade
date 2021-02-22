using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Factory;
using Trade.Application.Interfaces;
using Trade.Application.Risks;

namespace Trade.Application.Implementations
{
    class TradeRiskFactory : TradeFactory
    {
        public override string ReturnRisk(ITrade trade)
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
