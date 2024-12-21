using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public GameObject UFOeffect;
    Rigidbody RigidPlayer;


    // Start is called before the first frame update
    void Start()
    {
        RigidPlayer = GetComponent<Rigidbody>();
        UFOeffect.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) // KeyCode is a continuous movement, GetKeyDown only activates on
        {
            RigidPlayer.AddRelativeForce(Vector3.forward, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            RigidPlayer.AddRelativeForce(Vector3.back, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            RigidPlayer.AddRelativeForce(Vector3.left, ForceMode.Impulse);
            transform.rotation *= Quaternion.Euler(0, -5, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            RigidPlayer.AddRelativeForce(Vector3.right, ForceMode.Impulse);
            transform.rotation *= Quaternion.Euler(0, 5, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            RigidPlayer.AddRelativeForce(Vector3.up, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.E))
        {
            RigidPlayer.AddRelativeForce(Vector3.down, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.X))
        {
            RigidPlayer.velocity = Vector3.zero;
        }


    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            UFOeffect.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.J)) 
        {
            UFOeffect.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision detect) 
    {
    if (detect.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collision with enemy successful");
        }
    }
}




