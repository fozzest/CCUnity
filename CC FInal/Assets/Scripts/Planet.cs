using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {



	//private static Transform myTransform;

	public float shrinkSpeed = .05f;


	void Update ()
	{
		transform.localScale *= 1f - shrinkSpeed * Time.deltaTime;
	}

}
