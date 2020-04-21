﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : Interactable
{
    public Item item;
    public override void Interact() {
        base.Interact();

        Pickup();
    }

        void Pickup() {
        Debug.Log("Picking up item" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp) {
            Destroy(gameObject);
            }
        }

}
