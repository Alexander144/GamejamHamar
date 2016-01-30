using UnityEngine;
using System.Collections;

public class Puppet : MonoBehaviour {
    private string _name;
    private int _HP;
    private int _attack;
    private int _currentHP;
    private string _type;

    private int _direction;
    private int _x;
    private int _y;

    public Puppet()
    {
        _name = "";
        _HP = 0;
        _attack = 0;
        _currentHP = _HP;
        _type = "";
    }

    //-----------------getters
    public string GetName()
    {
        return _name;
    }
    public int GetAttack()
    {
        return _attack;
    }
    public int GetHP()
    {
        return _HP;
    }
    public int GetDirection()
    {
        return _direction;
    }
    public int GetX()
    {
        return _x;
    }
    public int GetY()
    {
        return _y;
    }

    //------------setters
    public void SetName(string newName)
    {
        _name = newName;
    }
    public void SetAttack(int newAttack)
    {
        _attack = newAttack;
    }
    public void SetHP(int newHP)
    {
        _HP = newHP;
    }
    public void SetX(int x)
    {
        _x = x;
    }
    public void SetY(int y)
    {
        _y = y;
    }
    public void SetDirection(int direction)
    {
        _direction = direction;
    }
}
