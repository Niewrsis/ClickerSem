using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickForce : MonoBehaviour
{
    [SerializeField] private Button _upgradeButton;
    
    [SerializeField] private TextMeshProUGUI _costText;

    private int _upgradeCost = 100;

    private void Start()
    {
        _costText.text = $"{_upgradeCost}$";
        _upgradeButton.onClick.AddListener(ClickForceUpgrader);
    }

    void ClickForceUpgrader()
    {
        if (ClickerZone.Money >= _upgradeCost)
        {
            ClickerZone.ClickForce++;
            ClickerZone.Money -= _upgradeCost;
            _upgradeCost = _upgradeCost + 100;
            _costText.text = $"{_upgradeCost}$";
        }
    }
}
