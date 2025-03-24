using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationSpeed;

    public GameObject onCollectEffect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, rotationSpeed, 0);
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {

            // Just function that destroys objects on trigger
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

        }
    }
}
