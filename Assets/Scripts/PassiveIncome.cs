using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PassiveIncome : MonoBehaviour
{
    private float passiveIncomeInterval = .5f;
    private float nextPassiveIncomeTime = 0f;
    
    [SerializeField] private TextMeshProUGUI _costText;
    [SerializeField] private Button _button;

    private int _passiveForce;
    private int _passiveCost = 200;
    public static bool _passiveIncome;

    void Start()
    {
        _costText.text = $"{_passiveCost}$";
        _button.onClick.AddListener(PassiveForce);
        _button.onClick.AddListener(PassiveCheck);
    }

    void Update()
    {
        if (_passiveIncome == true)
        {
            if (Time.time > nextPassiveIncomeTime)
            {
                PassiveForce();
                nextPassiveIncomeTime = Time.time + passiveIncomeInterval;
            }
        }
    }

    void PassiveForce()
    {
            ClickerZone.Money += _passiveForce;
    }

    void PassiveCheck()
    {
        if (ClickerZone.Money >= _passiveCost)
        {
            ClickerZone.Money -= _passiveCost;
            _passiveCost = _passiveCost * 2;
            _passiveForce++;
            _costText.text = $"{_passiveCost}$";
            _passiveIncome = true;
        }

    }
}
