namespace lecture_resorce
{
    class Function
    {
        //ref 키워드
        public void Change(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // out 키워드
        // out 매개변수 값을 무조건 초기화 해야 한다.
        public void Output(out int x)
        {
            // out 은 함수 내부에서 메소드 외부로 전달하는 방향이다.
            x = 1000;

        }
        // in 키워드
        public void IteamList(in int x)
        {
            // in 은 메소드 내부에서 값을 수정할 수 없다
            //x=500;

            int variable = x;
            Console.WriteLine("x 의 값 :" + x);
        }

        // params 키워드
        public void StatList(params int[] list)
        {
            // params 키워드는 하나만 사용 가능하다.
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("list 의 값 : " + list[i]); ;
            }
        }


        internal class Program
        {


            static void Main(string[] args)
            {
                #region 매개 변수 한정자 
                /*
                int value1 = 10;
                int value2 = 3;

                // out 키워드는 값이 초기화하지 않아도 사용할 수 있다. 
                int data ;

                int item = 10;


                // ref 키워드
                // 매개 변수가 참조로 전달할 수 있고, 호출된 메소드로 읽거나
                // 쓸수 있는 한정자 잆니다.

                // 1. value1 , value2 가 참조로 전달
                // 2. x 와 y 의 값이 전달된 상태로 사용 

                Function function = new Function();

                // ref 키워드는 인수로 전달하는 변수의 값이 초기화가 되어 있어야 한다.
                function.Change(ref value1,ref  value2);

                Console.WriteLine("value1 의 값 : " + value1);
                Console.WriteLine("value2 의 값 : " + value2);

                // out 키워드 (출력용 매개변수)
                // 매개 변수가 참조로 전달할 수 있고, 호출된 매소드에 의해서
                // 기록되도록 지정하는 한정자 이다.

                // 1. x 변수가 out int x 로 들어간다.
                // 2. x 변수의 값이 data 변수로 저장되게 된다
                function.Output(out data);

                Console.WriteLine("data 의 값 : " + data);

                // in 키워드
                // 매개 변수를 참조로 전달 할 수 있지만, 호출된 메소드에서 
                // 읽기만 가능한 한정자 이다.
                function.IteamList(item);

                Console.WriteLine("item 의 값 : " + item);

                // params 키워드
                // 매개변수가 가변 개수의 인수를 사용할 수 있도록 지정해주는 한정자 이다.

                function.StatList(1, 2, 3, 4, 5,6 ,7);
                // 인수를 전달하지 않으면, 배열의 길이는  0 으로 설정된다.
                function.StatList();
                */
                #endregion


                // var 
                // var 는 스택 메모리에 저장되게 된다. 

                var name = "parkkwanghyun";
                var age = 10;
                var health = 100.0f;
                var alphabet = 'A';

                Console.WriteLine("name 의 값 : " + name);
                Console.WriteLine("age 의 값 : " + age);
                Console.WriteLine("health 의 값 : " + health);
                Console.WriteLine("alphabet 의 값 : " + alphabet);
            }
        }
    }
}