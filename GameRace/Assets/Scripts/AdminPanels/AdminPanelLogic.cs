using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminPanelLogic : MonoBehaviour
{
	public GameObject[] ui;
	public GameObject[] bits;
	public Sprite[] sp;

	public static bool _IsBotLogicOn = false;
    public void BotLogicController()
	{
		if(_IsBotLogicOn == true) 
		{
			ui[0].GetComponent<Image>().sprite = sp[1];
			_IsBotLogicOn = false;
		}else if(_IsBotLogicOn == false)
		{
			ui[0].GetComponent<Image>().sprite = sp[0];
			_IsBotLogicOn = true;
		}
		
	}
	public void ExitOnPanels()
	{
		gameObject.SetActive(false);
		bits[0].SetActive(true);
		Time.timeScale = 1f;
	}
}
