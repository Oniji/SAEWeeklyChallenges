/**********************************************
 * WeekOneChallenges.cs
 * 
 * The purpose of this code is to learn how to script in C#
 * It initialises a number of personal information variables
 * and outputs a sentence string out to Unity Console
 * 
 * Created by Chris Casmenco 2019
 *
 * ********************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOneChallenges : MonoBehaviour
{
    // Variables
    private string myName = "Chris Casmenco";
    private int myAge = 29;
    private string myDOB = "01/01/1990";
    private float myHeight = 180.00f;
    private double myHeightDouble = 180.0; // Unused variable for learning purposes
    private bool wearingWatch = false;
    private int myFavNum = 53;
    private char myInitial = 'J'; // Unused variable for learning purposes

    // Start is called before the first frame update
    void Start()
    {
        
        int favNumAge = myAge + myFavNum; // Combining age with favourite number
        string rumourState = ""; // Holds the wearing watch rumour state

        // Adds 'not' to the rumour declaration if person not wearing watch
        if (wearingWatch == false) { rumourState = "not"; }

        // Output sentence for weekly challenge
        Debug.Log(string.Format("Hi, my name is: {0}, my age in years is {1}, that means my date of birth is {2}, " +
                                "I am {3} cm tall and the rumours you have heard are {4}, I am {5} wearing a watch. " +
                                "Finally my favorite number is {6} which if added my age to it would give me a number of {7}.", 
                                myName, myAge, myDOB, myHeight, wearingWatch, rumourState, myFavNum, favNumAge));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
