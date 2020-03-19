using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    [Header("UI Components")]
    [SerializeField] private TextMeshProUGUI moneyText;
    
    [Header("Tax Rates")]
    [SerializeField] private float catchTaxRate = 1.25f;
    
    static private float bank;
    
    // TODO: Buffer Transactions, Afford Calculations
    private bool transacting;

    private void Start()
    {
        bank = 30f;
        UpdateText();
    }

    public bool CanAfford(float amount)
    {
        return amount <= bank;
    }

    public void AddFunds(float amountToAdd)
    {
        bank += amountToAdd;
        UpdateText();
    }

    public void AddCatch(float weight)
    {
        AddFunds(catchTaxRate * weight);
    }

    public void SpendMoney(float amount)
    {
        bank -= amount;
        UpdateText();
    }

    public void UpdateText()
    {
        moneyText.text = "Money: $ " + bank.ToString("F2");
    }
}
