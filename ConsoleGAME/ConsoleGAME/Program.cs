using ConsoleGAME;
using System;
using System.IO.Pipes;

namespace ConsoleGame
{

    internal class Program
    {
        //delegate void CallBack(); // 델리게이트 선언

        static void Main(string[] args)
        {
            #region 분할 클래스
            /*
            // 클래스 구현이 길어질 경우 2 개이상의 
            // 소스 파일로 분할하여 동시에 작업을 수행
            // 하거나, 관리의 편의를 위해 클래스를
            // 분할하는 클래스이다.
            NPC npc = new NPC();

            npc.health = 100;
            npc.Dialog();
            */
            #endregion


           
            // action
            // 매개변수를 최대 16개 까지 지정할 수 있다.
            // 반환형 메소드가 없는 메소드를 저장할 수 있는 delegate
            Action action = () => Console.WriteLine("Action 입니다");
            action();

            // Func
            // 반환형이 존재하는 메소드를 저장할수 있는 delegate
            // Func<매개변수, 반환형>
            Func<int, int> func = (int a) => a;

            Console.WriteLine("func의 값 : " + func(10));

            // CallBack callback = () => Console.WriteLine("안녕하세요");

            // callback();

        }
    }
}