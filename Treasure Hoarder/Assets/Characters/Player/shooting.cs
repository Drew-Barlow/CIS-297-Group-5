using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 10f;
    public PlayerMovement player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        for (int i = 0; i <= 3; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (i == 0)
            {
                rb.AddForce(firepoint.up * bulletForce + new Vector3(0, Random.Range(0, -90f), 0), ForceMode2D.Impulse);
            }else if (i == 1)
            {
                rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
            }else if (i == 2)
            {
                rb.AddForce(firepoint.up * bulletForce + new Vector3(0, Random.Range(0, 90f), 0), ForceMode2D.Impulse);
            }else if (i == 3)
            {
                rb.AddForce(firepoint.up * bulletForce + new Vector3(0, Random.Range(45f, 90f), 0), ForceMode2D.Impulse);
            }
          
    }
    //GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    //rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    //Destroy(bullet, 5.0f);


    //shotgun
    // Spawns bullet
    //var tempBullet = (GameObject)Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    //// Gets Rigidbody2D compoenent from spawned bullet
    //Rigidbody2D tempBulletRB = tempBullet.GetComponent<Rigidbody2D>();

    //// Randomize angle variation between bullets
    //float spreadAngle = Random.Range(-10, 10);

    //// Take the random angle variation and add it to the initial
    //// desiredDirection (which we convert into another angle), which in this case is the players aiming direction
    //var x = firepoint.position.x; //- player.transform.position.x; 
    //var y = firepoint.position.y; //- player.transform.position.y; 
    //float rotateAngle = spreadAngle + (Mathf.Atan2(y, x) * Mathf.Rad2Deg);

    //// Calculate the new direction we will move in which takes into account 
    //// the random angle generated
    //var MovementDirection = new Vector2(Mathf.Cos(rotateAngle * Mathf.Deg2Rad), Mathf.Sin(rotateAngle * Mathf.Deg2Rad)).normalized;

    //tempBulletRB.velocity = MovementDirection * bulletForce;
    //Destroy(tempBullet, 5.0f);
}

}

       


            
        


