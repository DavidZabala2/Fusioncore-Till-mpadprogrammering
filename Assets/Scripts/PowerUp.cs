using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {



    public GameObject pickupEffect;
    public float multiplier = 1.4f;
    public float duration = 4f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }
    IEnumerator Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Debug.Log("Power up picked up");
        PlayerController speedy = player.GetComponent<PlayerController>();
        PlayerController Jumps = player.GetComponent<PlayerController>();
        speedy.speed *= multiplier;
        Jumps.jumpForce *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        

        yield return new WaitForSeconds(duration);

        speedy.speed /= multiplier;
        Jumps.jumpForce /= multiplier;

        Destroy(gameObject);
        Destroy(pickupEffect);

    }
}
