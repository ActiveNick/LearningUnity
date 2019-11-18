using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class CubeController : MonoBehaviour
{
    public bool isRotating = false;
    public float rotAngle = 1.0f;
    public Material colorSuccess;

    AudioSource chime;
    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        chime = GetComponent<AudioSource>();
        body = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up, rotAngle);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            chime.Play();
            body.useGravity = true;
            isRotating = false;
            gameObject.GetComponent<MeshRenderer>().material = colorSuccess;
        }
    }
}
