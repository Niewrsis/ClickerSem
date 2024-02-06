using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class ClickerZone : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;
    [SerializeField] private TextMeshProUGUI _moneyTextMenu;

    [SerializeField] private Button _clickZone;
    
    public static int Money = 0;
    public static int ClickForce = 1;

    private void Start()
    {
        _moneyText.text = $"{Money}$";
        _moneyTextMenu.text = $"{Money}$";
        
        _clickZone.onClick.AddListener(Click);
    }

    void Click()
    {
        Money += ClickForce;
        _moneyText.text = $"{Money}$";
        _moneyTextMenu.text = $"{Money}$";
    }
}
