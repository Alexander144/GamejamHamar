using UnityEngine;
using System.Collections;

public class Minion : MonoBehaviour {
    private string _name;
    private int _HP;
    private int _attack;
    private int _currentHP;
    private string _type;

    public Minion()
    {
        _name = "";
        _HP = 0;
        _attack = 0;
        _currentHP = _HP;
        _type = "";
    }

    //getters
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

    //setters
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

}
