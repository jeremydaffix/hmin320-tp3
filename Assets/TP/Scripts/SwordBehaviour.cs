using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehaviour : MonoBehaviour {

    float distance = 10f;
    GameObject player;

    public Transform rightHand;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player"); // pour trouver le personnage
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.transform.position);

        if (distance < 3.5f)
        {
            this.transform.parent = rightHand;
            this.transform.localPosition = new Vector3(-0.019f, -0.113f, -0.264f);
            this.transform.localRotation = Quaternion.Euler(-131.933f, -7.427f, -84.868f);
        }
    }
}
