using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviour : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    public void Update()
    {
        float speed = 5.0F; // déplacer l’objet 5 m par seconde
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * -speed; float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //transform.Translate(x, y, 0);
        rb.MovePosition(rb.transform.position + new Vector3(x, 0, -y));

    }

}
