using System;
using UnityEngine;

public class Health
{
    public event Action Changed;
    
    public Health(int maxHealth)
    {
        MaxValue = maxHealth;
        Value = maxHealth;
    }

    public int Value { get; private set; }
    public int MaxValue { get; private set; }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            damage = 0;

        Value -= damage;

        if(Value < 0)
            Value = 0;

        Changed?.Invoke();
    }

    public void AddHealth(int value)
    {
        if(value < 0)
            value = 0;

        Value += value;

        if(Value > MaxValue)
            Value = MaxValue;

        Changed?.Invoke();
    }
}
