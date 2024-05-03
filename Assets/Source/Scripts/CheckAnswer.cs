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


        if (_isRight)
        {
            _gameHandler.ShowRightMessage();
        }
        else
        {
            _gameHandler.ShowBadMessage();
        }

        _task.SetActive(false);
        StartCoroutine(_gameHandler.LoadNextSection());       
    }  
}
