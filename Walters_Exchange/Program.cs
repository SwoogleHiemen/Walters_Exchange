using System;

namespace Walters_Exchange
{
    //Mason Walters
    //IT 111
    //Dan Hagen
    //E=EURO £=GBP C$=CAN $=USD
    // E is Euro because € this sign doesn't work, it just shows up
    //as a ? when the code runs

    class Program
    {
        static void Main(string[] args)
        {
            int Counter = 0;
            bool quite = false;
            decimal ConvertedMoney;
            decimal TotalMoney = 0;

            do
            {
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("To Exchange currency, press Enter");
                Console.WriteLine("To quite, press any other key");
                 
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    
                }
                else
                {
                    Console.Clear();
                    break;
                }
                string startingCurrency = SelectStartingCurrency();
                string startingCurrencyType = CurrencyType(startingCurrency);
                decimal startingMoneyAmount = StartingMoneyAmount(startingCurrencyType);
                string conversionCurrency = SelectConversionCurrency(startingCurrencyType);
                string conversionCurrencyType = ConversionCurrencyType(conversionCurrency);
                if (startingCurrencyType == "USD" && conversionCurrencyType == "GBP")
                {
                    ConvertedMoney = Exchanger.USD_GBP(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType,conversionCurrencyType,startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is £" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "USD" && conversionCurrencyType == "CAN")
                {
                    ConvertedMoney = Exchanger.USD_CAN(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is C$" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "USD" && conversionCurrencyType == "EUR")
                {
                    ConvertedMoney = Exchanger.USD_EUR(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is E" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "USD" && conversionCurrencyType == "USD")
                {
                    ConvertedMoney = Exchanger.USD_USD(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is $" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "GBP" && conversionCurrencyType == "USD")
                {
                    ConvertedMoney = Exchanger.GBP_USD(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is $" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "GBP" && conversionCurrencyType == "CAN")
                {
                    ConvertedMoney = Exchanger.GBP_CAN(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is C$" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "GBP" && conversionCurrencyType == "EUR")
                {
                    ConvertedMoney = Exchanger.GBP_EUR(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is E" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "GBP" && conversionCurrencyType == "GBP")
                {
                    ConvertedMoney = Exchanger.GBP_GBP(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is £" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "CAN" && conversionCurrencyType == "USD")
                {
                    ConvertedMoney = Exchanger.CAN_USD(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is $" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "CAN" && conversionCurrencyType == "GBP")
                {
                    ConvertedMoney = Exchanger.CAN_GBP(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is £" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "CAN" && conversionCurrencyType == "EUR")
                {
                    ConvertedMoney = Exchanger.CAN_EUR(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is E" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "CAN" && conversionCurrencyType == "CAN")
                {
                    ConvertedMoney = Exchanger.CAN_CAN(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is C$" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "EUR" && conversionCurrencyType == "USD")
                {
                    ConvertedMoney = Exchanger.EUR_USD(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is $" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "EUR" && conversionCurrencyType == "GBP")
                {
                    ConvertedMoney = Exchanger.EUR_GBP(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is £" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "EUR" && conversionCurrencyType == "CAN")
                {
                    ConvertedMoney = Exchanger.EUR_CAN(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is C$" + Exchanger.MoneyFormatter(ConvertedMoney));
                }

                if (startingCurrencyType == "EUR" && conversionCurrencyType == "EUR")
                {
                    ConvertedMoney = Exchanger.EUR_EUR(startingMoneyAmount);
                    TotalMoney = ExchangeMonitor.Exchanges(ConvertedMoney, Counter, startingCurrencyType, conversionCurrencyType, startingMoneyAmount, TotalMoney);
                    Console.WriteLine("your converted money is E" + Exchanger.MoneyFormatter(ConvertedMoney));
                }
                Counter =  ExchangeMonitor.CounterMethod(Counter);


            } while (quite == false);
           //This is where the program Ends
            ExchangeMonitor.EchangeOutcome(TotalMoney, Counter);
            Console.WriteLine("Thank you for using this program. Bye Bye! Press any key to quit...");
            Console.ReadKey();
        }
        //this gets the number of the starting currency they select
        static string SelectStartingCurrency()
        {
            bool Wrong = false;
            string startingCurrency;
            do
            {
                if (Wrong == true)
                {
                    Console.WriteLine("Please pick one of the options...");
                }
                Console.WriteLine("Please pick Which Currency you have.Type the number of the option you would like to choose:");
                Console.WriteLine("USD-1");
                Console.WriteLine("GBP-2");
                Console.WriteLine("CAN-3");
                Console.WriteLine("EUR-4");
                startingCurrency = Console.ReadLine();

                Console.Clear();
                Wrong = true;
            } while (startingCurrency != "1" && startingCurrency != "2" && startingCurrency != "3" && startingCurrency != "4");
            Wrong = false;
            return startingCurrency;
        }
        //this turns that number into the 3 letter abbreviation of the currency they chose for later use
        static string CurrencyType(string startingCurrency)
        {
            string WhichCurrency;

            if (startingCurrency == "1")
            {
                WhichCurrency = "USD";
            }

            else if (startingCurrency == "2")
            {
                WhichCurrency = "GBP";
            }

            else if (startingCurrency == "3")
            {
                WhichCurrency = "CAN";
            }

            else if (startingCurrency == "4")
            {
                WhichCurrency = "EUR";
            }

            else
            {
                WhichCurrency = "N/A";
            }

            return WhichCurrency;
        }
        //this turns that number into a 3 letter abbreviation of the currency they chose for later use
        static decimal StartingMoneyAmount(string startingCurrencyType)
        {
            Console.WriteLine("how much " + startingCurrencyType + " do you have to convert?");
            string TEMPstartingMoneyAmount = Console.ReadLine();
            decimal startingMoneyAmount = decimal.Parse(TEMPstartingMoneyAmount);
            Console.Clear();
            return startingMoneyAmount;
        }
        //this gets the amount of money that they have to convert 
        static string SelectConversionCurrency(string startingCurrencyType)
        {
            Console.WriteLine("What Currency would you like to convert your " + startingCurrencyType + " to. Type the number of the option you would like to choose:");
            Console.WriteLine("USD-1");
            Console.WriteLine("GBP-2");
            Console.WriteLine("CAN-3");
            Console.WriteLine("EUR-4");
            string conversionCurrency = Console.ReadLine();
            Console.Clear();
            return conversionCurrency;
        }
        //this gets the number of the currency they want to convert their money to
        static string ConversionCurrencyType(string conversionCurrency)
        {
            string WhichCurrency;

            if (conversionCurrency == "1")
            {
                WhichCurrency = "USD";
            }

            else if (conversionCurrency == "2")
            {
                WhichCurrency = "GBP";
            }

            else if (conversionCurrency == "3")
            {
                WhichCurrency = "CAN";
            }

            else if (conversionCurrency == "4")
            {
                WhichCurrency = "EUR";
            }

            else
            {
                WhichCurrency = "N/A";
            }

            return WhichCurrency;
        }
      
    }
}
