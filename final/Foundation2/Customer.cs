using System;


//this. é uma palavra chave que se refere a instancia atual da classe, usada para acessar membros da propria classe
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name; //this melhora a clareza do código
        this._address = address;
    }

    public bool LocalUSA()
    {
        return _address.LocalUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}