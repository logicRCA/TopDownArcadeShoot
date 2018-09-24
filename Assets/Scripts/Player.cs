using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerController))]
public class Player : MonoBehaviour {

    Camera mainCam;
    public float speed = 5f;
    PlayerController controller;
    void Start () {

        controller = GetComponent<PlayerController>();
        mainCam = Camera.main;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * speed;

        controller.Move(moveVelocity);

        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance))
        {
            Vector3 pointOfIntersection = ray.GetPoint(rayDistance);
            Debug.DrawLine(ray.origin,pointOfIntersection, Color.red);
        }



	}
}
