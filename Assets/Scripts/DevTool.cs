using System;
using UnityEngine;

public class DevTool : MonoBehaviour
{
    [SerializeField] private GameObject uiWindow;
    private bool isWindowOpen;

    private void Start()
    {
        isWindowOpen = false;
        uiWindow.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            ToggleUIWindow();
        }
    }

    public void ToggleUIWindow()
    {
        isWindowOpen = !isWindowOpen;
        
        uiWindow.SetActive(isWindowOpen);
    }
    
    private string _input;
    
    public void ReadStringInput(string s)
    {
        _input = s;
        string[] words = _input.Split(' ');

        if (words[0] == "add")
        {
            if (words[1] == "money")
            {
                ClickerZone.Money += Convert.ToInt32(words[2]);
            }
            else
                Debug.Log("Ошибка синтаксиса");
        }
        else if (words[0] == "reduce")
        {
            if (words[1] == "money")
            {
                if (Convert.ToInt32(words[2]) <= ClickerZone.Money)
                    ClickerZone.Money -= Convert.ToInt32(words[2]);
                else
                    Debug.Log("Сликшом большая сумма");
            }
            else
                Debug.Log("Ошибка синтаксиса");
        }
        else
            Debug.Log("Ошибка синтаксиса");
    }
    
}
