using UnityEngine;
using System.Collections;

public class Puppet : MonoBehaviour {

    
    private string _name;
    private int _HP;
    private int _attack;
    private int _speed;
    private int _currentHP;
    private string _type;
    private bool _alive;

    private int _direction;
    private int _x;
    private int _y;

    public Puppet()
    {  

        _name = "";
        _HP = 100;
        _attack = 10;
        _speed = 2;
        _currentHP = _HP;
        _type = "";
        _alive = true;
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
    public int GetCurrentHP()
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

    public bool GetAlive()
    {
        return _alive;
    }
    public int GetCurrentHp()
    {
        return _currentHP;
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

    public void SetAlive(bool isAlive)
    {
        _alive = isAlive;
    }

    public void SetCurrentHP(int HP)
    {
        _currentHP = HP;
    }
}