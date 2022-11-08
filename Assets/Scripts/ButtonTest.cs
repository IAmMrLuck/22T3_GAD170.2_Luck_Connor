using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    // used for testing the functionality of the buttons

    int n;
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Clicked " + n + " times.");
    }
}