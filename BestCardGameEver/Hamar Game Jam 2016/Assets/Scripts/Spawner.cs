using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] prefabs;
    private Lane lane;
	public static bool start = false;
    void Start()
    {
        lane = new Lane();
    }

    void OnMouseDown()
    {
	    if (start == true)
	    {
		    Card_Puppet.destroy = true;
			Spawn();
	    }
	}

    public void Spawn() 
    {
		start = false;
        lane.addPuppet();
        var newTransform = transform;

        Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);
    }
}