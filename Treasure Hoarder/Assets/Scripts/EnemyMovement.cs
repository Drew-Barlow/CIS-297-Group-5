using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Collider2D col;
    public GameObject player;
    public float speed;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        //Debug.Log(gameObject.transform.position);
        if (col.IsTouching(col))
        {
            //rb.AddForce(new Vector2(col.))
        }
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = gameObject.transform.position + ((player.transform.position - gameObject.transform.position).normalized * speed * Time.fixedDeltaTime);
    }
}
