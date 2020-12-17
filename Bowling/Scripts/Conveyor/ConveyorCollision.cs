using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConveyorCollision : MonoBehaviour
{
    [SerializeField] private int _force;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            collision.rigidbody.AddForce(Vector3.forward * _force, ForceMode.Impulse);
        }
        
    }
}
