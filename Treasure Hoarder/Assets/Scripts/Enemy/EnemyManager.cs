using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject skeleton;
    public GameObject barrel;
    public GameObject thief;
    public GameObject bringer;
    public GameObject parent;
    public Camera localCamera;

    private GameObject clone;
    Vector3 position;

    void Start()
    {
        
    }

    void Update()
    {
        position = localCamera.ScreenToWorldPoint((new Vector3(Random.Range(0, localCamera.scaledPixelWidth), localCamera.scaledPixelHeight, 100)));
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Debug.Log(position);
            Instantiate(skeleton, position, Quaternion.identity, parent.transform);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Debug.Log(position);
            Instantiate(barrel, position, Quaternion.identity, parent.transform);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Debug.Log(position);
            Instantiate(thief, position, Quaternion.identity, parent.transform);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //Debug.Log(position);
            Instantiate(bringer, position, Quaternion.identity, parent.transform);
        }
    }
}
