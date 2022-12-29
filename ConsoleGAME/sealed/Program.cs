namespace 쉴드;
{ class Shop
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
}
