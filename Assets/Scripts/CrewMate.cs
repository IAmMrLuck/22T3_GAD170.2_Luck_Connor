using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
using UnityEngine.UI;

namespace ConnorLuck
{
    public class FullName : MonoBehaviour

    {
        // this string is used the forecah loop 
        public string value;
      
    }
    public class CrewMate : MonoBehaviour
    {

        // set up string list for using in the foreach loop whic will populate in the TextBox when the Crew Application is clicked

       
        public Text mainText;

        [SerializeField] FullName CrewMates;

        [SerializeField] public List<FullName> crew;
        // list of names to be called by the foreach statement below
        public string[] names = new string[12] { "Brock", "Misty", "Lt.Surge", "Erika", "Koga", "Sabrina", "Blaine", "Giovanni", "Lorelei", "Bruno", "Agatha", "Lance" };
        // list of hobbies to be pulled by the regular crewMates
        public string[] trueHobbies = new string[12] { "Rock Climbing", "Swimming", "Electrical Engineering", "Gardening", "Ninjas", "Magic Tricks", "Fire Breathing", "Crime Boss", "Ice Skating", "Weight Lifting", "Ghost hunting", "Dragon Taming" };
        // smaller list to be called if the crewmate generates a parasite
        public string[] falseHobbies = new string[4] { "The Water", "The Air", "The Fire", "The Earth" };
        // the boolean for parasite
        bool parasite = false;
        // an int stored to get a random range later
        int myInt = 0;


        public void Update()
        {
            {

                parasite = myInt > 11;

                crew = new List<FullName>();

                foreach (string value in names)
                {
                    FullName newCrew = Instantiate(CrewMates);

                    newCrew.name = value;

                    crew.Add(newCrew);

                }

                int randomNumber;
                int lastNumber;
                int maxAttempts = 15; // the number of rounds (0-15)

                void RandomNumberGen()

                { // I have asked the code to check that it will not reuse a number more than once, to assist in cycling through the 16 hobby options
                    for (int i = 0; randomNumber == lastNumber && i < maxAttempts; i++)
                    {
                        randomNumber = Random.Range(0, 15);
                    }
                    lastNumber = randomNumber;
                }
                // if int > 11 then parasite - because the system will include 0
                // the code is first checking if myInt is a number which is greater than 11 (12, 13, 14, 15)
                if (parasite)
                {

                    // once the code has decided on the number, if it is higher than 11 it will add a falseHobby to the CrewMate
                    foreach (string value in falseHobbies)
                    {
                        FullName newCrew = Instantiate(CrewMates);

                        newCrew.name = value;

                        crew.Add(newCrew);
                    }
                }

                else
                {
                    foreach (string value in trueHobbies)
                    {
                        FullName newCrew = Instantiate(CrewMates);

                        newCrew.name = value;

                        crew.Add(newCrew);

                    }
                }
            }
        }


        public void SetStringStore(string[] newName, string[] newHobby, string[] fakeHobby, bool isParasite)
        {
            names = newName;
            trueHobbies = newHobby;
            falseHobbies = fakeHobby;
            parasite = isParasite;

        }

    }
}
