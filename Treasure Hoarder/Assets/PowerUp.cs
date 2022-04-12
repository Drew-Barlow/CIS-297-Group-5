using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float duration = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(Pickup(collision));
        }
    }

    private IEnumerator Pickup(Collider2D player)
    {
        PlayerStats speed = player.GetComponent<PlayerStats>();
        speed.moveSpeed += 3;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(duration);
        speed.moveSpeed -= 3;
        Destroy(gameObject);
    }
}

