using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float Health = 100;
    public GameObject drop;


    private void OnDestroy()
    {
        int randomNumber = Random.Range(0, 5);
        if (randomNumber == 3)
        {
            Instantiate(drop, transform.position, drop.transform.rotation);
        }
    }
}
