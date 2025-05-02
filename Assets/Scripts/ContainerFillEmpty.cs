using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerFillEmpty : MonoBehaviour
{
    string flaskTag = "Flask";

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(flaskTag))
        {
            //show that the container is filling up
            Debug.Log("Fill up");
        }
    }
}
