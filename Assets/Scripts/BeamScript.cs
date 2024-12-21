using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision detect) 
    {
    if (detect.gameObject.CompareTag("Human"))
        {
            Debug.Log("Hey Buddy");
            Destroy(detect.gameObject);
        }
    }
}
