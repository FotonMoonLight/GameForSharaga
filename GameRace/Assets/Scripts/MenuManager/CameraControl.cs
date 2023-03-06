using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	public GameObject[] points;
	public int _Counter = 0;
	public float CamSpeed = 5f;
	void FixedUpdate()
	{
		if(_Counter == 0)
		{
			Vector3 vb = new Vector3(points[1].transform.position.x - transform.position.x, points[1].transform.position.y - transform.position.y, points[1].transform.position.z - transform.position.z);
			transform.position = transform.position + CamSpeed * vb.normalized * Time.fixedDeltaTime;
		}
		
		if (_Counter == 1)
		{
			Vector3 vb = new Vector3(points[2].transform.position.x - transform.position.x, points[2].transform.position.y - transform.position.y, points[2].transform.position.z - transform.position.z);
			transform.position = transform.position + CamSpeed * vb.normalized * Time.fixedDeltaTime;
		}

		if (_Counter == 2)
		{
			Vector3 vb = new Vector3(points[0].transform.position.x - transform.position.x, points[0].transform.position.y - transform.position.y, points[0].transform.position.z - transform.position.z);
			transform.position = transform.position + CamSpeed * vb.normalized * Time.fixedDeltaTime;
		}
		
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.name == "Point 1")
		{
			_Counter = 1;
		}
		if (collision.gameObject.name == "Point 2")
		{
			_Counter = 2;
		}
		if (collision.gameObject.name == "Point 3")
		{
			_Counter = 0;
		}
	}
}