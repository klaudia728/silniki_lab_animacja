using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void Update()
        {
            Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

            Vector3 Direction = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
            {
                Direction = -Vector3.left;
            }

            if (Input.GetKey(KeyCode.S))
            {
                Direction = Vector3.left;
            }

            if (Input.GetKey(KeyCode.D))
            {
                Direction = -Vector3.forward;
            }

            if (Input.GetKey(KeyCode.A))
            {
                Direction = Vector3.forward;
            }

            rigidbody.AddTorque(Direction * 20f);
        }
    }

    
}
