using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
	public GameObject pl;
	private void Start()
	{

	}
	void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.name == "Ring")
		{
			Destroy(collision.gameObject);
			pl.GetComponent<PlayerControl>()._CountForFinish += 1;
		}
	}
}
