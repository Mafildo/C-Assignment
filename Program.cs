using System;

namespace Excercise1;

class Program
{
    static void Main()
    {

        // exercise-1
        Car myCar = new Car("Toyota", 2022, 25000.50f);
        myCar.DisplayCarDetails();


        //exercise-2
        BankAccount myAcc = new BankAccount("123");
        myAcc.Deposit(1000);
        myAcc.Withdraw(500);
        myAcc.GetBalance();


        //exercise-3
        Rectangle rect = new Rectangle(4.5f, 3.2f);
        rect.CalculateArea();

        //exercise-4
        Circle areaObj = new Circle(5);
        areaObj.CalculateArea();

        //exercise-5
        Student studentObj = new Student("John Doe", 20, "Computer Science");
        studentObj.Introduce();

        //exercise-6
        Stack<int> stackObj = new Stack<int>();
        stackObj.Push(2);
        stackObj.Push(3);
        stackObj.Push(4);
        stackObj.Pop();
        stackObj.Peek();
        stackObj.isEmpty();


        //exercise-7
        Calendar calendar = new Calendar();
        calendar.PrintWeekdays();

        //exercise-8
        Point2D pointA = new Point2D { X = 1.0f, Y = 2.0f };
        Point2D pointB = new Point2D { X = 4.0f, Y = 6.0f };
        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between Point A and Point B: {distance}");
    }
}


