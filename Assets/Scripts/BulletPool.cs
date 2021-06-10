using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BulletPool : MonoBehaviour
{
    [Inject]
    private Bullet bullet;

    public Transform snowBallParent;
    public int poolCount = 10;
    public int currentId = 0;

   

    void Start()
    {
        PoolBullet();

    }

    private void PoolBullet()
    {
        snowBallParent = transform;

        for (int i = 0; i < poolCount; i++)
        {
            var instance = Instantiate(bullet, transform.position, transform.rotation, snowBallParent)as Bullet;
            instance.gameObject.SetActive(false);
        }
    }

    public void BUlletCounter()
    {
        currentId++;

        if (currentId > snowBallParent.childCount - 1)
        {
            currentId = 0;
        }
    }


}
