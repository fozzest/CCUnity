using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


//main ref:


//https://gist.github.com/01GOD/134ba1e65f29cd406b25

//    //http://www.theappguruz.com/blog/create-effect-like-center-of-gravity-of-planet-in-unity


//public Transform bird;
//private float gravitationalForce = 5;
//private Vector3 directionOfBirdFromPlanet;



public class GravityEffected : MonoBehaviour {

	private GravityAttractor attractor;
	private Rigidbody rb;

	public bool placeOnSurface = false;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		attractor = GravityAttractor.instance;
	}
	
	void FixedUpdate ()
	{
		if (placeOnSurface)
			attractor.PlaceOnSurface(rb);
	else
			attractor.Attract(rb);
	}

}
