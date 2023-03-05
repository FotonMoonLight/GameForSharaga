using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
	public GameObject pl;

	public bool _Lose = false;

	public Sprite sprite;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Ring")
		{
			collision.gameObject.SetActive(false);
			
			pl.GetComponent<PlayerControl>()._CountForFinish += 1;
		}
		if(collision.gameObject.tag == "Wall")
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
			_Lose = true;
		}

	}
}
