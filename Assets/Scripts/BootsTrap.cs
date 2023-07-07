using UnityEngine;

public class BootsTrap : MonoBehaviour
{
    [SerializeField] private Bar _healthBar;

    private void Awake()
    {
        float startBarValue = 1f;
        _healthBar.Init(startBarValue);
    }
}
