using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<pipe>() != null || p_collision.GetComponent<checkpoint>() != null)
        {
            p_collision.transform.position = new Vector3(7f, p_collision.transform.position.y, 0f);
            //teleporter le tuyaux
        }
    }
}
