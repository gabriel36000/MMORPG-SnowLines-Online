using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(PlayerController))]
public class PlayerMovement : MonoBehaviour
{
    public Interactable focus;
    public float moveSpeed;
    Camera cam;
  
    PlayerController motor;
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                motor.MoveToPoint(hit.point); // Move our player to what we hit
                RemoveFocus();
               
            }
        }
        if (Input.GetMouseButtonDown(1)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
               Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null) {
                    SetFocus(interactable);
                }

            }
            if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Horizontal") == 1)
        {
            transform.GetComponent<NavMeshAgent>().enabled = false;
            
        }

        else
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
      
        }
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);


        }
    }
        void SetFocus (Interactable newFocus) {
        if (newFocus != focus) {
            if (focus != null)
            focus.OnDefocused();
            focus = newFocus;
            motor.FollowTarget(newFocus);
        }
            newFocus.OnFocused(transform);
    }
        void RemoveFocus (){
            if (focus != null)
             focus.OnDefocused();

        focus = null;
        motor.StopFollowingTarget();
    }
}
