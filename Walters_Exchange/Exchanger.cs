using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Exchange
{
    class Exchanger
    {
        public static decimal MoneyFormatter(decimal ConvertedMoney)
        {
          return Math.Round(ConvertedMoney, 2);
            
        }
        public static decimal TotalMoneyFormatter(decimal TotalMoney)
        {
            return Math.Round(TotalMoney, 2);

        }
        public static decimal USD_GBP(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1.37887M;
            return Money;
            
        }
        public static decimal USD_CAN(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * .79728M;
            return Money;
        }
        public static decimal USD_EUR(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1.19648M;
            return Money;
        }
        public static decimal USD_USD(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1M;
            return Money;
        }
        public static decimal GBP_USD(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * .72523M;
            return Money;
        }
        public static decimal GBP_CAN(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * .57848M;
            return Money;
        }
        public static decimal GBP_EUR(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * .86826M;
            return Money;
        }
        public static decimal GBP_GBP(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1M;
            return Money;
        }
        public static decimal CAN_USD(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1.25427M;
            return Money;
        }
        public static decimal CAN_GBP(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1.72947M;
            return Money;
        }
        public static decimal CAN_EUR(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1.50040M;
            return Money;
        }
        public static decimal CAN_CAN(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1M;
            return Money;
        }
        public static decimal EUR_USD(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * .83572M;
            return Money;
        }
        public static decimal EUR_GBP(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1.15195M;
            return Money;
        }
        public static decimal EUR_CAN(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * .66645M;
            return Money;
        }
        public static decimal EUR_EUR(decimal startingMoneyAmount)
        {
            decimal Money = startingMoneyAmount * 1M;
            return Money;
        }
    }
    
}
