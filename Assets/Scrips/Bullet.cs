using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    private void Update()
    {
       if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject clone = Instantiate(bullet, transform.position,transform.rotation) as GameObject;
        }
    }
}
