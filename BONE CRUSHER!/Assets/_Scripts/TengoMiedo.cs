using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TengoMiedo : MonoBehaviour
{
    private Button _button;

    void Start()
    {
        _button = GetComponent<Button>();
        {
            _button.onClick.AddListener(ByeBye);
        }
    }

    void ByeBye()
    {
        {

            Application.Quit();
        }
    }
}
    


