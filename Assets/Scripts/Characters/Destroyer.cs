using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : Tank
{
    private string nameOfTarget = "Base";
    void Start()
    {
        DoOnStart(nameOfTarget);
    }
}
