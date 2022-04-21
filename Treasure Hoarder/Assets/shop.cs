using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    [SerializeField] private GameObject shopUI;
    [SerializeField] private bool isShopping;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isShopping)
            {
                Resume();
            }
            else
            {
                Shopping();
            }
        }
    }

    void Shopping()
    {
        isShopping = true;
        Debug.Log("Pause");
        shopUI.SetActive(true);
        Time.timeScale = 1f;

    }

    public void Resume()
    {
        isShopping = false;
        shopUI.SetActive(false);
        Time.timeScale = 0f;

        Debug.Log("resume");
    }
}
