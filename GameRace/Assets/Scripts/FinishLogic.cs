using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLogic : MonoBehaviour
{
    public Sprite spriteFinish;

    public GameObject pl;
    public GameObject[] rings;

    private int _WinCont = 0;

    private int _CounterMon;
    void Start()
    {
        
    }

 
    void Update()
    {
        _CounterMon = pl.GetComponent<PlayerControl>()._CountForFinish;
    }
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteFinish;
            if (_CounterMon == 11)
            {
                _WinCont += 1;
                pl.GetComponent<PlayerControl>()._CountForFinish = 0;
                for(int i = 0; i < rings.Length; i++)
				{
                    rings[i].SetActive(true);
				}
            }
        }
    }
}
