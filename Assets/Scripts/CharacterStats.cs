using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public Stat damage;
    public Stat armor;

    public event System.Action<int, int> OnHealthChanged;

    private void Awake() {
        currentHealth = maxHealth;
        StartCoroutine(addHealth());
    }

    void Update() {

    }

    public void TakeDamage (int damage) {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;

        if(OnHealthChanged != null) {
            OnHealthChanged(maxHealth, currentHealth);
        }

        if (currentHealth <= 0) {
            Die();
        }
    }

    public virtual void Die() {
        Destroy(gameObject);
    }

    IEnumerator addHealth() {
        while (true) {
            if (currentHealth < maxHealth) { // If the player current health is less than his max health
                currentHealth += 1;  // The players current health will increase by 1 

                yield return new WaitForSeconds(1); // Every seconds, the player will gain one health
            }
            else {
                yield return null;  //Onces the player is full health, the loop ends.

            }
        }
    }
}
