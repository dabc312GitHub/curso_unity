using System;
using Unity.VisualScripting;
using UnityEngine;

public class KeyInstance : MonoBehaviour
{
    public float velocity = 15f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * velocity);
    }

    private void OnCollisionEnter(Collision other)
    {
        // print("algo");
        // if (other.gameObject.CompareTag("Player"))
        // {
        //     print("key Player");
        // }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            print("key Player trigger");
        }
    }
}
