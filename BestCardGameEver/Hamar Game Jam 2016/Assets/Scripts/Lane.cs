using UnityEngine;
using System.Collections;

public class Lane : MonoBehaviour {

    private int _puppetsInLane;
    public Puppet friend;
    public Puppet enemy;
    public Puppet[] puppets;
    public Spawner playerSpawner;
    public Spawner enemySpawner;

    public Lane()
    {
        _puppetsInLane = 0;
    }
    public void addPuppet()
    {
        _puppetsInLane++;
    }
}
