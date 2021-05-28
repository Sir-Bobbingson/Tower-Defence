using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int enemyLoot = 50;
    CurrencyHandler moneyScript;


    void Start()
    {
        // This gets the Game Object we need that has the tag
        GameObject playerStatObject = GameObject.FindGameObjectWithTag("money");
        // this line gets the actual Script Component we wrote
        moneyScript = playerStatObject.GetComponent<CurrencyHandler>();
    }
        // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CurrencyHandler.magicMoney += enemyLoot;
        }
    }
}
