using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public delegate void DamageBaseDelegate();
    public static event DamageBaseDelegate score;

    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent<Damager>(out var damager))
        {

        }

    }
}
