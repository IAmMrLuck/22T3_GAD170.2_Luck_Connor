using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConnorLuck 
{ 


    public class CrewMates : MonoBehaviour
    {
        private string[] crewMatesArray = new string[10] { "Brock", "Misty", "Lt.Surge", "Erika", "Koga", "Sabrina", "Blaine", "Giovanni", "Red", "Blue" };

        private List<string> crewMatesList = new List<string>() { "Brock", "Misty", "Lt.Surge", "Erika", "Koga", "Sabrina", "Blaine", "Giovanni", "Red", "Blue" };

        private void Start()
        {
            //foreach string in crewMatesarray call random name
            foreach (var item in crewMatesArray)
            {

                Console.WriteLine(crewMatesArray);
                
            }
              

        }


    }

}
