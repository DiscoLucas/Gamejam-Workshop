using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public string labelText = "The Sharknado is loose! Destroy all military bases to win!";
    public int milBases = 4;


    private int destroyedBases = 0;

    //The get collects the value from the above variable, and then the set gives the variable a new value
    public int Bases
    {
        get { return destroyedBases; }
        set { destroyedBases = value; }
    }


    private void OnGUI()
    {
        //UI boxes, which are placed through trial and error on the screen. 
        GUI.Box(new Rect((Screen.width / 10), (Screen.height / 1.3f), 350, 30), labelText);
        GUI.Box(new Rect((Screen.width / 10), (Screen.height / 1.2f), 150, 30), (destroyedBases + " of 4 bases destroyed"));
    }
}
