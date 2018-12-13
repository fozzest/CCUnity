using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {

	public Transform target;

	public float smooth = 1f;
	public float rotationSmoothness = .1f;

	public Vector3 offset;

	private Vector3 dampVel = Vector3.zero;

	
	void FixedUpdate () {




        // https://answers.unity.com/questions/268748/camera-zoom-in-and-out.html




        //reference for camera zoom

        //



        //void Update()
        //{
        //transform.LookAt(target);
        //float distanceToTarget = Vector3.Distance(target.position, transform.position);
        //if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        //{
        //Debug.Log(distanceToTarget);
        //if (maxDistance > distanceToTarget && minDistance < distanceToTarget)
        //{
        //    camPosition += (Vector3.forward * camSpeed * Time.smoothDeltaTime);
        //    camera.transform.position = camPosition;
        //}




        //smooth damp reference is from unity documentation

        // originally found on forum:
        //https://answers.unity.com/questions/1153326/does-anyone-know-the-script-for-a-smooth-camera-fo.html






        //public class ExampleClass : MonoBehaviour
        //  {
        //    public Transform target;
        //    public float smoothTime = 0.3F;
        //    private Vector3 velocity = Vector3.zero;

        //    void Update()
        //    {
        //        // Define a target position above and behind the target transform
        //        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

        //        // Smoothly move the camera towards that target position
        //        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        //    }
        //}


        Vector3 newPos = target.TransformDirection(offset);

        // Define a target position above and behind the target transform
        //        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref dampVel, smooth);

		Quaternion targetRot = Quaternion.LookRotation(-transform.position.normalized, target.up);
		//transform.rotation = targetRot;
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * rotationSmoothness);

	}
}
