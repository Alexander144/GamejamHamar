using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Canvas = UnityEngine.Canvas;
using Input = UnityEngine.Input;

public class CookBook : MonoBehaviour
{
	public GameObject CombineSlot1;
	public GameObject CombineSlot2;
	public Button CombineButton;
	public GameObject ZombieCard;
	public GameObject MinionSpawn;
	public bool pressed = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (pressed == false)
		{
			pressed = true;
			CombineButton.GetComponent<Button>().onClick.AddListener(() =>
			{
				if (CombineSlot1.transform.childCount >= 1 && CombineSlot2.transform.childCount >= 1)
				{
					Destroy(CombineSlot1.gameObject.transform.GetChild(0).gameObject);
					Destroy(CombineSlot2.gameObject.transform.GetChild(0).gameObject);
					GameObject zombie = Instantiate(ZombieCard, new Vector3(0,0,0), Quaternion.identity) as GameObject;
					zombie.transform.parent = gameObject.transform;
					zombie.transform.localPosition = new Vector3(0,0,0);
					zombie.transform.localScale = new Vector3(0.9969679f, 1.039015f, 1.030534f);
				}
			});
		
		}
	}
}
