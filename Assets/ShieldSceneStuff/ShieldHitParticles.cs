using UnityEngine;
using System.Collections;

public class ShieldHitParticles : MonoBehaviour {
	ParticleSystem emmitter;
	ParticleCollisionEvent[] collisionEvents;
	Vector3 avVel = Vector3.zero;
	Vector3 aimPoint;
	float hitSpeed;


	void Start ()
	{
		emmitter = GameObject.Find ("ShieldParticleEmmitter").GetComponent<ParticleSystem>();
	}

	void OnParticleCollision(GameObject other)
	{
		ParticleSystem part = other.GetComponent<ParticleSystem>();
		collisionEvents = new ParticleCollisionEvent[part.GetSafeCollisionEventSize()];
		part.GetCollisionEvents(this.gameObject, collisionEvents);
		for (int i = 0; i<collisionEvents.Length; i++)
		{
			avVel += collisionEvents[i].velocity;
		}
		avVel /= collisionEvents.Length;
		aimPoint = avVel + transform.position;
		transform.LookAt(aimPoint);
		hitSpeed = avVel.magnitude;
		emmitter.startSpeed = hitSpeed * 2 + 20;
		emmitter.Emit(Extras.Round (collisionEvents.Length * 6 * (hitSpeed / 25) + 3));
		avVel = Vector3.zero;
	}

	public void DetachParticles()
	{
		emmitter.Emit(Extras.Round (collisionEvents.Length * 6 * (hitSpeed / 25) + 3)*4);
		emmitter.transform.parent = null;
		Destroy(emmitter.gameObject,3.1f);
	}
}
