using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{

    NavMeshAgent agent;
   
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Rigidbody player = GetComponent<Rigidbody>();


    }
    public void MoveToPoint(Vector3 point)
    {

        agent.SetDestination(point);
      
    }

    
}
