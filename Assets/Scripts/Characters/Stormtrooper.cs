using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stormtrooper : Tank
{
    private string nameOfTarget = "Player";
    void Start()
    {
        DoOnStart(nameOfTarget);

    }
}
