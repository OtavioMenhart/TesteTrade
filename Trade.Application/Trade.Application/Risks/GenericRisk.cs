using System;
using System.Collections.Generic;
using System.Text;
using Trade.Application.Interfaces;

namespace Trade.Application.Risks
{
    abstract class GenericRisk
    {
        public string NameRisk { get; private set; }
        public bool IsValid { get; protected set; }
        public abstract bool Validation(ITrade trade);

        protected GenericRisk(string nameRisk)
        {
            NameRisk = nameRisk;
        }
    }
}
