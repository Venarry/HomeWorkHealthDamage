using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] private Image _bar;
    private Coroutine _activeCoroutine;

    public void Init(float startNoralizedValue)
    {
        _bar.fillAmount = startNoralizedValue;
    }

    public void SetNormalizedValue(float value)
    {
        if (_activeCoroutine != null)
            StopCoroutine(_activeCoroutine);

        _activeCoroutine = StartCoroutine(ChangeValue(value));
    }

    private IEnumerator ChangeValue(float targetValue)
    {
        float healthChangeSpeed = 0.1f;

        while (_bar.fillAmount != targetValue)
        {
            _bar.fillAmount = Mathf.Lerp(_bar.fillAmount, targetValue, healthChangeSpeed);
            float minDifference = 0.02f;

            if (Mathf.Abs(_bar.fillAmount - targetValue) < minDifference)
            {
                _bar.fillAmount = targetValue;
            }

            yield return null;
        }
    }
}
