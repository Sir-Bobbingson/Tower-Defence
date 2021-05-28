using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyHandler : MonoBehaviour
{
    #region Money Stuff

    [Header("Money")]
    public static int money;
    public static int magicMoney;

    public int currentMoney;
    public int currentMagic;

    public Text moneyText;
    public Text magicMoneyText;

    [SerializeField] private int startMoney = 200;

    #endregion

    #region Taxes

    [Header("Taxes")]
    public static int people = 10;
    public int taxesPerPerson = 10;
    [SerializeField] private int taxTiming = 60;

    #endregion


    void Start()
    {
        money = startMoney;
        UpdateMoneyText();
        UpdateMagicMoneyText();
        StartCoroutine(Taxes());
    }

    private void Update()
    {
        if(money != currentMoney)
        {
            UpdateMoneyText();
            currentMoney = money;
        }

        if (magicMoney != currentMagic)
        {
            UpdateMagicMoneyText();
            currentMagic = magicMoney;
        }
    }

    void Upgrade()
    {



    }

    void Buy()
    {



    }

    void Sell()
    {



    }

    IEnumerator Taxes()
    {
        for (int i = 0; i < 50; i++)
        {
            money += taxesPerPerson * people;
            
            yield return new WaitForSeconds(taxTiming);
        }
    }

    void UpdateMoneyText()
    {
        moneyText.text = "Money: $" + money;
    }

    void UpdateMagicMoneyText()
    {
        magicMoneyText.text = "Magic Stuff: $" + magicMoney;
    }
}
