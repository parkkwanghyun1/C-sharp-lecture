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
    // 추상 클래스 선언 
    abstract class Equipment
    {
        abstract public void Effect();

        public void Durability(int value)
        {
            Console.WriteLine("내구도 : " + value);

        }


    }

    class Weapon : Equipment
    {
        public override void Effect()
        {
            Console.WriteLine("공격력 증가");
        }

        new public void Durability(int value)
        {
            Console.WriteLine("내구도 : " + value);

        }
    }

    class Shield : Equipment
    {
        public override void Effect()
        {
            Console.WriteLine("방어력 증가");
        }
    }

    delegate void CallBack();

    internal class Program
    {
        static void Button(CallBack callBack)
        {
            callBack();
        }

        static void UserInterface()
        {
            Console.WriteLine("Character Stat Window0");
        }
    static void Main(string[] args)
        {
            #region 추상 클래스란
            /*
            // 하나 이상의 추상 메소드를 포함하고 있는 클래스이다.
            // 추상 클래스는 인스턴스로 생성할 수 없다.
            // c++ = 순수 가상함수와 동일 (void function() = 0;)

            Weapon weapon = new Weapon();
            weapon.Effect();
            weapon.Durability(100);

            // 추상 클래스는 다중 상속이 안된다.
            Shield shield = new Shield();
            shield.Effect();
            */
            #endregion


            // string name;

            // name = Console.ReadLine();

            // Console.WriteLine("name : " + name);

            // string Format( )
            // 지정된 형식에 따라 개체의 값을 문자열로 변환하여 다른 문자열에 
            // 삽입하는 메서드이다.

            //(첨자, 맞춤 : 서식 문자열}
            // string data = string.Format("{0} ,{1}, {2}", 10, 5.59, 'A');
            // Console.WriteLine(data);

            // 문자열 보간
            //int damage = 10;
            //int critical = 33;

            //Console.WriteLine($"{damage} + {critical} = {damage + critical}");

            // 콜백 함수
            // 다른 함수의 인수로써 넘겨진 후 특정 이벤트에 의해 호출되는 함수
            // 시스템에 의해 호출 시점이 결정된다

            Button(UserInterface);


        }
    }
}