using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeventhButton : MonoBehaviour
{
    public Text buttonText;

    public void PlaceSymbol()
    {
        if (GameObject.Find("Main Camera").GetComponent<StartScript>().toRunButton7)
        {
            GameObject.Find("Main Camera").GetComponent<StartScript>().moves++;
            if (GameObject.Find("Main Camera").GetComponent<StartScript>().player == 0)
            {
                buttonText.text = "X";
                GameObject.Find("Main Camera").GetComponent<StartScript>().player = 1;
                GameObject.Find("Main Camera").GetComponent<StartScript>().symbolOnButton7 = 0;
            }
            else
            {
                buttonText.text = "O";
                GameObject.Find("Main Camera").GetComponent<StartScript>().player = 0;
                GameObject.Find("Main Camera").GetComponent<StartScript>().symbolOnButton7 = 1;
            }




            GameObject.Find("Main Camera").GetComponent<StartScript>().toRunButton7 = false;
        }
    }
}