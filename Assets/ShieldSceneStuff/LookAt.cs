using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {
	public GameObject target;
	void Update () {
		if (target != null)
		{
			transform.LookAt(target.transform.position);
		}
	}
}
