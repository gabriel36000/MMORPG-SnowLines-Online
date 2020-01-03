﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerController))]
public class PlayerMovement : MonoBehaviour
{
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
                motor.MoveToPoint(hit.point);
            }
        }
    }
}
