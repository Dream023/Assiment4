using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, speed*Time.deltaTime, 0.0f);
        }
    }
}
