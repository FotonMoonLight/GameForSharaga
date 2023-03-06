using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool Aweker = true;
    private bool Cor = true;
    private bool Destroyer = false;
    private int _SpriteCounter = 0;
    public GameObject pl;
    public GameObject _Conter;
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
        }
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
	}
    public void OnMinButton()
    {
        SceneManager.LoadScene("Menu");
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
