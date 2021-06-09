using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hunter : Tank
{
    protected Transform target;
    public GameObject aim;
    public NavMeshAgent agent;
    public int shootingTime;

    private int speed = 0;
   
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        StartCoroutine(Shooting(shootingTime));

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        CheckTargetVisibility(aim);
    }


}
