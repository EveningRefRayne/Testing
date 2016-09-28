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
	private Transform trans;
    private MouseLookTest mlScript;
    private bool mouseLookMode;

	void Start ()
	{
		inAir = false;
		hp = 100f;
		trans = this.gameObject.transform;
        mlScript = GetComponent<MouseLookTest>();
        mouseLookMode = true;
        mlScript.setMLMode(mouseLookMode);
	
	}

	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftAlt))
		{
            if (mouseLookMode == true)
                mouseLookMode = false;
            else if (mouseLookMode == false)
                mouseLookMode = true;
            mlScript.setMLMode(mouseLookMode);

		}
		if (Input.GetKey(KeyCode.Alpha1))
		{
            mlScript.invertXLook();
		}
		if (Input.GetKey (KeyCode.Alpha2))
		{
            mlScript.invertYLook();
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
}
