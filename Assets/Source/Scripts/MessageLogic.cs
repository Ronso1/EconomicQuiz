using System.Collections.Generic;
using UnityEngine;

public class MessageLogic : MonoBehaviour
{
    [SerializeField] private List<GameObject> _messages;

    private int _count = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_count == _messages.Count - 1)
            {
                return;
            }

            _messages[_count].SetActive(false);
            _count++;
            _messages[_count].SetActive(true);
        }     
    }
}
