﻿using System.Collections;
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


    }
    void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up / pitch);

        transform.RotateAround(target.position, Vector3.up, currentHorizontal);
    }
}
