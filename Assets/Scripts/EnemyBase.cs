using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public delegate void DamageEnemyBaseDelegate();
    public static event DamageEnemyBaseDelegate enemyScore;
    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent<Bullet>(out var damager))
        {

        }

    }
}
