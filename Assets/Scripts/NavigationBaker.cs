using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationBaker : MonoBehaviour
{
    public NavMeshSurface2d surfaces;

    // Start is called before the first frame update
    void Start()
    {
       
            surfaces.BuildNavMesh();
       
    }

}
