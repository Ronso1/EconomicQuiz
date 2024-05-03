using System.Collections;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject _rightAnswer;
    [SerializeField] private GameObject _badAnswer;
    [Space]
    [SerializeField] private GameObject _firstSection;
    [SerializeField] private GameObject _secondSection;

    public void ShowRightMessage()
    {
        _rightAnswer.SetActive(true);
    }

    public void ShowBadMessage()
    {
        _badAnswer.SetActive(true);
    }

    public IEnumerator LoadNextSection()
    {
        yield return new WaitForSeconds(1f);
        _firstSection.SetActive(false);
        _secondSection.SetActive(true);
    }
}
