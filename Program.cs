using System;

public class Car
{
    private string brand;
    private int year;
    private float price;

    // Constructor
    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    // Method to display car details
    public void DisplayCarDetails()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: ${price}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Car class
        Car myCar = new Car("Toyota", 2022, 25000.50f);

        // Displaying car details
        myCar.DisplayCarDetails();
    }
}


