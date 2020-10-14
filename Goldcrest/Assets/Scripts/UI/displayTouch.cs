// A useful tool for presenting on a screen to display where finger is pressed

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayTouch : MonoBehaviour
{
    private Image touchPos;

    private void Start()
    {
        touchPos = GetComponent<Image>();
        touchPos.enabled = !touchPos.enabled;

    }
    void Update()
    {
        if (Input.touchCount > 0) // Detects a finger press
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {

                case TouchPhase.Began: // Shows the image and sets location to touch position
                    touchPos.enabled = !touchPos.enabled;
                    transform.position = new Vector2(touch.position.x, touch.position.y);

                    break;

                case TouchPhase.Moved: // Moves image to follow finger position
                    transform.position = new Vector2(touch.position.x, touch.position.y);
                    break;

                case TouchPhase.Stationary: // Maintains position while finger is held
                    transform.position = new Vector2(touch.position.x, touch.position.y);
                    break;

                case TouchPhase.Ended: // Hides the image when finger is lifted
                    touchPos.enabled = !touchPos.enabled;

                    break;
            }
        }
    }
}
