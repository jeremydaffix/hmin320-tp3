using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldBehaviour : MonoBehaviour
{
    // paramétrés dans l'éditeur
    public Text CoinsText;
    public GameObject CanvasObj;

    int coins = 0;


    //Transform child;

    void Start()
    {
        //canvasObj = GameObject.Find("Canvas");
        //child = CanvasObj.transform.Find("lblCoins"); //le nom de votre objet UI Text coinsText = child.GetComponent<Text>();
    }

    public void AddCoin()
    {
        coins++;
        CoinsText.text = "$" + coins.ToString("00");
    }
}