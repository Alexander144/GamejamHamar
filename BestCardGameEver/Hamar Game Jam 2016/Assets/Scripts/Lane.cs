using UnityEngine;
using System.Collections;

public class Lane : MonoBehaviour {

    private int _minionsInLane;
    public Puppet friend;
    public Puppet enemy;

    public Lane()
    {
        _minionsInLane = 0;
    }
    public void addMinion()
    {
        _minionsInLane++;
    }
    public void SpawnFriend()
    {
        friend = new Puppet_Friendly();
    }
    public void SpawnEnemy()
    {
        enemy = new Puppet_Enemy();
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
