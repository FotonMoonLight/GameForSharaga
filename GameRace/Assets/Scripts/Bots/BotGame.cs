using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGame : MonoBehaviour
{
    public float speedBot;
	public GameObject _Point;
	public GameObject Player;
	public GameObject GameManager;
	public int _TurnCounter = 0;
	public int _AngleCount = 0;
	private int _WinBot = 0;
	private bool _HasTurn = true;
	public bool _InMenu = false;
    void FixedUpdate()
    {
		if(AdminPanelLogic._IsBotLogicOn == false &&Player.GetComponent<PlayerCollector>()._Lose != true && (GameManager.GetComponent<GameManager>().Aweker != true || _InMenu))
		{
			Vector3 vb = new Vector3(_Point.transform.position.x - transform.position.x, _Point.transform.position.y - transform.position.y, _Point.transform.position.z - transform.position.z);
			transform.position = transform.position + speedBot * vb.normalized * Time.fixedDeltaTime;
			TurnController();
		}
		if(_WinBot == 2)
		{
			Player.GetComponent<PlayerCollector>()._Lose = true;
		}
		
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "BotRight")
		{
			_TurnCounter = 1;
		}
		if (collision.gameObject.tag == "BotLeft")
		{
			_TurnCounter = 2;
		}
		if(collision.gameObject.name == "Start")
		{
			_WinBot += 1;
		}
	}
	private void TurnController()
	{
		if(_TurnCounter == 1)
		{
			if (_HasTurn && _AngleCount < 90)
			{
				_HasTurn = false;
				StartCoroutine(turnTimerRight());
			}
			if(_AngleCount == 90)
			{
				_TurnCounter = 0;
				_HasTurn = true;
				_AngleCount = 0;
			}
		}
		if (_TurnCounter == 2)
		{
			if (_HasTurn && _AngleCount < 90)
			{
				_HasTurn = false;
				StartCoroutine(turnTimerLeft());
			}
			if (_AngleCount == 90)
			{
				_TurnCounter = 0;
				_HasTurn = true;
				_AngleCount = 0;
			}
		}
	}
	IEnumerator turnTimerRight()
	{
		yield return new WaitForFixedUpdate();
		transform.Rotate(0, 0, -3f);
		_AngleCount += 3;
		_HasTurn = true;
	}
	IEnumerator turnTimerLeft()
	{
		yield return new WaitForFixedUpdate();
		transform.Rotate(0, 0, 3f);
		_AngleCount += 3;
		_HasTurn = true;
	}
}
