using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float force = 20;
    Rigidbody rb;
    public Transform gun;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(gun.transform.GetChild(0).transform.forward * force);
    }

   

}
