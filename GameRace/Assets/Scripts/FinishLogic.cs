using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLogic : MonoBehaviour
{
    public Sprite spriteFinish;

    public GameObject pl;
    public GameObject[] rings;

    private int _WinCont = 0;
    private bool _Fin = false;
    public static bool PlayerWin = false;

    private int _CounterMon;
    void Start()
    {
        
    }

 
    void Update()
    {
        _CounterMon = pl.GetComponent<PlayerControl>()._CountForFinish;
        if(_WinCont == 1)
		{
            PlayerWin = true;
		}
    }
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Player" && AdminPanelLogic._IsFinLog == false)
        {
			if(_Fin == false)
			{
                StartCoroutine(fop());
                _Fin = true;
			}
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

    IEnumerator fop()
	{
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteFinish;
    }
}
