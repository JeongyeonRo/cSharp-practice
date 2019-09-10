using System;

namespace ConsoleApp0910
{
    class Program
    {
        static void Main(string[] args)
        {
            //c#의 변수 선언
            short shortNum = 0;
            int intNum = 0;
            double doubleNum = 0;
            float floarNum = 0;
            //string 대소문자 주의
            string stringText = "";
            char charText = 'a';
            bool boolVal = true;


            //.Net 프레임워크에서의 변수 선언
            Int16 dotNetShort = 0;
            Int32 dotNetInt = 0;
            Int64 dotNetDouble = 0;
            String dotNetString = "";


            var dynamicType = 0;
            //위와 같은 방법으로 사용하면 C# 컴파일러가 자동으로 변수 타입을 인식


            var num1 = 1;
            var num2 = 2;
            Console.WriteLine(num1 + num2);
            

        }
    }
}
