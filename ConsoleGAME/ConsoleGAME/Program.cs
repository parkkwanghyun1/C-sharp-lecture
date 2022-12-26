using System;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleGame
{
    class Machine
    {

        // 형식 매개변수란?
        // 함수에 형식을 지정하지 않아도 호출 시
        // 형식만 지정하면 어떤 형식이든 사용할 수 있는 매개변수입니다.

        // 형식 매개변수는 어떤 문자든 가능 
        // 일반적으로 T를 많이 사용한다.
        public void Driving<T>(T x)
        {
            Console.WriteLine($"x의 값 : {x} "); 

        }

        public T Process<T>(T x)
        {
            Console.WriteLine($"x의 값 : {x} ");
            return x;
        }
    }

    class STL<T>
    {
        public void Push<V>(V x)
        {
            Console.WriteLine("Push : " + x);
        }

        public V Pop<V>(V x)
        {
            return x; 
        }
    }
    internal class Program
    {
        
      
    static void Main(string[] args)
        {
            #region 일반화 프로그래밍
            /*
            // 데이터 형식에 의존하지 않고, 하나의 값이
            // 여러 데이터 타입ㅇ들을 가질 수 있는 기술에
            // 중점을 두어 재사용성을 높일 수 있는 프로그래밍 방법이다.

            Machine machine = new Machine();
            machine.Driving(10);
            machine.Driving(5.8346);
            machine.Driving('0');
            machine.Driving("string");

            // 형식 매개변수는 컴파일 시에 자료형을 결정한다
            // 형식 매개변수의 경우 boxing 과 unboxing 이 일어나지 않는다.
            int num1 = machine.Process(300);
            float num2 = machine.Process(20.2f);
            char num3 = machine.Process('w');
            string num4 = machine.Process("strng");
            */

            STL<int> stack = new STL<int>();
            stack.Push(1);
            stack.Push(2.5f);
            stack.Push(1);

            stack.Pop(1);
            stack.Pop(2);
            stack.Pop(3);

            #endregion
        }
    }
}