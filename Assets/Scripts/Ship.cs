using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace ConnorLuck
{

    public class Ship : MonoBehaviour
    {
        public Text Textfield;

        public void SetText(string text)
        {
            Textfield.text = text;
        }
        public GameObject CrewMates;
        private string names;
        private string trueHobbies;
        private string falseHobbies;
        bool parasite = false;
        private CrewMate newCrewMate;
        private GameObject newCrewMateGO;

        public List<CrewMate> CrewMatesList = new List<CrewMate>();

 
        // used to reference as OnClick() in the inspector
        public void OnCrewClick()
        {
            newCrewMateGO = Instantiate(CrewMates);
            newCrewMate = newCrewMateGO.GetComponent<CrewMate>();

        }
        // used to reference as OnClick() in the inspector
        public void OnRejectClick()
        {
            Destroy(newCrewMate.gameObject);
        }
        // used to reference as OnClick() in the inspector
        public void OnAcceptClick()
        {

            CrewMatesList.Add(newCrewMate);

        }

    }


}


