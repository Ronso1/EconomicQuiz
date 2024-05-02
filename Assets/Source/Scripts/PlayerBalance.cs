using UnityEngine;
using TMPro;

public class PlayerBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _valueOnDisplay;
    [SerializeField] private float _value = 1000f;

    private void Start()
    {
        _valueOnDisplay.text = $"Текущий баланс: {_value} руб.";
    }

    public float GetBalance() => _value;

    public void SetNewValue(float value)
    {
        _value = value;
        _valueOnDisplay.text = $"Текущий баланс: {_value} руб.";
    }
}
