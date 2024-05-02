using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private GameHandler _gameHandler;
    [SerializeField] private PlayerBalance _playerBalance;
    [SerializeField] private GameObject _task;
    [SerializeField] private float _result;
    [SerializeField] private bool _isRight;

    public void CheckPlayerAnswer()
    {
        var currentValue = 0f;
        currentValue = _playerBalance.GetBalance();
        currentValue -= _result;
        _playerBalance.SetNewValue(currentValue);
        _task.SetActive(false);


        if (_isRight)
        {
            _gameHandler.ShowRightMessage();
        }
        else
        {
            _gameHandler.ShowBadMessage();
        }
    }
}
