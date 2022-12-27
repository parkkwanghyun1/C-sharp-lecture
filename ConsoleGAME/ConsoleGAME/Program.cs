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
   

    internal class Program
    {


    static void Main(string[] args)
    {
            //콜레션
            // 데이터를 저장하는 자료구조와 데이터를 처리하는
            // 알고리즘을 구조화하여 클래스로 나타낸 형태이다.

            // List


            // ArrayList
            ArrayList arrayList = new ArrayList();

            // Add()
            // 0      1      2      3         4    
            //[1] [64.5f] ['V'] ["under"] [false]
            arrayList.Add(1);
            arrayList.Add(64.5f);
            arrayList.Add('V');
            arrayList.Add("under");
            arrayList.Add(false);

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
            // Dictionaly


            // Stack


            // Queue
        }

    }
}