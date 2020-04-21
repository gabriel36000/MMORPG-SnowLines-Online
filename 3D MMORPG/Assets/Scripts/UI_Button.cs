using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel() {
        if(Panel != null) {
            Panel.SetActive(true);
        }
    }

    public void ClosedPanel() {
        if(Panel != null) {
            Panel.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
