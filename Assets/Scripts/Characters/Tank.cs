using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tank : Machine
{
    public Rigidbody2D rigidbody;
    private Transform target;
    public Transform aim;
    public NavMeshAgent agent;
    public float shootingTime;
     private float shootTime;
    private Vector3 targetDirection;

    protected bool CheckTargetVisibility(Transform aim)
    {
        bool seeTarget;

         targetDirection = aim.transform.position - gun.transform.position;

        //Ray ray = new Ray(gun.transform.position, targetDirection);

        //RaycastHit hit;

        //if (Physics.Raycast(ray, out hit))
        //{
        //    Debug.Log($"{hit.collider.name}");
        //    if (hit.transform == aim)
        //    {
        //        Debug.Log("111");
        //        seeTarget = true;
        //        return;
        //    }

        //}

        //seeTarget = false;
       seeTarget = targetDirection.magnitude <= 5 ? true :  false;

        return seeTarget;
    }

    protected void DoOnStart(string nameOfTarget)
    {
        target = GameObject.FindGameObjectWithTag(nameOfTarget).transform;

        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        agent.SetDestination(target.position);

        shootTime = shootingTime - 1 * Time.fixedDeltaTime;

        if (CheckTargetVisibility(aim))
        {
            if (shootTime < 0)
            { 
            
            }
            

        }
    }
}
