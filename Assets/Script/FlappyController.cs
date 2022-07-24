using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FlappyController : MonoBehaviour
{
   
     public float speed;
    
   
    Rigidbody rigidbody;


    // Start is called before the first frame update
    private void Awake()
    {
         rigidbody=GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    private void FixedUpdate()
    {
        var verticalInput = Input.GetAxis("Vertical") ;
        rigidbody.AddForce(Vector3.up  * verticalInput * speed*Time.deltaTime);
        rigidbody.AddForce(Vector3.down*Time.deltaTime);
       
    }
}
