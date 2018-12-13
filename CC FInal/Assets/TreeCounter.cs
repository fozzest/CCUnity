using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCounter : MonoBehaviour {

    public GameObject explosion;
    AudioSource audio01;

    // Use this for initialization
    void Start () {

        GameManager.instance.TreeCount(+1) ;
        AudioSource audio01 = GetComponent<AudioSource>();
        audio01.Play();

    }
	
	// Update is called once per frame
	void Update () {



	}

     void OnTriggerEnter(Collider col)
    {
        Debug.Log(col);
        if (col.gameObject.tag == "Fire")
        {
            Debug.Log("Tree hit Meteor");
           
            Quaternion rot = Quaternion.LookRotation(transform.position.normalized);
            rot *= Quaternion.Euler(90f, 0f, 0f);
            Instantiate(explosion, transform.position, rot);

            //GameManager.instance.TreeCount(-1);
            Destroy(this.gameObject);
        }

    }

    void OnDestroy()
    {

        GameManager.instance.TreeCount(-1);
        //Destroy(this.gameObject);
    }
}
