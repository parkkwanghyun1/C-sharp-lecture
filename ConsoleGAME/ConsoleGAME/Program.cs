using System;
using System.Runtime.InteropServices;

namespace ConsoleGame
{
    internal class Program
    {
        // stacic void main (string [] args)
        // 프로그램 실행되는 진입점
        // Main() 함수 안에서 실행해야 프로그램이 실행된다.
        static void Main(string[] args)
        {
            // Console.WriteLine(); <- 문자열을 출력하는 함수
            // Console.WriteLine에서 문자열을 연결할려면 + 로 연결하면 된다.

            Console.WriteLine("안녕하세요" + "박광현 입니다");
            Console.WriteLine("유니티를 배우고 싶습니다");

            // Console.Write() 함수는 개행을 하지않고, 출력하는 함수
            //값 타입 

            bool check = true; // 1byte
            byte bit = 1; // 1byte
            char alphabet = 'A';  //1byte 
            short data = 10; // 2byte
            ushort uData = 22; // 2byte 양수값만 표현할 수 있는 자료형
            int integer = 300; // 4byte 
            uint uInteger = 200; // 4byte 양수 값만 표현할 수 있다.
            long signal = 15; // 4byte

            float sing = 15.5f; // 4byte
            double count = 176.8; // 8byte
            decimal value = 3058; // 16byte 

            Console.Write("오우");
            Console.Write(100);
        }
    }
}