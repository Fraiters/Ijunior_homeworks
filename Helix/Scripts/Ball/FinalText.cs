using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FinalText : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out FinalSegment finalSegment))
        {
            Debug.Log("Final Platform!");
        }
    }
}
