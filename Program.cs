using System;

class Car
{
    public int Speed { get; set; }

    public string CheckSpeedStatus()
    {
        if (Speed < 40)
        {
            return "ช้าเกินไป";
        }
        else if (Speed >= 40 && Speed <= 79)
        {
            return "ความเร็วปกติ";
        }
        else if (Speed >= 80 && Speed <= 119)
        {
            return "เร็ว! ควรระวัง";
        }
        else // Speed >= 120
        {
            return "อันตราย! เกินกำหนด";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("กรุณากรอกความเร็วรถ (กม./ชม.): ");
        int inputSpeed = int.Parse(Console.ReadLine());

        Car car = new Car();
        car.Speed = inputSpeed;

        string result = car.CheckSpeedStatus();
        Console.WriteLine("สถานะความเร็ว: " + result);
    }
}

