using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject _rightAnswer;
    [SerializeField] private GameObject _badAnswer;

    public void ShowRightMessage()
    {
        _rightAnswer.SetActive(true);
    }

    public void ShowBadMessage()
    {
        _badAnswer.SetActive(true);
    }
}
