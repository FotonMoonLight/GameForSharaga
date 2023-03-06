using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int _CouterSprites = 0;
    public int _CountAngle = 0;
    public int _CountForFinish;

    public float _MovementSpeed = 0.4f;
    private float move;

    public bool _HasSpeedUp = true;

    public GameObject PlayerMask;
    public GameObject GameManager;
    public GameObject dot;

 
    void Start()
    {
      
    }


    void FixedUpdate()
    {
		if (GameManager.GetComponent<GameManager>().Aweker == false)
		{
            PlayerMove();
        }
        
    }
	
	void PlayerMove()
	{
        move = Input.GetAxis("Vertical");
        Vector3 vb = new Vector3(dot.transform.position.x - transform.position.x, dot.transform.position.y - transform.position.y, dot.transform.position.z - transform.position.z);
		if (Input.GetKey(KeyCode.W) && PlayerMask.GetComponent<PlayerCollector>()._Lose != true)
		{
            transform.position = transform.position + _MovementSpeed * vb.normalized * move * Time.fixedDeltaTime;
        }
		if (Input.GetKey(KeyCode.A) && PlayerMask.GetComponent<PlayerCollector>()._Lose != true)
		{
            transform.Rotate(0, 0, 3f);
		}
        if (Input.GetKey(KeyCode.D) && PlayerMask.GetComponent<PlayerCollector>()._Lose != true)
        {
            transform.Rotate(0, 0, -3f);
        }
		if (Input.GetKey(KeyCode.S) && PlayerMask.GetComponent<PlayerCollector>()._Lose != true)
		{
            transform.position = transform.position + 3f * move * vb.normalized * Time.fixedDeltaTime;
        }
		

    }
}
