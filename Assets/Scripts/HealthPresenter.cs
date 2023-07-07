using System;
using UnityEngine;

[RequireComponent(typeof(Bar))]
public class HealthPresenter : MonoBehaviour
{
    private const int MaxHealth = 100;
    private Health _health = new Health(MaxHealth);
    private Bar _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Bar>();
    }

    private void Start()
    {
        OnHealthChanged();
    }

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }

    public void TakeDamage(int damage) => _health.TakeDamage(damage);
    public void AddHealth(int value) => _health.AddHealth(value);

    private void OnHealthChanged()
    {
        float normalizedHealth  = (float)_health.Value / _health.MaxValue;
        _healthBar.SetNormalizedValue(normalizedHealth);
    }
}
