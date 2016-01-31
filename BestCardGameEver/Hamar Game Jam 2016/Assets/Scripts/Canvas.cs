using UnityEngine;
using System.Collections;

public class Canvas : MonoBehaviour {

    public Card ingredient;
    public Card puppet;
    

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 2; i++)
        {
            AddCardToHand();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Card_Puppet Combine(Card_Ingredient card1, Card_Ingredient card2)
    {
        return null;
    }

    public Card_Ingredient AddCardToHand()
    {
        return null;
    }
}
