using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public float Speed;
    public Vector3 initialposition;

    private void Start()
    {
        initialposition = transform.position;
    }
    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }

    public void RelaunchObject()
    {
        transform.position = initialposition;
    }
}
