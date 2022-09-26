using ClassProcessor;
using ClassVGA;
using System;
class Laptop
{
    public string merk;
    public string tipe;
    public VGA vga;
    public Processor processor;
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }
}
class Acer : Laptop
{
    public Acer()
    {
        merk = "Acer";
    }
}
class Swift : Acer
{
    public Swift()
    {
        tipe = "Swift";
    }
}
class Predator : Acer
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}

class Asus : Laptop
{
    public Asus()
    {
        merk = "ASUS";
    }
}
class ROG : Asus
{
    public ROG()
    {
        tipe = "ROG";
    }
}
class Vivobook : Asus
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}