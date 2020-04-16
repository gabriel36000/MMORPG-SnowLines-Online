using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public Slider slider;

    public 
    void Start()
    {
        playerCurrentHealth = playerMaxHealth; // The Player will spawn with max health
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerMaxHealth;
        slider.value = playerCurrentHealth;
        if (playerCurrentHealth < 0) {
            gameObject.SetActive(false); // If the player dies, the game object will deactivated 
        }
    }
    public void HurtPlayer(int damageToGive) {
        playerCurrentHealth -= damageToGive;  //Players get's damage.
    }

    public void SetMaxHealth() {
        playerCurrentHealth = playerMaxHealth; 
    }
}
