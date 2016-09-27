using UnityEngine;
using System.Collections;

public class ShooterCharacterController : MonoBehaviour {
	private float moveSpeed = 0.5f;
	private bool inAir;
	private float hp;
	public GameObject gun;
	private float moveX;
	private float moveY;
	private Vector3 movement;
	private float turnX;
	private float turnY;
	private Vector3 turn;
	public bool mouseLock;
	private Transform trans;
	private int invertLookX;
	private int invertLookY;

	void Start ()
	{
		inAir = false;
		mouseLock = false;
		hp = 100f;
		trans = this.gameObject.transform;
		invertLookX = 1;
		invertLookY = -11;
	
	}

	void Update ()
	{
		turnX = Input.GetAxisRaw ("Mouse X");
		turnY = Input.GetAxisRaw ("Mouse Y");
		turn.y = turnX * invertLookX;
		turn.x = turnY * invertLookY;
		//turn.z = trans.rotation.eulerAngles.z;
		Debug.Log(trans.rotation.eulerAngles);
		trans.rotation = Quaternion.Euler (trans.rotation.eulerAngles + turn);
		Vector3 aa = new Vector3 (10, 10, 10);
		if (Input.GetKey(KeyCode.LeftAlt))
		{
			toggleMouseLock ();
		}
		if (Input.GetKey(KeyCode.Alpha1))
		{
			invertLookX *= -1;
		}
		if (Input.GetKey (KeyCode.Alpha2))
		{
			invertLookY *= -1;
		}
	}

	void FixedUpdate ()
	{
		moveX = Input.GetAxis ("Horizontal");
		moveY = Input.GetAxis ("Vertical");
		movement.x = moveX;
		movement.z = moveY;
		trans.Translate (movement * moveSpeed);
	}

	void toggleMouseLock ()
	{
		if (mouseLock == false)
		{
			Cursor.lockState = CursorLockMode.Locked;
			mouseLock = true;
		}
		else if (mouseLock == true)
		{
			Cursor.lockState = CursorLockMode.None;
			mouseLock = false;
		}
	}
}
