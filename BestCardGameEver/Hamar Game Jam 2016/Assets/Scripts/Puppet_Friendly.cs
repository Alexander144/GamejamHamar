using UnityEngine;
using System.Collections;

public class Puppet_Friendly : Puppet {

    //public C_Villain vil = new C_Villain();
    //public Puppet_Enemy enemy = new Puppet_Enemy();
    public Puppet_Friendly ()
    {
        
        
    }
	// Use this for initialization
	void Start () {
        SetAttack(10);
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right / 100);
    }
    void OnCollisionEnter2D(Collision2D coll)
    { 
        if (coll.collider.tag == "Enemy")
        {
 
           /* if (GetAttack() >= enemy.GetCurrentHP()) //mer attack enn enemy HP
            {
               */ Destroy(this.gameObject);
               // SetCurrentHP(GetCurrentHP() - enemy.GetAttack());
                //Debug.Log(GetCurrentHP());
            /*}
            else // mindre attack enn enemy HP
            {
                enemy.SetCurrentHP(enemy.GetCurrentHP() - GetAttack());
            }*/
        }
        else if (coll.collider.tag == "Villain")
        {
	        C_Villain.health -= GetAttack();
	        Debug.Log(C_Villain.health);
            Destroy(this.gameObject);
        }
    }
}
