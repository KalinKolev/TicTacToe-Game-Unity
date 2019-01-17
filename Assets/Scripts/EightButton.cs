using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EightButton : MonoBehaviour
{
    public Text buttonText;

    public void PlaceSymbol()
    {
        if (GameObject.Find("Main Camera").GetComponent<StartScript>().toRunButton8)
        {
            GameObject.Find("Main Camera").GetComponent<StartScript>().moves++;
            if (GameObject.Find("Main Camera").GetComponent<StartScript>().player == 0)
            {
                buttonText.text = "X";
                GameObject.Find("Main Camera").GetComponent<StartScript>().player = 1;
                GameObject.Find("Main Camera").GetComponent<StartScript>().symbolOnButton8 = 0;
            }
            else
            {
                buttonText.text = "O";
                GameObject.Find("Main Camera").GetComponent<StartScript>().player = 0;
                GameObject.Find("Main Camera").GetComponent<StartScript>().symbolOnButton8 = 1;
            }




            GameObject.Find("Main Camera").GetComponent<StartScript>().toRunButton8 = false;
        }
    }
}