using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public GameObject target;
	void Update () {
		if (target != null)
		{
		transform.position = target.transform.position;
		}
	}
}
