using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownBehaviour : MonoBehaviour {

    public float allowedTime = 90;
    public Text timerText;
    //float currentTime;
    //GameObject canvasObj;
    //Transform child;


    void Start()
    {
        //canvasObj = GameObject.Find("Canvas");
        //child = canvasObj.transform.Find("lblTime");
        //timerText = child.GetComponent<Text>();

        GameVariables.allowedTime = allowedTime; // pour continuer de paramétrer le temps avec l'interface de unity
        GameVariables.currentTime = allowedTime;

        StartCoroutine(TimerTick());
    }

    IEnumerator TimerTick()
    {
        //currentTime = allowedTime;
        while (GameVariables.currentTime > 0)
        {
            //attendre 1 seconde
            yield return new WaitForSeconds(1.0f);
            GameVariables.currentTime--;
            
            timerText.text = "Time : " + GameVariables.currentTime;
        }

        // game over and restart
        SceneManager.LoadScene("TP3Exterieur");
    }



}
