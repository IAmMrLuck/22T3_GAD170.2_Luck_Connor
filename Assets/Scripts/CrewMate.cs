using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace ConnorLuck
{
    public class FullName : MonoBehaviour

    {
        public string value;
      
    }
    public class CrewMate : MonoBehaviour
    {

        public Text mainText;

        [SerializeField] FullName CrewMatesPrefab;

        [SerializeField] private List<FullName> crew;
        // list of names to be called by the foreach statement below
        public string[] names = new string[12] { "Brock", "Misty", "Lt.Surge", "Erika", "Koga", "Sabrina", "Blaine", "Giovanni", "Lorelei", "Bruno", "Agatha", "Lance" };
        // list of hobbies to be pulled by the regular crewMates
        public string[] trueHobbies = new string[12] { "Rock Climbing", "Swimming", "Electrical Engineering", "Gardening", "Ninjas", "Magic Tricks", "Fire Breathing", "Crime Boss", "Ice Skating", "Weight Lifting", "Ghost hunting", "Dragon Taming" };
        // smaller list to be called if the crewmate generates a parasite
        public string[] falseHobbies = new string[4] { "The Water", "The Air", "The Fire", "The Earth" };
        // the boolean for parasite
        bool parasite = false;


        private void Start()
        {
            mainText.text = FullName.crew;
            
        }

        public void OnCrewClick()
        {

            crew = new List<FullName>();


            foreach (string value in names)
            {
                FullName newCrew = Instantiate(CrewMatesPrefab, transform);

                newCrew.name = value;

                crew.Add(newCrew);

            }

            // if int > 8 then parasite

            if (!parasite)

            {
                foreach (string value in falseHobbies)
                {
                    FullName newCrew = Instantiate(CrewMatesPrefab, transform);

                    newCrew.name = value;

                    crew.Add(newCrew);
                }
            }

            else
            {
                foreach (string value in trueHobbies)
                {
                    FullName newCrew = Instantiate(CrewMatesPrefab, transform);

                    newCrew.name = value;

                    crew.Add(newCrew);

                }
            }
        }

        public void OnRejectClick()
        {
            Destroy(gameObject);
        }

        public void OnAcceptClick()
        {
            
        }
        /*
        public void SetInitialStats(string newName, string newHobby, int isParasite)
        {
            name = newName;
            hobby = newHobby;
            parasite = isParasite;

        }*/

    }
}
