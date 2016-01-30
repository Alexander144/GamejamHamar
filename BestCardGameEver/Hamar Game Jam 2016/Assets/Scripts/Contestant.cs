using UnityEngine;
using System.Collections;

public class Contestant : MonoBehaviour {

    private int _HP;

    public Contestant ()
    {
        _HP = 100;
    }

    public void SetHP (int HP)
    {
        _HP = HP;
    }

    public int GetHP ()
    {
        return _HP;
    }
	
}
