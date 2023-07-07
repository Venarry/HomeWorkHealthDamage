using UnityEngine;
using UnityEngine.UI;

public class ButtonsHandler : MonoBehaviour
{
    [SerializeField] private HealthPresenter _healthPresenter;
    [SerializeField] private Button _addHealhButton;
    [SerializeField] private Button _damageButton;

    private void OnEnable()
    {
        _addHealhButton.onClick.AddListener(AddHealth);
        _damageButton.onClick.AddListener(ApplyDamage);
    }

    private void OnDisable()
    {
        _addHealhButton.onClick.RemoveListener(AddHealth);
        _damageButton.onClick.RemoveListener(ApplyDamage);
    }

    private void AddHealth()
    {
        const int healthValue = 20;
        _healthPresenter.AddHealth(healthValue);
    }

    private void ApplyDamage()
    {
        const int damage = 20;
        _healthPresenter.TakeDamage(damage);
    }
}
