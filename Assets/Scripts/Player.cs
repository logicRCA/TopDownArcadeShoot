using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerController))]
public class Player : MonoBehaviour {

    public float speed = 5f;
    PlayerController controller;
    void Start () {

        controller = GetComponent<PlayerController>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * speed;

        controller.Move(moveVelocity);


	}
}
