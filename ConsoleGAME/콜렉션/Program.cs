namespace 콜렉션
{

    internal class Program
    {


        static void Main(string[] args)
        {
            //콜레션
            // 데이터를 저장하는 자료구조와 데이터를 처리하는
            // 알고리즘을 구조화하여 클래스로 나타낸 형태이다.

            #region List
            /*
            List<int> list = new List<int>();

            // Add()
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);

            // Insert( , ) 
            // (저장하고 싶은 index) , (저장할 값)
            list.Insert(4, 66);

            // Remove()
            list.Remove(1);

            // RemoveAt()
            list.RemoveAt(0);

            // size
            int size = list.Count;

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            #region ArrayList
            /*
            ArrayList arrayList = new ArrayList();

            // Add()
            // 0      1      2      3         4    
            //[1] [64.5f] ['V'] ["under"] [false]
            arrayList.Add(1);
            arrayList.Add(64.5f);
            arrayList.Add('V');
            arrayList.Add("under");
            arrayList.Add(false);

            // Insert( , ) 
            // (저장하고 싶은 index) , (저장할 값)
            arrayList.Insert(1, 33.987);
            
            // Remove()
            arrayList.Remove(64.5f);

            // RemoveAt()
            arrayList.RemoveAt(0);

            // size
            int size = arrayList.Count;

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            #region Dictionaly
            /*
            Dictionary<string, int> item = new Dictionary<string, int>();

            // Add()
            // key(string), value(int)
            item.Add("Sword", 10000);
            item.Add("Hat", 1000);
            item.Add("Shose", 5000);
            item.Add("Gloves", 3000);

            // Remove()
            item.Remove("Shose");
            
            // key 정보 탐색
            bool findkey = item.ContainsKey("Hat");

            // Value 정보 탐색
            bool findValue = item.ContainsValue(1000);

            Console.WriteLine(item["Sword"]);
            */
            #endregion

            #region Stack
            /*
            Stack<string> stack = new Stack<string>();
            
            // Push
            stack.Push("window 1");
            stack.Push("window 2");
            stack.Push("window 3");

            // Pop
            stack.Pop();  // 매개변수 x 제일 마지막에 들어온 데이터 삭제

            // Count
            int count = stack.Count;
            Console.WriteLine("stack의 count : " + count);

            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            # region Queue
            /*
            Queue<char> queue = new Queue<char>();

            //Enqueue
            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');

            //Dequeue
            queue.Dequeue();

            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            */
            #endregion
        }

    }
}