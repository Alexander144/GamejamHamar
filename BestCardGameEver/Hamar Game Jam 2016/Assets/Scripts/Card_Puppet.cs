using UnityEngine;
using System.Collections;

public class Card_Puppet : Card
{
	public static bool destroy = false;
	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		MoveCard();
		CheckPressed();
		if (destroy == true)
		{
			Destroy(gameObject);
			destroy = false;
		}
	}
	// Update is called once per frame
	new void MoveCard()
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition), Vector2.zero);
		if (UnityEngine.Input.GetMouseButtonDown(0))
		{
			if ((hit.collider.name == "SlotPuppets" || hit.collider.name == "Slot3" || hit.collider.name == "Slot4") &&
			    clicked == true && !(hit.transform.childCount >= 1) && !(hit == null))
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
		if ((hit.collider.name == "Portal1" || hit.collider.name == "Portal2" || hit.collider.name == "Portal3") && clicked == true)
		{
			clicked = false;
			Spawner.start = true;
		}
	}
}
