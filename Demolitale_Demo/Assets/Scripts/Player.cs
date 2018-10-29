using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rb;

    [SerializeField]
    public float speed = 5f;

	
	// Update is called once per frame
	void FixedUpdate () {
        var x = Input.GetAxis("Horizontal") * (Time.deltaTime * speed);

        var y = Input.GetAxis("Vertical") * (Time.deltaTime * speed);

        //transform.Rotate(x, y, 0);
        transform.Translate(x, y, 0);
    }


}
