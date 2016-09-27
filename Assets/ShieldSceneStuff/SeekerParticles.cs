using UnityEngine;
using System.Collections;

public class SeekerParticles : MonoBehaviour {
	ParticleSystem shooter;
	RaycastHit hit;
	Transform target;
	Transform targetLast;
	Vector3 targetInitialRotation;
	Vector3 targetOffset;
	int reTarget = 20;
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
		return (RotatePointAroundPivot(targetLast.position - targetOffset,targetLast.position, target.transform.eulerAngles - targetInitialRotation));
	}


	// Use this for initialization
	void Start () {
		shooter = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (shooter.particleCount > 0)
		{
			if (reTarget > 0)
			{
				reTarget--;
			}
			else
			{
				reTarget = 20;
				targetLast = target;
			}
			float avAngleTo = 0;
			float distanceMod = 1;
			particleList = new ParticleSystem.Particle[shooter.particleCount];
			shooter.GetParticles(particleList);
			if (target != null)
			{
				for (int i = 0; i< particleList.Length;i++)
				{
					if ((getAimPoint() - particleList[i].position).magnitude < 7
					    && Vector3.Angle (particleList[i].velocity, (getAimPoint() - particleList[i].position)) > 55)
					{
						distanceMod = 2;
					}
					else
					{
						distanceMod = 1;
					}
	
					particleList[i].velocity = Vector3.Lerp(
						particleList[i].velocity.normalized, // lerp vector from
						(getAimPoint() - particleList[i].position).normalized, // aim toward the aim point, minus current position, normalized
						(particleList[i].velocity.magnitude) / ((particleList[i].velocity.magnitude + 600 + // x/x so it doesn't become much less accurate at high speed
					                                         (target.position - targetLast.position).magnitude * 2) //add to that the speed of the target so the faster the target, the slower it tracks
					                                        * distanceMod)) //multiply the whole denominator by a modifier that gets set to keep it from turning quickly when near the target
						* particleList[i].velocity.magnitude;//all of that comes up with the new direction to go, multiply by speed to keep going at the same speed
					//Debug.Log ("Distance: " + (getAimPoint() - particleList[i].position).magnitude);
					//Debug.Log ("Angle to: " + Vector3.Angle (particleList[i].velocity, (getAimPoint() - particleList[i].position)));
					//Debug.Log("distancemod is: " + distanceMod);
					//Debug.Log("turn amount: " + (particleList[i].velocity.magnitude) / ((particleList[i].velocity.magnitude + 600 + // current speed / current speed + 600 so the turn speed increases the faster
					                                                                     //it goes, so it doesn't become much less accurate at high speed
					                                                                   //  (target.position - targetLast.position).magnitude * 2) //add to that the speed of the target so the faster the target, the slower it tracks
					                                                                    //* distanceMod));
	
					avAngleTo += Vector3.Angle(particleList[i].velocity,target.position-particleList[i].position);
					//Debug.Log (Vector3.Angle(particleList[i].velocity,target.position-particleList[i].position));
				}
				shooter.SetParticles(particleList,particleList.Length);
				avAngleTo /= particleList.Length;
				//Debug.Log (avAngleTo);
			}
		}
		if (internalCD > 0)
		{
			internalCD--;
		}
		else if (shooter.particleCount == 0)
		{
			if (Input.GetKey (KeyCode.R))
			{
				internalCD = 5;
				shots++;
			}
				
			else if (Input.GetKey (KeyCode.F))
			{
				internalCD = 5;
				shots++;
			}

			if (Input.GetKey(KeyCode.E))
			{
				if (Physics.Raycast(transform.position, transform.forward, out hit))
				{
					internalCD = 100;
					target = hit.transform;
					targetLast = target;
					targetOffset = hit.transform.position - hit.point;
					targetInitialRotation = target.transform.eulerAngles;
					//Debug.Log ("target: " + target.transform.position);
					//Debug.Log ("hit: " + hit.point);
					//Debug.Log ("offset: " + targetOffset);
					//Debug.Log ("target rotation: " + targetInitialRotation);
					shooter.Emit (shots);
				}
				else
				{

					target = null;
				}
			}
			else if (Input.GetMouseButton(2)) 
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					internalCD = 100;
					target = hit.transform;
					targetLast = target;
					targetOffset = hit.transform.position - hit.point;
					targetInitialRotation = target.transform.eulerAngles;
					//Debug.Log ("target: " + target.transform.position);
					//Debug.Log ("hit: " + hit.point);
					//Debug.Log ("offset: " + targetOffset);
					//Debug.Log ("target rotation: " + targetInitialRotation);
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
