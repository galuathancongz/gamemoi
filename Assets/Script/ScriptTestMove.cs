using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ScriptTestMove : MonoBehaviour
   
{
    
    public float speed;
    public float rolatespeed;
    Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        var InputVertical = Input.GetAxis("Vertical");
        rigidbody.AddForce(Vector3.forward * speed*Time.deltaTime*InputVertical);
        var InputHorizontal = Input.GetAxis("Horizontal");
        rigidbody.AddTorque(Vector3.up * rolatespeed * Time.deltaTime * InputHorizontal);
    }
}
