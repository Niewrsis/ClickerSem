using UnityEngine;

public class SetActiveScript : MonoBehaviour
{
    [SerializeField] private GameObject _upgraderMenu;
    private void Awake()
    {
        _upgraderMenu.SetActive(false);
    }
}
