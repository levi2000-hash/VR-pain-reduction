using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public Rigidbody rb;

    public void enableGravity()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    public void disableGravity()
    {
        rb.isKinematic = false;
        rb.useGravity = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ| RigidbodyConstraints.FreezeRotationY;
    }
}
