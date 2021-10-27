using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float maxspeedYup;
	public float maxspeedYdown;
	public float thrust_force;
	public Vector3 initialposition;

	private void Start()
	{
		initialposition = transform.position;
	}
	// Update is called once per frame
	void Update()
    {
		Rigidbody2D _rigid = GetComponent<Rigidbody2D>();
		
        if(Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * thrust_force, ForceMode2D.Force);
		}
		
		if(_rigid.velocity.y > maxspeedYup)
		{
			_rigid.velocity = new Vector2(_rigid.velocity.x, maxspeedYup);
		}
		if(_rigid.velocity.y < maxspeedYdown)
		{
			_rigid.velocity = new Vector2(_rigid.velocity.x, maxspeedYdown);
		}
    }

	public void RelaunchObject()
	{
		transform.position = initialposition;
	}
}
