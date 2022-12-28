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
using System.Collections; // 컬렉션 네임스페이스
using System.Collections.Generic;


namespace ConsoleGame
{
    class Shop
    {
        public virtual void Punchase()
        {
            Console.WriteLine("구매");
        }

        public virtual void Sale()
        {
            Console.WriteLine("판매");
        }
    }

    class EquipmentShop : Shop
    {
        public override void Punchase()
        {
            Console.WriteLine("장비 구매");
        }

        public override void Sale()
        {
            Console.WriteLine("장비 판매");
        }
    }

    class CashShop : Shop
    {
        public override void Punchase()
        {
            Console.WriteLine("캐쉬 구매");
        }

        public sealed override void Sale()
        {
            Console.WriteLine("캐쉬 판매");
        }

    }

    class EventShop : CashShop
    {
        public override void Punchase()
        {
            Console.WriteLine("이벤트 구매");
        }

        // CashShop 을 상속 받아도 
        // Sale 은 sealed 를 사용해서 재정의 불가능 하다.

        // public sealed override void Sale()
        // {
        //    Console.WriteLine("캐쉬 판매");
        // }
    }

    internal class Program
    {


    static void Main(string[] args)
    {
            // sealed
            // 클래스 또는 메소드가 다른 클래스에 상속되지 않도록
            // 막아주는 키워드이다.

            EventShop eventShop = new EventShop();
            eventShop.Punchase();
            eventShop.Sale();
     }

    }
}