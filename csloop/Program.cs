using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복함");

            /*
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }*/

            // 문자열 자르기 예제
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }

            // 배열을 문자열로 변환
            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));

            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
        }
    }
}
