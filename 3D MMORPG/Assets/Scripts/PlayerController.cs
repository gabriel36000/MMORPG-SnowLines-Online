using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

     void Update() {
        if (target != null) {
            agent.SetDestination(target.position);
            FaceTarget();
        }
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Rigidbody player = GetComponent<Rigidbody>();


    }
    public void MoveToPoint(Vector3 point)
    {

        agent.SetDestination(point);
      
    }

    public void FollowTarget (Interactable newTarget) {
        agent.stoppingDistance = newTarget.radius * 2f;
        agent.updateRotation = false;
        target = newTarget.transform;
    }
    public void StopFollowingTarget() {
        agent.stoppingDistance = 0f;
        agent.updateRotation = true;
        target = null;
    }
    void FaceTarget() {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRoation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRoation, Time.deltaTime * 5f);
    }
}
