using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {



	private CardboardHead head;

	// Use this for initialization
	void Start () {
		head = GameObject.FindObjectOfType<CardboardHead> ();

	}
	
	// Update is called once per frame
	void Update () {
		

	}







	public Vector3 LookDirection() {
		return Vector3.ProjectOnPlane (head.Gaze.direction, Vector3.up);
//		return head.Gaze.direction;
	}

	public Vector3 PlayerRotation() {
		return head.transform.rotation.eulerAngles;
	}


	void OnCollisionEnter (Collision collision) {
		Debug.Log ("Player's Collision!");
	}

}
