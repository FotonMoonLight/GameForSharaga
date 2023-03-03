using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int _CouterSprites = 0;
    public int _CountAngle = 0;

    public float _MovementSpeed = 0;

    public bool _HasSpeedUp = true;

    public GameObject PlayerMask;
    public GameObject dot;
 
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        PlayerMove();
    }
	private void Update()
	{
        if (Input.GetKey(KeyCode.W))
        {
            _HasSpeedUp = true;
            if (_MovementSpeed < 2f && _HasSpeedUp)
            {
                _HasSpeedUp = false;
                StartCoroutine(SpeedPlus());
            }

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _MovementSpeed = 0;
        }
    }
	void PlayerMove()
	{
        Vector3 vb = new Vector3(dot.transform.position.x - transform.position.x, dot.transform.position.y - transform.position.y, dot.transform.position.z - transform.position.z);
		if (Input.GetKey(KeyCode.W))
		{
            transform.position = transform.position + _MovementSpeed * vb.normalized * Time.fixedDeltaTime;
        }
		if (Input.GetKey(KeyCode.A))
		{
            transform.Rotate(0, 0, 5f);
		}
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -5f);
        }
		if (Input.GetKey(KeyCode.S))
		{
            transform.position = transform.position + 2f * -vb.normalized * Time.fixedDeltaTime;
        }
		

    }
    IEnumerator SpeedPlus()
	{
        yield return new WaitForSeconds(0.8f);
        _MovementSpeed += 0.01f;
	}
}
