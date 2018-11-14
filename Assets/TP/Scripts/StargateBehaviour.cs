using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StargateBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public string levelToLoad= "TP3BoxBoy" ;
    void OnTriggerEnter(Collider other)
    {
        if(GameVariables.coins > 2) // score minimum avant de voyager !
            SceneManager.LoadScene(levelToLoad) ;
    }

}
