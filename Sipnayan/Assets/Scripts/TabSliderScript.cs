using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSliderScript : MonoBehaviour
{
    private bool tabChecker;

    public void EnableBoolAnimator(Animator anim)
    {
        if (tabChecker == false)
        {
            anim.SetBool("IsDisplayed", true);
            tabChecker = true;
        }
        else
        {
            anim.SetBool("IsDisplayed", false);
            tabChecker = false;
        }
    }
}
