using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject warningText;
    private bool _isWarrningTextOpened = false;
    public void WarningTextOpener()
    {
        if (_isWarrningTextOpened)
        {
            warningText.SetActive(false);
            _isWarrningTextOpened = false;
        }
        else
        {
            warningText.SetActive(true);
            _isWarrningTextOpened = true;
        }
    }
}
