using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject parent;
    public Camera localCamera;

    private GameObject clone;
    Vector3 position;

    void Start()
    {
        
    }

    void Update()
    {
        position = localCamera.ScreenToWorldPoint((new Vector3(Random.Range(0, localCamera.scaledPixelWidth), localCamera.scaledPixelHeight, 0)));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(position);
            Instantiate(enemy, position, Quaternion.identity, parent.transform);
        }

        
    }
}
