﻿namespace 델리게이트
{
    class Watch
    {
        // readonly : 런타임 시점에 결정되는 상수 
        // 상수를 초기화 하지 않아도 사용할 수 있다.
        readonly int count = 50;

        public Watch() // 생성자
        {
            // 생성자에서 단 한번만 값을 초기화 할 수 있다.
            count = 100;
            Console.WriteLine("count의 값 : " + count);
        }

    }

    // 델리게이트 선언
    // delegate [반환형] [델리게이트 이름] (매개변수)
    delegate void Calculator(int x, int y);

    // 델리게이트는 메소드의 반환형과 매개 변수의 타입이 일치해야 한다.
    class Weapon
    {
        public void Stat(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("stat 메소드 " + result);
        }

        public void Price(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Price 메소드 " + result);
        }

        public void Dmage(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Damage 메소드 " + result);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            #region 상수
            /*
            // 프로그램이 실행되는 동안 변하지 않는 값 

            // const : 컴파일 시점에 결정되는 상수
            // 상수를 선언과 동시에 초기화를 해주어야 한다.

            // pi = 3.14  
            // gravity = 9.61 과 같이 불변의 값 을 선언 할 때 const 로 
            // const int dat = 10;
            // 컴파일 할 때 const 값이 바뀌게 되면 재컴파일 하게 된다.
            const int value = 10;

            Console.WriteLine("value 의 값 : " + value);

            Watch watch = new Watch();
            */
            #endregion

            #region 델리게이트(대리자)
            /*
             // 매서드를 대신해서 호출하는 기법이다.

             Weapon weapon = new Weapon();

             // 델리게이트 정의 
             Calculator calculator;

             // 델리게이트 변수에 Stat 의 주소를 저장한다.
             calculator = weapon.Stat;

             calculator(10, 20);

             calculator = weapon.Price;

             calculator(13, 40);

             calculator = weapon.Dmage;

             calculator(13, 40);
            */
            #endregion

            //델리게이트 체인
            // 하나의 델리게이트에 여러 개의 메소드를 연결시키는 기법이다.

            Weapon weapon = new Weapon();

            Calculator calculator;

            // 델리게이트 비어있는 상태에서 메소드를 추가할 수 없다.
            calculator = weapon.Stat;
            calculator += weapon.Price;
            calculator += weapon.Dmage;

            calculator(10, 20);

            // 델리게이트에 등록된 메소드를 뺀다.
            calculator -= weapon.Dmage;

            calculator(10, 23);

        }
    }
}