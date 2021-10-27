using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if(p_collision.GetComponent<Player>() != null)
        {
            FindObjectOfType<UImanager>().triggerGameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
