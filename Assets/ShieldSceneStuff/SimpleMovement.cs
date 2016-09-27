using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {
	public int speed = 5;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			rb.MovePosition(transform.position+Vector3.right*speed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A))
		{
			rb.MovePosition(transform.position+Vector3.forward*speed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S))
		{
			rb.MovePosition(transform.position+Vector3.left*speed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.MovePosition(transform.position+Vector3.back*speed*Time.deltaTime);
		}
	}
}
