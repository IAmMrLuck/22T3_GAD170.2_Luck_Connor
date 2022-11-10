using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// this was an old script which got a little out of hand 
// so i have changed the name to CrewMate(s) and started fresh
// I have elected not to remove any working which did not benefit my scripts - for the purposes of growth and learning

namespace ConnorLuck 
{ 
   

    public class CrewMates : MonoBehaviour
    {
    

        // creating a list of names for the game by using an array and a list
        // this is not needed 
        // string[] crewMatesArray = new string[10] { "Brock", "Misty", "Lt.Surge", "Erika", "Koga", "Sabrina", "Blaine", "Giovanni", "Red", "Blue" };

        private List<string> crewMatesList = new List<string>() { "Brock", "Misty", "Lt.Surge", "Erika", "Koga", "Sabrina", "Blaine", "Giovanni", "Red", "Blue" };

        //creating a list of names for the game by using the same as above - I will need to do this for the realHobbies and the fakeHobbies
        private string[] realHobbiesArray = new string[10] { "Bouldering", "Swimming", "Electrical", "Gardening", "Ninjas", "Magic Tricks", "Fire Breathing", "Organised Crime", "Being the Best", "Being the Worst" };

        //do not need both an array and a list - instantiating 
        //private List<string> realHobbiesList = new List<string>() { "Bouldering", "Swimming", "Electrical", "Gardening", "Ninjas", "Magic Tricks", "Fire Breathing", "Organised Crime", "Being the Best", "Being the Worst" };


        public void CallNextCrewMate(string newName, string newHobby, string newFakeHobby)
        {

            // this is the method to call the crew mates names and hobbies
            name = newName;
            //hobby = newHobby;
            //fakeHobby = newFakeHobby;

        }

        private void Start()
        {
            //foreach string in crewMatesarray call random name
            foreach (string item in crewMatesList)
            {

                Console.WriteLine(crewMatesList);
                
            }
              

        }


    }

}
