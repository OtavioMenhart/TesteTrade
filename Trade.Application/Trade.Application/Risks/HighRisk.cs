using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Interfaces;

namespace Trade.Application.Risks
{
    class HighRisk : GenericRisk
    {
        public HighRisk() : base("HIGHRISK")
        {
        }

        public override bool Validation(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Private")
                IsValid = true;
            else
                IsValid = false;

            return IsValid;
        }
    }
}
