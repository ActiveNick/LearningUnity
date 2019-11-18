using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Pickup object
    public GameObject spawn;
    public AudioClip soundSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewPickup", 3.0f, 5.0f);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    void SpawnNewPickup()
    {
        float randX = Random.Range(-20, 20);
        float randZ = Random.Range(-20, 20);

        var newpickup = GameObject.Instantiate(spawn, new Vector3(randX, 1, randZ), Quaternion.identity);
        AudioSource.PlayClipAtPoint(soundSpawn, newpickup.transform.position);
    }
}
