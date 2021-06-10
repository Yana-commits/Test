using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Machine : MonoBehaviour
{
    [SerializeField]
    private BulletPool pool;

    public Transform gun;

    protected void Shoot(Vector2 direction, float shootPower)
    {
        GameObject newBullet = pool.snowBallParent.GetChild(pool.currentId).gameObject;

        newBullet.SetActive(true);
        newBullet.transform.position = gun.position;

       
        newBullet.GetComponent<Rigidbody2D>().AddForce(direction.normalized * shootPower, ForceMode2D.Impulse);


        Bullet ballBehaviour = newBullet.GetComponent<Bullet>();

        ballBehaviour.Owner = gameObject;

        pool.BUlletCounter();

        Debug.Log("Bang");
       
    }
}
