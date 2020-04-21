using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item"; // Name of the item
    public Sprite icon = null;  // Icon of the item
    public bool isDefaultItem = false;

    public virtual void Use() {
        Debug.Log("Using " + name);
    }

}
