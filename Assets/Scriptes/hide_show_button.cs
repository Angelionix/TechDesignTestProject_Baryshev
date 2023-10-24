
using UnityEngine;

public class hide_show_button : MonoBehaviour
{
    [SerializeField] private GameObject _button;

    private void OnMouseDown()
    {
        bool curState = _button.activeInHierarchy;
        _button.SetActive(!curState);
    }
}
