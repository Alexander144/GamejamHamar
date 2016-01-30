using UnityEngine;
using System.Collections;

public class Contestant : MonoBehaviour {

    private int _HP;
    private int _CurrentHP;
    public Contestant ()
    {
        _HP = 500;
    }

    public void SetHP (int HP)
    {
        _HP = HP;
    }
    public void SetCurrentHP(int newHP)
    {
        _CurrentHP = newHP;
    }

    public int GetHP ()
    {
        return _HP;
    }
    public int GetCurrentHP()
    {
        return _CurrentHP;
    }
	
}
