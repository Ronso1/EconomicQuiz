using System.Collections.Generic;
using UnityEngine;

public class MessageLogic : MonoBehaviour
{
    [SerializeField] private List<GameObject> _messages;
    [SerializeField] private GameObject _currency;
    [SerializeField] private GameObject _task;
    [SerializeField] private bool _isFirst;

    private int _count = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_count == _messages.Count - 1)
            {
                if (_isFirst)
                {
                    _messages[_count].SetActive(false);
                    _currency.SetActive(true);
                }
               
                if (_task.activeSelf)
                {
                    gameObject.SetActive(false);
                    return;
                }

                _task.SetActive(true);
                return;
            }

            _messages[_count].SetActive(false);
            _count++;
            _messages[_count].SetActive(true);
        }     
    }
}
