using System;
using UnityEngine;
using System.Collections;
using Input = UnityEngine.Input;

public class Card : MonoBehaviour
{
	public bool clicked = false;
	

	// Use this for iniialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		RaycastHit hitInfo = new RaycastHit();
		bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition), out hitInfo);
		if (hit)
		{
			if (hitInfo.collider.tag == "Slot")
			{
				Debug.Log("It's working!");
			}
		}
	}

	void OnMouseDown()
	{
		clicked = true;
		Debug.Log("hello");
	}

	public Card_Puppet conjurePuppet()
    {
        return null;
    }
	
}
