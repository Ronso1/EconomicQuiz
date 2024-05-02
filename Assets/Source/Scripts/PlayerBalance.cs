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
}
