using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour,IDamager
{
    
    private float damage;

    private GameObject owner;
    public GameObject Owner
    {

        get { return owner; }

        set { owner = value; }

    }

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            if (value > 10)
            {
                damage = 10;
            }
            else
            {
                damage = value;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Equals(collision.gameObject, Owner))
        {
            Destructable target = collision.gameObject.GetComponent<Destructable>();

            if (target != null)
            {
                
            }
            Debug.Log("222");
            gameObject.SetActive(false);
        }

    }
}
