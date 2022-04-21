using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Coin : MonoBehaviour
{
    public Text currencyUI; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pickup(collision);
            FindObjectOfType<AudioManager>().Play("Coin Collect");
        }
    }
    private void Update()
    {
        currencyUI.GetComponent<Text>().text = PlayerStats.Tabloons.ToString();
    }
    private void Pickup(Collider2D player)
    {
        PlayerStats.Tabloons += 1; 
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject);
    }
}
