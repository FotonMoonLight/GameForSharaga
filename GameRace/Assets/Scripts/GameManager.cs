using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pl;

    public GameObject[] menuButt;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if(pl.GetComponent<PlayerCollector>()._Lose == true)
		{

		}
    }
    public void OnMenuButton()
	{
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
        menuButt[0].SetActive(true);
        menuButt[1].SetActive(false);
        menuButt[2].SetActive(false);
        menuButt[3].SetActive(false);
    }
}
