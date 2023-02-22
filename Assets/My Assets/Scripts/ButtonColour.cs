using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonColour : MonoBehaviour
{
    public Button clickingButton;

    public MainMenuManager usingButtons;

    public void OnButtonClick()
    {
        //get the color
        Vector4 myButtonsColor = clickingButton.image.color;

        usingButtons.SetColor(myButtonsColor);
    }
}
