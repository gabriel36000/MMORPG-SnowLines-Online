using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;


    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f;

    public float horizontalSpeed = 100f;
    public float verticalSpeed = 100f;

    private float currentZoom = 10f;
    private float currentHorizontal = 2f;
    private float currentVertical = 2f;
   
 


    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        
        if (Input.GetButton("Mouse X"))
        {
            currentHorizontal += Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
            
            
        }
        
        if (Input.GetButton("Mouse Y")) {
            print (currentVertical);
            
            currentVertical -= Input.GetAxis("Mouse Y") * verticalSpeed * Time.deltaTime;
            
        }
        

    }
    void LateUpdate()
    {
       
        transform.position = target.position - offset * currentZoom;
        

        transform.RotateAround(target.position, Vector3.up, currentHorizontal);
          
        transform.RotateAround(target.position, Vector3.right,  Mathf.Clamp(currentVertical, -9f, 30f));
        
        transform.LookAt(target.position + Vector3.up / pitch);

    }

     void Start() {
        
    }
}
