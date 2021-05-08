using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour
{   
    public float speed = 2f;
    public float jumpSpeed = 20f;
    public bool isControlled = false;

    Rigidbody body;

    void UpdateControlChild() {
        Transform child = transform.Find("Control");
        if (child != null) {
           child.gameObject.SetActive(isControlled);
           } else {
               Debug.LogWarning("hey,mon gars,ma fille,tu as oublié de nommer un enfant\"Control\"");
           }
        
    }
    
    void Start()
    {
        body = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        float x = speed * Input.GetAxis("Horizontal"); 
        float y = body.velocity.y; 
        float z = speed * Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)) {
            y = jumpSpeed;
            
        }

        body.velocity = new Vector3(x,y,z);
    }
}
