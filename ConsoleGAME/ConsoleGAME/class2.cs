using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGAME
{
    class Monster
    {
       

    internal class second_lecture
    {
            //기본 접근 지정자
            // 필드에서 privater 로 설정된다. 

            public int attack;
            public string name;

            public void Defense()
            {
                Console.WriteLine("방어");
            }
        }
        // 값 타입
        // 변수의 선언과 동시에 값을 할당할 수 있으며
        // 스택 메모리에 생성된다

        // 메모리 레이아웃 
        /*
        // 코드영역 - const , 기게어 , txt 
        // 컴파일 시점 

        // 데이터 영억
        // 정적 변수와 전역 변수
        // 프로그램이 실행될 때 단 한번만 초기화가 된다
        // 프로그램이 종료될 때 메모리에서 해제 된다.

        // 스택 영역
        // 매개 변수와 지역 변수

        //힙 영역
        // 사용자가 직접 메모리 할당 
        */

        // 참조 타입
        /*
        // new 키워드를 사용해서 객체를 초기화한 후 
        // 힙에 할당된 메모리를 스택에서 참조하여 사용하는 타입이다


        int value = 10;
        value = 20;

        string name = "Parkkwanghyun";
        int []array = new int [5];

        name = "Park";

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        Console.WriteLine(value);
        Console.WriteLine(name);

        Console.WriteLine(array[0]);
        Console.WriteLine(array[1]);
        Console.WriteLine(array[2]);
        Console.WriteLine(array[3]);
        Console.WriteLine(array[4]);



        Monster monster = new Monster();

        monster.attack = 10;
        monster.name = "mondo";
        monster.Defense();
        */
    }
}
