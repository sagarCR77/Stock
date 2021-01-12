using System;

public class Stock // Stock class constructer
{
private int _quantityOnHand;
private string _name;


public Stock(string name, int initialLevel)
{
    _name = name;
    _quantityOnHand = initialLevel;
}

public void AddStock(int quantityAdded) // add stock function
{
    _quantityOnHand = _quantityOnHand + quantityAdded; 

}

public void RemoveStock(int quantityRemoved) // remove stock function
{
    _quantityOnHand = _quantityOnHand - quantityRemoved; 
}

public string Name 
{
    get { return _name; } // read
    set { _name = value; } // read and write
}

public int QuantityOnHand 
{
    get { return _quantityOnHand; }
    private set { _quantityOnHand = value; } 
}

public void PrintSummary() 
{
    Console.WriteLine($"{Name}: {QuantityOnHand}"); // Print
}
}

    
