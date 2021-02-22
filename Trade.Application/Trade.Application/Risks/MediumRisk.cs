using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Interfaces;

namespace Trade.Application.Risks
{
    class MediumRisk : GenericRisk
    {
        public MediumRisk() : base("MEDIUMRISK")
        {
        }

        public override bool Validation(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Public")
                IsValid = true;
            else
                IsValid = false;

            return IsValid;
        }
    }
}
