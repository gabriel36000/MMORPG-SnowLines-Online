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
    public Text HP_Current_And_Max;
    public Transform target;


    

    public 
    void Start()
    {
        playerCurrentHealth = playerMaxHealth; // The Player will spawn with max health
        StartCoroutine(addHealth());


        
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerMaxHealth;
        slider.value = playerCurrentHealth;

        HP_Current_And_Max.text = "" + playerCurrentHealth + "/" + playerMaxHealth;
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

    IEnumerator addHealth() { 
        while (true) {
            if (playerCurrentHealth < playerMaxHealth) { // If the player current health is less than his max health
                playerCurrentHealth += 1;  // The players current health will increase by 1 

                yield return new WaitForSeconds(1); // Every seconds, the player will gain one health
            }
            else {
                yield return null;  //Onces the player is full health, the loop ends.
               
            }
        }
    }
}
