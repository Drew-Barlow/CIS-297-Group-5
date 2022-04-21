using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemShopManagerScript : MonoBehaviour
{
    public int[,] ItemShop = new int[3, 3];
    public float GameMoney;
    public Text Players_Money;

    void Start()
    {
        //Weapon ID
        Players_Money.text = GameMoney.ToString();
        ItemShop[1, 0] = 0;
        ItemShop[1, 1] = 1;
        ItemShop[1, 2] = 2;

        //Game Price
        ItemShop[2, 0] = 5;
        ItemShop[2, 1] = 10;
        ItemShop[2, 2] = 15;

        //Game Quantity
        ItemShop[3, 0] = 0;
        ItemShop[3, 1] = 0;
        ItemShop[3, 2] = 0;
    }

    // Update is called once per frame
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (GameMoney >= ItemShop[2, ButtonRef.GetComponent<ButtonInfo>().WeaponID])
        {
            GameMoney -= ItemShop[2, ButtonRef.GetComponent<ButtonInfo>().WeaponID];
            ItemShop[3, ButtonRef.GetComponent<ButtonInfo>().WeaponID]++;
            Players_Money.text = GameMoney.ToString();
            ButtonRef.GetComponent<ButtonInfo>().Quantity.text = ItemShop[3, ButtonRef.GetComponent<ButtonInfo>().WeaponID].ToString();
        }
    }
}
