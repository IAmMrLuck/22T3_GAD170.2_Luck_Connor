using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    // used for testing the functionality of the buttons
    // have now added functionaity to the text box on screen - still working on that

    int n;
    public Text myText;
    public void OnButtonPress()
    {
        n++;
        myText.text = "Clicked " + n + " times.";

    }
}