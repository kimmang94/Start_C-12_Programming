using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정수형 기본 타입
            int n1 = 50; // 선언과 동시에 값을 부여할 수도 있고
            int n2; // 선언만 하고
            n2 = 100; // 값은 나중에 부여하는 것도 가능하다

            long sum = n1 + n2; // 더한 값을 저장
            Console.WriteLine(sum); // 출력 결과 150

            int n3 = 50;
            n3 = 200;
            Console.WriteLine(n3); // 출력 결과 : 200

            System.Int32 n4 = 50;
            Console.WriteLine(n4);

            // 실수형 기본 타입
            float f = 5.2f;
            double d = 10.5;
            decimal money = 200.099m;

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(money);

            // 문자형 기본 타입
            char ch = 'A';
            Console.WriteLine(ch);

            char ch1 = '\t'; // Tab 문자를 표현
            char ch2 = 'T';
            char ch3 = '\n'; // 개행(New Line) 문자를 표현
            char ch4 = 'o';

            char ch5 = '\u25b6';
            Console.WriteLine(ch);

            // 문자열 타입
            string text = "Hello World";
            Console.WriteLine(text);

            // 불린(boolean)형 기본타입
            bool isNumeric = false;


            // 형변환
            byte b = 250;
            short s = b;

            Console.WriteLine(s);
            Console.WriteLine(s.GetType());
        }
    }
}
