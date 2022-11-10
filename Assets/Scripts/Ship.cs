using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

using ConnorLuck;

public class Ship : MonoBehaviour
{
    private List<CrewMates> shipList = new List<CrewMates>();

    private void Start()
    {
        for(int i = 0; i < shipList.Count; i++)
        {
            shipList[i].GetInstanceID();
        }
    }
    
}
