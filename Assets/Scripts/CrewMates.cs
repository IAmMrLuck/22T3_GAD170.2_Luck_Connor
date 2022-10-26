using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConnorLuck 
{ 


public class CrewMates : MonoBehaviour
{

        private CrewMates prefab;


        private List<CrewMates> ship;
        private string[] values = new string[10] { "Mark", "Matthew", "Luke", "John", "Judas", "Noah", "Jesus", "Mary", "Joseph", "Willy" };

        private void Start()
        {
            foreach (string value in values)
            {
                foreach (CrewMates crewMates in ship)
            }
        }


    }

}
