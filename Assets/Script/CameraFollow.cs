using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
    
{
    public Transform Capsule;
    private Vector3 CameraFollowCapsule;

    // Start is called before the first frame update
    void Start()
    {
        CameraFollowCapsule=Capsule.transform.position-transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Capsule.transform.position - Capsule.transform.rotation * CameraFollowCapsule;
        transform.LookAt(Capsule);
    }
}
