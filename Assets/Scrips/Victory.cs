using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject light;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(light))
        {
            Debug.Log("U win");
        }
    }
}
