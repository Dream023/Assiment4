using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject wall, player;
    private void OnTriggerEnter(Collider wall)
    {
        player.transform.position = new Vector3(0f, 0f, 0f);
    }
}
