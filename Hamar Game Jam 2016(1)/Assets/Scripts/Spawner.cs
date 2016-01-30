using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] prefabs;
    private Lane lane;

    void Start()
    {
        lane = new Lane();
    }

    void OnMouseDown()
    {
        Spawn();
    }

    public void Spawn() 
    {
        lane.addPuppet();
        var newTransform = transform;

        Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);
    }
}