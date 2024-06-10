using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_area : MonoBehaviour
{
    public GameObject filete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == filete) Debug.Log("CHOQUE FILETE");
        Debug.Log("Colision");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision con " + other.name);
    }
}
