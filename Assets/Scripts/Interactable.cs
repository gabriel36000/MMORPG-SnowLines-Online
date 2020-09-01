using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    bool hasInteracted = false;
    bool isFocus = false;
    Transform player;
    public Transform interactionTransform;

    public virtual void Interact() {
        // This method is meant to be overwritten
        print("Interacting with" + transform.name);
    }
    void Update() {
        if (isFocus && !hasInteracted) {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius) {
                Interact();
                hasInteracted = true;
            }
        }
    }
    public void OnFocused(Transform playerTransform) {
        isFocus = true;
        player = playerTransform;
    }

    void OnDrawGizmosSelected () {
        if(interactionTransform == null) {
            interactionTransform = transform;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);

        }

    public void OnDefocused() {
        isFocus = false;
        player = null;
    }

}
