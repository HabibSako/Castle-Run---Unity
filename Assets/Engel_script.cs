using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel_script : MonoBehaviour
{
    Vector2 startPos; 

    // Start is called before the first frame update
    private void Start()
    {
        startPos = transform.position; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Engel"))
        {
            Die(); 
        }
    }

    void Die()
    {
        Respawn();
    }

    void Respawn()
    {
        transform.position = startPos;
    }
}
