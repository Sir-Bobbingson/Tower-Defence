using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyHandler : MonoBehaviour
{
    #region Statics

    public static int money;
    public static int magicMoney;
    public static int people = 10;

    #endregion

    #region Money Stuff

    [Header("Money")]
    public int currentMoney;
    public int currentMagic;
    [SerializeField] private int startMoney = 200;

    #endregion

    #region Taxes

    [Header("Taxes")]
    public int currentPeople;
    public int taxesPerPerson = 10;
    [SerializeField] private int taxTiming = 60;

    #endregion

    #region UI Elements

    [Header("UI Stuff")]
    public Text moneyText;
    public Text magicMoneyText;
    public Text peopleText;
    public GameObject gameOverPanel;

    #endregion

    void Start()
    {
        money = startMoney;
        UpdateMoneyText();
        UpdateMagicMoneyText();
        UpdatePeopleText();
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

        if (people != currentPeople)
        {
            UpdatePeopleText();
            currentPeople = people;
        }

        if (people == 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
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

    #region Updating Text

    void UpdateMoneyText()
    {
        moneyText.text = "Money: $" + money;
    }

    void UpdateMagicMoneyText()
    {
        magicMoneyText.text = "Magic Stuff: $" + magicMoney;
    }

    void UpdatePeopleText()
    {
        peopleText.text = "Citizens: " + people;
    }

    #endregion
}
