using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numButton : MonoBehaviour
{

    [SerializeField] private Text num_text;
    [SerializeField] private Text left_num;
    [SerializeField] private Text right_num;
    [SerializeField] private Button comment_button; 
    private int ans_num;
    private int select_num;
    void Start()
    {

    }

    public void PushNumButton(int number)
    {
        num_text.text = num_text.text + number.ToString();
    }

    public void PushDelButton()
    {
        if (num_text.text.Length != 0)
        {
            num_text.text = num_text.text.Substring(0, num_text.text.Length - 1);
        }
    }

    public void PushClrButton()
    {
        num_text.text = "";
    }

    public void PushGoButton()
    {
        this.ans_num = int.Parse(left_num.text) * int.Parse(right_num.text);
        if (num_text.text.Length != 0)
        {
            this.select_num = int.Parse(num_text.text);
        }
        else
        {
            this.select_num = 0;
        }
        Debug.Log(this.ans_num==this.select_num);
        comment_button.gameObject.SetActive(true);

    }

}
