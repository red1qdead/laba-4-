using System;
using System.Collections.Generic;

class Window
{
    public bool IsOpen { get; private set; }

    public void Open()
    {
        IsOpen = true;
        Console.WriteLine("Вiкно вiдкрито.");
    }

    public void Close()
    {
        IsOpen = false;
        Console.WriteLine("Вiкно закрито.");
    }

    public override string ToString()
    {
        return $"Вiкно {(IsOpen ? "вiдкрите" : "закрите")}.";
    }
}

class Door
{
    public bool IsOpen { get; private set; }
    public bool IsLocked { get; private set; }

    public void Open()
    {
        if (!IsLocked)
        {
            IsOpen = true;
            Console.WriteLine("Дверi відкритi.");
        }
        else
        {
            Console.WriteLine("Дверi замкненi.");
        }
    }

    public void Close()
    {
        IsOpen = false;
        Console.WriteLine("Дверi закритi.");
    }

    public void Lock()
    {
        IsLocked = true;
        IsOpen = false; // Забезпечуємо, що двері закриті при замиканні
        Console.WriteLine("Дверi замкненi на ключ.");
    }

    public void Unlock()
    {
        IsLocked = false;
        Console.WriteLine("Дверi відмкненi.");
    }

    public override string ToString()
    {
        return $"Дверi {(IsOpen ? "вiдкритi" : "закритi")} та {(IsLocked ? "замкненi на ключ" : "не замкненi на ключ")}.";
    }
}

class House
{
    private List<Window> windows = new List<Window>();
    private List<Door> doors = new List<Door>();

    public House(int numberOfWindows, int numberOfDoors)
    {
        for (int i = 0; i < numberOfWindows; i++)
        {
            windows.Add(new Window());
        }

        for (int i = 0; i < numberOfDoors; i++)
        {
            doors.Add(new Door());
        }
    }

    public void LockAllDoors()
    {
        foreach (var door in doors)
        {
            door.Lock();
        }
        Console.WriteLine("Усi дверi замкненi на ключ.");
    }

    public void DisplayCount()
    {
        Console.WriteLine($"У будинку {windows.Count} вiкон та {doors.Count} дверей.");
    }

    public override string ToString()
    {
        return $"Будинок з {windows.Count} вiкнами та {doors.Count} дверима";
    }
}

// Приклад використання
class Program
{
    static void Main(string[] args)
    {
        House myHouse = new House(5, 2); // Будинок з 5 вікнами та 2 дверима
        myHouse.DisplayCount();
        myHouse.LockAllDoors();

        Console.WriteLine(myHouse);
    }
}
