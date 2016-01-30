using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

    public Contestant _hero;
    public Contestant _villain;
    public Board _board;
    public Input _input;

	// Use this for initialization
	void Start () {
        _board = new Board();
        _hero = new C_Hero();
        _villain = new C_Villain();
        _input = new Input();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
