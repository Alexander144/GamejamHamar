using UnityEngine;
using System.Collections;

public class SpawnCard : MonoBehaviour
{
	public GameObject Flesh;
	public GameObject Skull;
	public bool spawn1 = true;
	public bool spawn2 = true;
	public static int count1 = 1000;
	public static int count2 = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		count1--;
		Debug.Log(count1);
		count2--;
		Debug.Log(count2);
		if (!(gameObject.transform.childCount >= 1)&&gameObject.name == "Slot1"&&count1<=0)
		{
			GameObject MoveSkull= Instantiate(Skull, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			MoveSkull.transform.parent = gameObject.transform;
			MoveSkull.transform.localPosition = new Vector3(0, 0, 0);
			MoveSkull.transform.localScale = new Vector3(0.9969679f, 1.039015f, 1.030534f);
			count1 = 1000;
		}
		if (!(gameObject.transform.childCount >= 1) && gameObject.name == "Slot2"&&count2<=0)
		{
			GameObject MoveFlesh = Instantiate(Flesh, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			MoveFlesh.transform.parent = gameObject.transform;
			MoveFlesh.transform.localPosition = new Vector3(0, 0, 0);
			MoveFlesh.transform.localScale = new Vector3(0.9969679f, 1.039015f, 1.030534f);
			count2 = 1000;
		}
	}
}
