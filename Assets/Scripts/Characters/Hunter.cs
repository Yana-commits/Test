using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hunter : Tank
{
    public string nameOfTarget = "Finish";
    void Start()
    {
        DoOnStart(nameOfTarget);

    }

}
