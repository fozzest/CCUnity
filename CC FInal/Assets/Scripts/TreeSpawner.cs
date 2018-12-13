using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeSpawner : MonoBehaviour {

    public GameObject meteorPrefab;
    public float distance = 10f;
    public float timeLeft = 1;

    public GameObject Player;

    void Start()
    {
       //StartCoroutine(SpawnTree());
    }

    void Update()
    {
      


        Vector3 pos = Player.transform.position;


        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Debug.Log("Space key was pressed.");
                Instantiate(meteorPrefab, pos, Quaternion.identity);
                timeLeft = 1;
            }

        }
       



     
    }

}
