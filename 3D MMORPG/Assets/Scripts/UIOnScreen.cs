using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOnScreen : CharacterStats {
    public Slider slider;
    public Text HP_Current_And_Max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = maxHealth;
        slider.value = currentHealth;

        HP_Current_And_Max.text = "" + currentHealth + "/" + maxHealth;
    }
}
