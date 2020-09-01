using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTag : MonoBehaviour
{
    public TextMesh TextName;

    private void Update() {
        if(TextName != null) {
            TextName.transform.LookAt(Camera.main.transform.position);
            TextName.transform.Rotate(0, 200, 0);
            
        }
    }
}
