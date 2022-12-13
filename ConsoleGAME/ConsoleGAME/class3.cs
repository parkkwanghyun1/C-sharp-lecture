﻿using ConsoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGAME
{

    internal class third_lecture
    {
        class Solution
        {

            #region 박싱 (Boxing)
            /*
            // 값 형식을 참조 형식으로 변환해주는 과정입니다. 

            int value = 10;

            // 참조  값
            //[ ] <- 10
            // 암묵적으로 형 변환이 된다.
            // object 가 값 타입보다 상위의 자료형이기 때문에
            // 암묵적으로 형 변환이 가능하다 

            object obj = value;

            obj = 300;

            // 박싱을 하는 과정에서 추가적인 메모리가 발생한다. 
            Console.WriteLine("obj 의 값 : " + obj);
            Console.WriteLine("value 의 값 : " + value);
            */
            #endregion

            #region 언박싱(UnBoxing)
            /*
            // 참조 타입을 값 타입으로 변환하는 과정이다. 


            // data 변수가 값 타입으로 , obj 참조 타입보다
            // 하위 자료형이기 때문에 명시적으로 형 변환을 해주어야 한다.
            int data = (int)obj;

            // 언박싱 변환 시 스택메모리에 언박싱된 무명객체가 생성되며,
            // 이 무명객체를 다시 해당객체에 대입하는 원리이다. 
            Console.WriteLine("data의 값 : " + data);

            object[] dataTable = new object[5];
            dataTable[0] = 10;
            dataTable[1] = "Sword";
            dataTable[2] = 36.5f;
            dataTable[3] = 'A';
            dataTable[4] = true;
            */
            #endregion

            //  int value1 = 10;
            //  int value2 = 20;

            //Solution solution = new Solution();
            //solution.Function();

            // callby pass 
            // solution.Swap(value1, value2);


            // Console.WriteLine("value1 의 값 : " + value1);
            //Console.WriteLine("value2 의 값 : " + value2);

            //Solution.Post();

        }
    }
}
