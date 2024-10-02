using System;
namespace TypeConversionExample
{

    class Program
    {

        static void Main(string[] args)
        {

            string strNum = "123";

            int.Parse(strNum);

            bool result = int.TryParse(strNum, out int num);

        }


    }
}