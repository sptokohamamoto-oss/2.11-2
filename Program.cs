
using System;

class Program

{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        { 

            switch(number)
            {

                case 1:
                    Console.WriteLine("月曜日");
                    break;
                case 2:
                    Console.WriteLine("火曜日");
                    break;
                case 3:
                    Console.WriteLine("水曜日");
                    break;
                case 4:
                    Console.WriteLine("木曜日");
                    break;
                case 5:
                    Console.WriteLine("金曜日");
                    break;
                case 6:
                    Console.WriteLine("土曜日");
                    break;
                case 7:
                    Console.WriteLine("日曜日");
                    break;
                default:
                    Console.WriteLine("不正な入力です");
                    break;
            }


        }
    }
}

