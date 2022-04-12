using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float Health = 100;

    public List<Transform> items = new List<Transform>();

    private void OnDestroy()
    {
        Destroy(gameObject);
        int randomNumber = Random.Range(0, 5);
        if (randomNumber == 3)
        {
            Instantiate(items[Random.Range(0, items.Count - 1)], transform.position, Quaternion.identity);
        }
    }
}
