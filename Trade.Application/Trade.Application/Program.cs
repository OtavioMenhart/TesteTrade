using System;
using System.Collections.Generic;
using Trade.Application.Implementations;
using Trade.Application.Interfaces;

namespace Trade.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ITrade trade1 = new TradeImplementation(2000000, "Private");
            ITrade trade2 = new TradeImplementation(400000, "Public");
            ITrade trade3 = new TradeImplementation(500000, "Public");
            ITrade trade4 = new TradeImplementation(3000000, "Public");

            List<ITrade> portfolio = new List<ITrade>();
            portfolio.Add(trade1);
            portfolio.Add(trade2);
            portfolio.Add(trade3);
            portfolio.Add(trade4);

            List<string> tradeCategories = new List<string>();
            TradeRiskFactory tradeRiskFactory = new TradeRiskFactory();

            foreach (ITrade port in portfolio)
            {
                string risk = tradeRiskFactory.ReturnRisk(port);
                Console.WriteLine(risk);
                tradeCategories.Add(risk);
            }

            Console.WriteLine("Finalizado, pressione qualquer letra para sair");
            Console.ReadKey();
        }
    }
}
