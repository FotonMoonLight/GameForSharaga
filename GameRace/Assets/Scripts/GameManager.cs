using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool Aweker = true;
    private bool Cor = true;
    private bool Destroyer = false;
    private bool Helpes = false;
    private int _SpriteCounter = 0;
    public GameObject pl;
    public GameObject Helps;
    public GameObject _Conter;
    public GameObject[] _AdminMenu;
    public Sprite[] Numers;

    public GameObject[] menuButt;
    
    void FixedUpdate()
    {
        OnSpriteController();
        if(pl.GetComponent<PlayerCollector>()._Lose == true)
		{
            menuButt[0].SetActive(false);
            menuButt[1].SetActive(true);
            menuButt[2].SetActive(true);
            menuButt[4].SetActive(true);
            Time.timeScale = 0f;
        }
        if(FinishLogic.PlayerWin == true)
		{
            menuButt[0].SetActive(false);
            menuButt[1].SetActive(true);
            menuButt[2].SetActive(true);
            menuButt[5].SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void AdmunButton()
	{
        _AdminMenu[0].SetActive(false);
        _AdminMenu[1].SetActive(true);
        Time.timeScale = 0f;
	}
    public void OnMenuButton()
	{
        Time.timeScale = 0f;
        menuButt[0].SetActive(false);
        menuButt[1].SetActive(true);
        menuButt[2].SetActive(true);
        menuButt[3].SetActive(true);
	}
    public void OnRestButton()
	{
        SceneManager.LoadScene("SampleScene");
        FinishLogic.PlayerWin = false;
        pl.GetComponent<PlayerCollector>()._Lose = false;
            menuButt[0].SetActive(true);
            menuButt[1].SetActive(false);
            menuButt[2].SetActive(false);
            menuButt[5].SetActive(false);
            Time.timeScale = 1f;
        
    }
    public void OnMinButton()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void OnContButton()
	{
        Time.timeScale = 1f;
        menuButt[0].SetActive(true);
        menuButt[1].SetActive(false);
        menuButt[2].SetActive(false);
        menuButt[3].SetActive(false);
    }
    public void OnSpriteController()
	{
		if(Cor && _SpriteCounter <= 3)
		{
            StartCoroutine(Timer());
            Cor = false;
        }
        if(_SpriteCounter > 3)
		{
            Aweker = false;
            if(Destroyer == false)
			{
                StartCoroutine(DesTimer());
                Destroyer = true;
			}
		}
        
	}
    public void Helpers()
	{
        if (Helpes == true)
        {
            Helps.SetActive(false);
            Helpes = false;
        }
        else if (Helpes == false)
        {
            Helps.SetActive(true);
            Helpes = true;
        }
    }
    IEnumerator Timer()
	{
        yield return new WaitForSeconds(1f);
        _Conter.GetComponent<SpriteRenderer>().sprite = Numers[_SpriteCounter];
        _SpriteCounter += 1;
        Cor = true;
	}
    IEnumerator DesTimer()
	{
        yield return new WaitForSeconds(3f);
        Destroy(_Conter);
	}
}
