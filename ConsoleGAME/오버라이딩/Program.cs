namespace 오버라이딩
{

    // 오버라이딩
    // 상위 클래스에 있는 메소드를 하위 클래스에서 
    // 재정의하여 사용하는 기능이다.

    internal class Program
    {
        // 선택적 매개변수
        // 기본 값을 가지는 매개 변수이며, 필요에 따라 선택적 매개변수로
        // 선언된 매개변수는 인수를 전달하지 않아도 된다

        static void Function(int x, int y = 100)
    {
        // 선택적 매개변수는 인수를 전달할 때 오니쪽에서부터
        // 값이 저장되어 지기 때문에 오른쪽에서부터 선택적 매개변수를
        // 선언해주어야 한다
        Console.WriteLine("x 의 값 : " + x);
        Console.WriteLine("y의 값 : " + y);
    }

    // 명명된 매개변수
    // 매개 변수를 호출할 때 필요한 매개변수 이름을 직접
    // 지정해서 사용하는 매개 변수이다.
    static void Information(string name, int age, char blood)
    {
        Console.WriteLine("name 의 값 : " + name);
        Console.WriteLine("age의 값 : " + age);
        Console.WriteLine("blood 의 값 : " + blood);

    }
    class Animal
    {
        string name;
        public void sound()
        {
            Console.WriteLine("동물의 울음 소리");
        }

        //가상 함수
        // 상속하는 클래스 내에서 같은 형태의 함수로 재정의 될 수 있는
        // 함수이다.

        virtual public void Action()
        {
            Console.WriteLine("동물의 행동");
        }
    }

    class Dog : Animal
    {
        // 메소드 숨기기
        // 상위 클래스로부터 상속 받은 멤버와 이름은
        // 동일 하지만, 완전히 다른 새로운 메소드를 정의할 때 
        // 사용하는 키워디이다.

        new public void sound()
        {
            Console.WriteLine("명 ~ 명 ~ ");
        }

        // 오버라이딩
        override public void Action()
        {
            Console.WriteLine("강아지의 행동");
        }

        public void Tracking()
        {
            Console.WriteLine("강아지가 추적합니다.");
        }
    }

    static void Main(string[] args)
    {
        #region 메소드 숨기기 & 오버라이딩
        /*
        Animal animal = new Animal();
        animal.Action();
        animal.sound();

        Dog dog = new Dog();
        dog.Action();
        dog.sound();

        Animal parent = new Dog();

        // 런타임 중에 어떤 함수를 불러올지 결정하는 행위

        parent.Action();
        parent.sound();
        */
        #endregion

        // 선택적 매개변수 
        Function(10);
        Function(50, 500);

        //명명된 매개변수
        Information("park", 26, 'O');
        Information(age: 10, blood: 'a', name: "kwang");
    }
}
}