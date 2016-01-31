using System;
using UnityEngine;
using System.Collections;
using System.Text;
using Input = UnityEngine.Input;

public class Card : MonoBehaviour
{
	public bool clicked = false;
	public Material highlight;
	

	// Use this for iniialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update()
	{
		MoveCard();
		CheckPressed();
	}

	public void OnMouseDown()
	{
		clicked = true;
		Debug.Log("hello");
	}

	public void MoveCard()
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition), Vector2.zero);
		if (UnityEngine.Input.GetMouseButtonDown(0))
		{
			if (hit.collider.tag == "Slot" && clicked == true && !(hit.transform.childCount >= 1) && !(hit == null))
			{

				clicked = false;
				this.gameObject.transform.parent = hit.transform;
				this.gameObject.transform.localPosition = new Vector3(0, 0, 0);
			}
			else if (hit.transform.childCount >= 1)
			{
				clicked = false;
			}
		}
	}

	public void CheckPressed()
	{
		if (clicked == true)
		{

		}
		else
		{

		}
	}
	public Card_Puppet conjurePuppet()
    {
        return null;
    }
	
}
