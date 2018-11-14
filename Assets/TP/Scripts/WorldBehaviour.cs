using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldBehaviour : MonoBehaviour
{
    // paramétrés dans l'éditeur
    public Text CoinsText;
    public GameObject CanvasObj;

    //int coins = 0;


    //Transform child;

    void Start()
    {
        //canvasObj = GameObject.Find("Canvas");
        //child = CanvasObj.transform.Find("lblCoins"); //le nom de votre objet UI Text coinsText = child.GetComponent<Text>();

        GameVariables.coins = 0;
    }

    public void AddCoin(int nbrPoints)
    {
        GameVariables.coins += nbrPoints;

        if (GameVariables.coins < 0) GameVariables.coins = 0;

        if(GameVariables.coins >= 4)
            CoinsText.text = "YOU WIN! :o";
        else
            CoinsText.text = "$" + GameVariables.coins.ToString("00");
    }
}