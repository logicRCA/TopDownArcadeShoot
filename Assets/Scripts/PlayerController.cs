using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    Vector3 mVelocity;
    Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.freezeRotation = true;

	}

    public void Move(Vector3 velocity)
    {
        mVelocity = velocity;
    }
    public void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + mVelocity * Time.fixedDeltaTime);
        
    }
}
