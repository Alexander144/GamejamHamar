using UnityEngine;
using System.Collections;

public class Puppet_Enemy : Puppet {

    new BoxCollider2D collider;
    public C_Hero hero = new C_Hero();
    public Puppet_Friendly friendly = new Puppet_Friendly();
    public Puppet_Enemy()
    {
        collider = new BoxCollider2D();
    }

    // Use this for initialization
    void Start() {
        transform.Rotate(0, 180, 0);
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(-transform.right / 100);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.tag == "Friendly")
        {
            if (GetAttack() >= friendly.GetCurrentHP()) // mindre liv enn enemy attack
            {
                Destroy(friendly);
                SetCurrentHP(GetCurrentHP() - friendly.GetAttack());
            }
            else //mer liv enn enemy attack
            {
                friendly.SetCurrentHP(friendly.GetCurrentHP() - GetAttack());
            }
            Debug.Log(GetAttack());
            Debug.Log(friendly.GetCurrentHP());
        } else if (coll.collider.tag == "Hero")
        {

            hero.SetCurrentHP(hero.GetCurrentHP() - GetAttack());
            Destroy(gameObject);
        }
    }
}