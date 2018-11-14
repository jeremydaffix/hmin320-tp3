using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPlatformBehaviour : MonoBehaviour {

    public int time = 3;

    bool launched = false;


    void OnTriggerEnter(Collider other)
    {
        // le joueur est là : lancement du timer avant autodestruction ! :o
        if (!launched)
        {
            launched = true; // pour éviter que le timer se lance plusieurs fois
            StartCoroutine(TimerTick());
        }
    }


    IEnumerator TimerTick()
    {
        Debug.Log("destoying in " + time + " s");

        while (time > 0)
        {
            //attendre 1 seconde
            yield return new WaitForSeconds(1.0f);
            time--;
        }


        // fin du timer : on s'autodétruit
        Debug.Log("DESTROY PLATFORM!");
        Destroy(gameObject);
    }
}

