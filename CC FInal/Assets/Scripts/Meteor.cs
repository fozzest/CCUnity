using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : GravityEffected {

public GameObject explosion;

	public SphereCollider sphereCol;
	public ParticleSystem trail;

	void OnCollisionEnter(Collision col)
	{

        //https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html

        Quaternion rot = Quaternion.LookRotation(transform.position.normalized);
		rot *= Quaternion.Euler(90f, 0f, 0f);
		Instantiate(explosion, col.contacts[0].point, rot);
        Debug.Log("Fire Created");

		sphereCol.enabled = false;
		//trail.Stop(true, ParticleSystemStopBehavior.StopEmitting);

		this.enabled = false;
		//GetComponent<AudioSource>().Stop();

		Destroy(gameObject, 2f);
	}

}
