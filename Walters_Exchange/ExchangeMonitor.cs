 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Exchange
{
    class ExchangeMonitor
    {
        public static void EchangeOutcome(decimal TotalMoney, int Counter)
        {
            Console.WriteLine("Your total Money Exchanged in USD is $" + Exchanger.TotalMoneyFormatter(TotalMoney) + ", and you made " + Counter + " Exchanges.") ;
            //this is where the final results will go for this class, then this method
            // should be put at the end of the main class after the user presses "q"
        }
        public static int CounterMethod(int Counter)
        {
            Counter++;
            return Counter;
        }
        
        public static decimal Exchanges(decimal ConvertedMoney, int Counter, string startingCurrencyType, string conversionCurrencyType, decimal startingMoneyAmount,decimal TotalMoney)
        {
            
            if (startingCurrencyType == "USD" && conversionCurrencyType == "GBP")
            {
                TotalMoney = startingMoneyAmount + TotalMoney;
                return TotalMoney;
            }
            if(startingCurrencyType == "USD" && conversionCurrencyType == "CAN")
            {
                TotalMoney = startingMoneyAmount + TotalMoney;
                return TotalMoney;
            }
            if (startingCurrencyType == "USD" && conversionCurrencyType == "EUR")
            {
                TotalMoney = startingMoneyAmount + TotalMoney;
                return TotalMoney;
            }
            if (startingCurrencyType == "USD" && conversionCurrencyType == "USD")
            {
                TotalMoney = startingMoneyAmount + TotalMoney;
                return TotalMoney;
            }
            if (startingCurrencyType == "GBP" && conversionCurrencyType == "USD")
            {
                TotalMoney = ConvertedMoney + TotalMoney;
                return TotalMoney;
            }
            if (startingCurrencyType == "GBP" && conversionCurrencyType == "CAN")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * 1.25427M);
                return TotalMoney;
            }
            if (startingCurrencyType == "GBP" && conversionCurrencyType == "EUR")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * .83572M);
                return TotalMoney;
            }
            if (startingCurrencyType == "GBP" && conversionCurrencyType == "GBP")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * .72523M);
                return TotalMoney;
            }
            if (startingCurrencyType == "CAN" && conversionCurrencyType == "USD")
            {
                TotalMoney = ConvertedMoney + TotalMoney;
                return TotalMoney;
            }
            if (startingCurrencyType == "CAN" && conversionCurrencyType == "GBP")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * .72523M);
                return TotalMoney;
            }
            if (startingCurrencyType == "CAN" && conversionCurrencyType == "EUR")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * .83572M);
                return TotalMoney;
            }
            if (startingCurrencyType == "CAN" && conversionCurrencyType == "CAN")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * 1.25427M);
                return TotalMoney;
            }
            if (startingCurrencyType == "EUR" && conversionCurrencyType == "USD")
            {
                TotalMoney = ConvertedMoney + TotalMoney;
                return TotalMoney;
            }
            if (startingCurrencyType == "EUR" && conversionCurrencyType == "GBP")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * .72523M);
                return TotalMoney;
            }
            if (startingCurrencyType == "EUR" && conversionCurrencyType == "CAN")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * 1.25427M);
                return TotalMoney;
            }
            if (startingCurrencyType == "EUR" && conversionCurrencyType == "EUR")
            {
                TotalMoney = TotalMoney + (ConvertedMoney * .83572M);
                return TotalMoney;
            }
            else
            {
                return TotalMoney;
            }
        }
    }
}
