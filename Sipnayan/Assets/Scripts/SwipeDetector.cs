using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwipeDetector : MonoBehaviour
{
    private float minSwipeDistY;
    private float minSwipeDistX;
    public Animator anim1;
    public Vector2 startPos;

    public void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                case TouchPhase.Ended:
                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                    float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

                    if (swipeDistHorizontal > swipeDistVertical)
                    {
                        if (swipeDistHorizontal > minSwipeDistX)
                        {
                            float swipeValueX = Mathf.Sign(touch.position.x - startPos.x);

                            if (swipeValueX > 0)//right swipe
                            {
                                anim1.SetBool("IsDisplayed", true);
                            }

                            else if (swipeValueX < 0)//left swipe
                            {
                                anim1.SetBool("IsDisplayed", false);
                            }
                        }
                    }

                    else if (swipeDistHorizontal < swipeDistVertical)
                    {
                        if (swipeDistVertical > minSwipeDistY)
                        {
                            float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                            if (swipeValue > 0)//up swipe
                            {
                                //anim.SetBool("IsDisplayed", true);
                            }
                            else if (swipeValue < 0)//down swipe
                            {
                                //anim.SetBool("IsDisplayed", false);
                            }
                        }
                    }
                    break;
            }
        }
    }
}