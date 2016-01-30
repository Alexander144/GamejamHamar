using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {
    public Lane lane1;
    public Lane lane2;
    public Lane lane3;

    // Use this for initialization
    void Start () {
        lane1 = new Lane();
        lane2 = new Lane();
        lane3 = new Lane();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
