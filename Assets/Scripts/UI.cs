using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public Text mainText;
    public Button reject;
    public Button accept;


    // Start is called before the first frame update
    void Start()
    {
        mainText.text = "test";
        reject.GetComponentInChildren<Text>().text = "Reject!";
        accept.GetComponentInChildren<Text>().text = "Accept :)";
    }
}