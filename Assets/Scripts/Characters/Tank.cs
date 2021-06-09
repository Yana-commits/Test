using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tank : Machine
{
    public Rigidbody2D rigidbody;
    protected bool seeTarget;
    private float directionOffset = 0.6f;

    protected void CheckTargetVisibility(GameObject aim)
    {
        Vector2 targetDirection = aim.transform.position - gun.transform.position;

        //targetDirection.Normalize();
        

        float directionOffsetX = directionOffset * (transform.position.x > 0 ? 1 : -1);
        float directionOffsetY = directionOffset * (transform.position.y > 0 ? 1 : -1);

        Vector2 point = new Vector2(directionOffsetX, directionOffsetY);

        RaycastHit2D hit = Physics2D.Raycast(point, targetDirection);

        //Ray ray = new Ray(gun.transform.position, targetDirection);

        //RaycastHit2D hit;

        //if (Physics2D.Raycast(ray, out hit))
        //{
            if (hit.transform == aim.gameObject.transform)
            {
                Debug.Log($"{hit.collider.name}");
                seeTarget = true;
                return;
            }
        //}
        Debug.Log("mmm");
        seeTarget = false;
    }

    protected IEnumerator Shooting(int shootTime)
    {
        while (seeTarget == true)
        {
            Shoot();

            yield return new WaitForSeconds(shootTime);
        }
    }
}
