using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enter : MonoBehaviour
{
    public InputField inputField;

    public void OnButtonClicked()
    {
        string input = inputField.text;
        Debug.Log("Input: " + input);
    }
}
