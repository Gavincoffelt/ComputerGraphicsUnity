using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationParameters : MonoBehaviour
{
    // Parameter Int to set animation
    public int ParamInt = 0;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
    }
   public void ButtonSelect(Button button)
    {
        string buttonName = button.name;
        switch(buttonName)
        {
            case "Walk":
                ParamInt = 1;
                break;
            case "Lose":
                ParamInt = 2;
                break;
            case "Win":
                ParamInt = 3;
                break;
            default:
                break;
        }
        anim.SetInteger("ParamInt", ParamInt);



    }
}
