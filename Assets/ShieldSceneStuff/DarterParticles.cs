using UnityEngine;
using System.Collections;

public class DarterParticles : MonoBehaviour {
	ParticleSystem shooter;
	RaycastHit hit;
	Transform target;
	Vector3 targetInitialRotation;
	Vector3 targetOffset;
	int reTarget = 50;
	int internalCD;
	ParticleSystem.Particle[] particleList;
	public int shots;
	
	
	private Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 rotate)
	{
		Vector3 direction = point - pivot; // get point direction relative to pivot
		direction = Quaternion.Euler(rotate) * direction; // rotate it
		point = direction + pivot; // calculate rotated point
		return point; // return it
	}
	
	private Vector3 getAimPoint()
	{
		return (RotatePointAroundPivot(target.position - targetOffset,target.position, target.transform.eulerAngles - targetInitialRotation));
	}
	
	
	// Use this for initialization
	void Start () {
		shooter = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		reTarget--;
		if (shooter.particleCount > 0)
		{

			particleList = new ParticleSystem.Particle[shooter.particleCount];
			shooter.GetParticles(particleList);

			if(Input.GetMouseButton(1))
			{
				if (reTarget < 0)
				{
					reTarget = 50;
					for (int i = 0; i< particleList.Length;i++)
					{
						particleList[i].velocity = Vector3.Lerp(
							particleList[i].velocity.normalized, // lerp vector from
							(getAimPoint() - particleList[i].position).normalized,1) // aim toward the aim point, minus current position, normalized
							* particleList[i].velocity.magnitude * 1.33f;//all of that comes up with the new direction to go, multiply by speed to keep going at the same speed
				//Debug.Log ("Distance: " + (getAimPoint() - particleList[i].position).magnitude);
				//Debug.Log ("Angle to: " + Vector3.Angle (particleList[i].velocity, (getAimPoint() - particleList[i].position)));
				//Debug.Log("distancemod is: " + distanceMod);
				//Debug.Log("turn amount: " + (particleList[i].velocity.magnitude) / ((particleList[i].velocity.magnitude + 600 + // current speed / current speed + 600 so the turn speed increases the faster
				//it goes, so it doesn't become much less accurate at high speed
				//  (target.position - targetLast.position).magnitude * 2) //add to that the speed of the target so the faster the target, the slower it tracks
				//* distanceMod));
				
				//avAngleTo += Vector3.Angle(particleList[i].velocity,target.position-particleList[i].position);
				//Debug.Log (Vector3.Angle(particleList[i].velocity,target.position-particleList[i].position));
					}
					shooter.SetParticles(particleList,particleList.Length);
				}
			}
			else if (Input.GetMouseButton(0)) 
			{
				if (reTarget < 0)
				{
					Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
					if (Physics.Raycast(ray, out hit))
					{
						reTarget = 50;
						target = hit.transform;
						targetOffset = hit.transform.position - hit.point;
						targetInitialRotation = target.transform.eulerAngles;
						Debug.Log ("target: " + target.transform.position);
						Debug.Log ("hit: " + hit.point);
						Debug.Log ("offset: " + targetOffset);
						Debug.Log ("target rotation: " + targetInitialRotation);
	
						for (int i = 0; i< particleList.Length;i++)
						{
							particleList[i].velocity = Vector3.Lerp(
								particleList[i].velocity.normalized, // lerp vector from
								(getAimPoint() - particleList[i].position).normalized,1) // aim toward the aim point, minus current position, normalized
								* particleList[i].velocity.magnitude * 1.33f;//all of that comes up with the new direction to go, multiply by speed to keep going at the same speed
						}
						shooter.SetParticles(particleList,particleList.Length);
					}
				}
			}

			//avAngleTo /= particleList.Length;
			//Debug.Log (avAngleTo);
		}
		if (internalCD > 0)
		{
			internalCD--;
		}
		else if (shooter.particleCount == 0)
		{
			if (Input.GetKey (KeyCode.T))
			{
				internalCD = 5;
				shots++;
			}

			else if (Input.GetKey (KeyCode.G))
			{
				internalCD = 5;
				shots++;
			}

			else if (Input.GetKey(KeyCode.Q))
			{
				if (Physics.Raycast(transform.position, transform.forward, out hit))
				{
					internalCD = 100;
					target = hit.transform;
					targetOffset = hit.transform.position - hit.point;
					targetInitialRotation = target.transform.eulerAngles;
					Debug.Log ("target: " + target.transform.position);
					Debug.Log ("hit: " + hit.point);
					Debug.Log ("offset: " + targetOffset);
					Debug.Log ("target rotation: " + targetInitialRotation);
					shooter.Emit (shots);
				}
				else
				{
					
					target = null;
				}
			}
			else if (Input.GetMouseButton(0)) 
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					internalCD = 100;
					reTarget = 50;
					target = hit.transform;
					targetOffset = hit.transform.position - hit.point;
					targetInitialRotation = target.transform.eulerAngles;
					Debug.Log ("target: " + target.transform.position);
					Debug.Log ("hit: " + hit.point);
					Debug.Log ("offset: " + targetOffset);
					Debug.Log ("target rotation: " + targetInitialRotation);
					shooter.Emit (shots);
				}
			}
			else
			{
				target = null;
			}
		}
	}
}
