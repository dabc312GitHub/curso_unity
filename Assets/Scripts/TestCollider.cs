using UnityEngine;

public class TestCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");    
        if (collision.gameObject.name == "Cube")
        {
            Debug.Log("Collision detected Cube");    
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collider detected");    
        if (collider.name == "Cube")
        {
            Debug.Log("Collider detected Cube");    
        }
    }
}
