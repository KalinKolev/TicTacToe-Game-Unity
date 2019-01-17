using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public GameObject winnerObject;
    public Text winnerText;
    public GameObject buttons;
    public GameObject separators;

    public Text OnTurn;

    public int moves = 0;

    public int player = 0;

    #region toRun
    public bool toRunButton1 = true;
    public bool toRunButton2 = true;
    public bool toRunButton3 = true;
    public bool toRunButton4 = true;
    public bool toRunButton5 = true;
    public bool toRunButton6 = true;
    public bool toRunButton7 = true;
    public bool toRunButton8 = true;
    public bool toRunButton9 = true;
    #endregion

    #region symbols
    public int symbolOnButton1 = 2;
    public int symbolOnButton2 = 3;
    public int symbolOnButton3 = 4;
    public int symbolOnButton4 = 5;
    public int symbolOnButton5 = 6;
    public int symbolOnButton6 = 7;
    public int symbolOnButton7 = 8;
    public int symbolOnButton8 = 9;
    public int symbolOnButton9 = 10;
    #endregion

    public bool isThereWinner = false;
    public int winner;

    void Update()
    {
        if (Input.GetKeyDown("escape")) Application.Quit();

        char symbolCurrent = ' ';
        if (player == 0) symbolCurrent = 'X';
        else symbolCurrent = 'O';
        OnTurn.text="On turn: "+symbolCurrent;       

        if (!isThereWinner && moves == 9)
        {
            winnerText.text = "The game was draw";
            winnerObject.SetActive(true);
            buttons.SetActive(false);
            separators.SetActive(false);
            Destroy(OnTurn);

            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Main");
            }
        }

        if (!isThereWinner && moves>=5)
        {
            //print("1: " + symbolOnButton1);
            //print("2: " + symbolOnButton2);
            //print("3: " + symbolOnButton3);
            //print("4: " + symbolOnButton4);
            //print("5: " + symbolOnButton5);
            //print("6: " + symbolOnButton6);
            //print("7: " + symbolOnButton7);
            //print("8: " + symbolOnButton8);
            //print("9: " + symbolOnButton9);

            if (symbolOnButton1 == symbolOnButton2 && symbolOnButton1 == symbolOnButton3)
            {
                winner = symbolOnButton1;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton4 == symbolOnButton5 && symbolOnButton4 == symbolOnButton6)
            {
                winner = symbolOnButton4;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton7 == symbolOnButton8 && symbolOnButton7 == symbolOnButton9)
            {
                winner = symbolOnButton7;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton1 == symbolOnButton4 && symbolOnButton1 == symbolOnButton7)
            {
                winner = symbolOnButton1;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton2 == symbolOnButton5 && symbolOnButton2 == symbolOnButton8)
            {
                winner = symbolOnButton2;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton3 == symbolOnButton6 && symbolOnButton3 == symbolOnButton9)
            {
                winner = symbolOnButton3;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton1 == symbolOnButton5 && symbolOnButton1 == symbolOnButton9)
            {
                winner = symbolOnButton1;
                isThereWinner = true;
                stopAllButtons();
            }
            else if (symbolOnButton3 == symbolOnButton5 && symbolOnButton3 == symbolOnButton7)
            {
                winner = symbolOnButton3;
                isThereWinner = true;
                stopAllButtons();
            }
        }
        else if(isThereWinner && moves>=5)
        {
            char symbolWinner = ' ';
            if (winner == 0) symbolWinner = 'X';
            else symbolWinner = 'O';
            winnerText.text = "The winner is Player " + symbolWinner;
            winnerObject.SetActive(true);
            buttons.SetActive(false);
            separators.SetActive(false);
            Destroy(OnTurn);

            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }

    void stopAllButtons()
    {
        toRunButton1 = false;
        toRunButton2 = false;
        toRunButton3 = false;
        toRunButton4 = false;
        toRunButton5 = false;
        toRunButton6 = false;
        toRunButton7 = false;
        toRunButton8 = false;
        toRunButton9 = false;
    }
}
