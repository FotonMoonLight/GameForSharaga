using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminPanelLogic : MonoBehaviour
{
	public GameObject[] ui;
	public GameObject[] bits;
	public GameObject[] texts;
	public Sprite[] sp;

	public static bool _IsBotLogicOn = false;
	public static bool _IsPlConLogic = false;
	public static bool _IsPlColiss = false;
	public static bool _IsFinLog = false;
	public void BotLogicController()
	{
		if(_IsBotLogicOn == true) 
		{
			ui[0].GetComponent<Image>().sprite = sp[1];
			_IsBotLogicOn = false;
			texts[0].SetActive(false);
		}
		else if(_IsBotLogicOn == false)
		{
			ui[0].GetComponent<Image>().sprite = sp[0];
			_IsBotLogicOn = true;
			texts[0].SetActive(true);
			texts[1].SetActive(false);
			texts[2].SetActive(false);
			texts[3].SetActive(false);
		}
		
	}
	public void PlConLOg()
	{
		if (_IsPlConLogic == true)
		{
			ui[1].GetComponent<Image>().sprite = sp[1];
			_IsPlConLogic = false;
			texts[1].SetActive(false);
			
		}
		else if (_IsPlConLogic == false)
		{
			ui[1].GetComponent<Image>().sprite = sp[0];
			_IsPlConLogic = true;
			texts[0].SetActive(false);
			texts[1].SetActive(true);
			texts[2].SetActive(false);
			texts[3].SetActive(false);
		}
	}
	public void PlColissionButt()
	{
		if (_IsPlColiss == true)
		{
			ui[2].GetComponent<Image>().sprite = sp[1];
			_IsPlColiss = false;
			texts[2].SetActive(false);

		}
		else if (_IsPlColiss == false)
		{
			ui[2].GetComponent<Image>().sprite = sp[0];
			_IsPlColiss = true;
			texts[0].SetActive(false);
			texts[1].SetActive(false);
			texts[2].SetActive(true);
			texts[3].SetActive(false);
		}
	}
	public void ISFIN()
	{
		if (_IsFinLog == true)
		{
			ui[3].GetComponent<Image>().sprite = sp[1];
			_IsFinLog = false;
			texts[3].SetActive(false);
		}
		else if (_IsFinLog == false)
		{
			ui[3].GetComponent<Image>().sprite = sp[0];
			_IsFinLog = true;
			texts[0].SetActive(false);
			texts[1].SetActive(false);
			texts[2].SetActive(false);
			texts[3].SetActive(true);
		}
	}
	public void ExitOnPanels()
	{
		gameObject.SetActive(false);
		bits[0].SetActive(true);
		Time.timeScale = 1f;
	}
}
