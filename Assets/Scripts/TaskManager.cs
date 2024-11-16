using UnityEditor.Animations;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public GameObject objetoMostrable;
    public Animator animatorController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            objetoMostrable.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objetoMostrable.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animatorController.SetTrigger("Cubo");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animatorController.SetTrigger("Sphere");
        }
    }
}
