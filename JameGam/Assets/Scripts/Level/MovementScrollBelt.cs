using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScrollBelt : MonoBehaviour
{
    [SerializeField]
    PlayerMovementBehaviour playerMovement;
    [SerializeField]
    private GameObject belt;
    [SerializeField]
    private float speed = 10f;
    public Transform endPoint;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (playerMovement.sideLimiter == "")
            {
                other.transform.position = Vector3.MoveTowards(other.transform.position, endPoint.position, speed * Time.deltaTime);
            }
        }
        else
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, endPoint.position, speed * Time.deltaTime);
        }
        
    }
}
