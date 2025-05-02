using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskPour : MonoBehaviour
{
    //public Collider mixerCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x > 85 || transform.eulerAngles.x < -85)
        {
            //show liquid pouring
            Debug.Log("Tilted");
            
        }
        else
        {
            Debug.Log("Up");
        }

        if (transform.eulerAngles.z > 85 || transform.eulerAngles.z < -85)
        {
            //show liquid pouring
            Debug.Log("Tilted");

        }
        else
        {
            Debug.Log("Up");
        }
    }
}
