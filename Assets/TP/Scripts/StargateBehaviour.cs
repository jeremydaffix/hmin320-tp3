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


    public string levelToLoad= "TP2BoxBoy" ;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelToLoad) ;
    }

}
