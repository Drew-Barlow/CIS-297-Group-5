using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Collider2D col;
    private Collider2D colPlayer;
    public GameObject player;
    public float speed;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        colPlayer = player.GetComponent<Collider2D>();
    }

    void Update()
    {
        //Debug.Log(gameObject.transform.position);
        if (col.IsTouching(colPlayer))
        {
            rb.velocity = new Vector2(0, 0);
        }
        
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = gameObject.transform.position + ((player.transform.position - gameObject.transform.position).normalized * speed * Time.fixedDeltaTime);
        if((gameObject.transform.position-player.transform.position).x > 0)
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
