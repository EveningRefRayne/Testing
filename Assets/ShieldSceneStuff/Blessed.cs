using UnityEngine;
using System.Collections;

public class Blessed : MonoBehaviour {

	BlessedStats stats = new BlessedStats();

	ParticleCollisionEvent[] collisionEvents;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (stats.GetHP()<=0)
		{
			this.GetComponent<ShieldHitParticles>().DetachParticles();
			Destroy(this.gameObject);
		}
	
	}


	void OnParticleCollision(GameObject other)
	{
		ParticleSystem part = other.GetComponent<ParticleSystem>();
		collisionEvents = new ParticleCollisionEvent[part.GetSafeCollisionEventSize()];
		part.GetCollisionEvents(this.gameObject, collisionEvents);
		float totalDamage = 0;
		for (int i = 0; i<collisionEvents.Length; i++)
		{
			totalDamage += collisionEvents[i].velocity.sqrMagnitude / 100;
		}
		stats.Damage (totalDamage);
		totalDamage = 0;
		Debug.Log (stats.GetHP());
	}
}
