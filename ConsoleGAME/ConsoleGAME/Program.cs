using System;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleGame
{

    delegate void Delegate();

    class IPhone
    {
        public int price;
        public int version;

        // 얕은 복사 
        /*
        public IPhone(int price, int version)
        {
            this.price = price;
            this.version = version;
        }
        */

        // 깊은 복사

        public IPhone DeepCopy()
        {
            IPhone newIPhone = new IPhone();
            newIPhone.price = this.price;
            newIPhone.version = this.version;

            return newIPhone;
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region 무명 형식이란?
            /*
            // 이름이 없는 데이터 형식이다.

            // 임시 변수가 필요할 때 사용하는 형식이다.
            // 임시 변수 : 임시로 생성해서 사용 후 , 더 이상 사용되지 않는 변수 

            var temp = new { age = 40, name = "KIM" };

            // 무명 형식으로 생성된 인스턴스는 읽기 전용이라 
            // 값을 변경할 수 없다.

            Console.WriteLine("temp 의 age : " + temp.age + " temp의 name : " + temp.name);
            */
            #endregion

            #region 무명 메소드
            /*
            // 단순한 명령어 구문으로 구성된 메소드를 정의하지 않고 
            // 델리게이트를 사용하여 1회 성으로 사용하는 메소드 이다.
            Delegate value;

            value = () =>
            {
                Console.WriteLine("로그인을 실패하였습니다");
          
            };

            value();

            */
            #endregion

            #region 얕은 복사
            /*
            // 객체를 복사할 때 주소 값을 복사형
            // 같은 메모리를 가리키는 복사이다

            IPhone se1 = new IPhone(20000, 1);
            IPhone se2 = se1;

            se2.version = 2;
            se2.price = 30000;

            Console.WriteLine("se1의 버전은 : " + se1.version);
            Console.WriteLine("se2의 버전은 : " + se2.version);

            Console.WriteLine("se1의 가격 : " + se1.price);
            Console.WriteLine("se2의 가격 : " + se2.price);
            */
            #endregion

            // 깊은 복사
            // 객체를 복사 할 때 , 참조 값이 아닌 인스턴스
            // 자체를 새로 복사하여 서로 다른 메모리를
            // 생성하는 복사이다.

            IPhone se1 = new IPhone();
            se1.price = 20000;
            se1.version = 1;


            IPhone se2 = se1.DeepCopy();

            se2.version = 2;
            se2.price = 30000;

            Console.WriteLine("se1의 버전은 : " + se1.version);
            Console.WriteLine("se2의 버전은 : " + se2.version);

            Console.WriteLine("se1의 가격 : " + se1.price);
            Console.WriteLine("se2의 가격 : " + se2.price);

        }
    }
}