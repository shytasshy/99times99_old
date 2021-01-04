using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numButton : MonoBehaviour
{

    [SerializeField] private Text num_text;

    void Start()
    {

    }

    public void PushNumButton(int number)
    {
        num_text.text = num_text.text + number.ToString();
    }

    public void PushDelButton()
    {
        if (num_text.text.Length!=0)
        {
            num_text.text = num_text.text.Remove(num_text.text.Length - 1);
        }
    }

    public void PushClrButton()
    {
        num_text.text = "";
    }

}
