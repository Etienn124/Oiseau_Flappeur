using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float Speed;
    public Vector3 initialposition;

    private void Start()
    {
        initialposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }

    public void RelaunchObject()
    {
        transform.position = initialposition;
    }
}
