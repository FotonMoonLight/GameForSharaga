using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int _CouterSprites = 0;
    public int _CountAngle = 0;

    public float _MovementSpeed;

    public GameObject PlayerMask;
    public GameObject dot;
 
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        PlayerMove();
        //PlayerSpriteController();
    }
    void PlayerMove()
	{
        Vector3 vb = new Vector3(dot.transform.position.x - transform.position.x, dot.transform.position.y - transform.position.y, dot.transform.position.z - transform.position.z);
		if (Input.GetKey(KeyCode.W))
		{
            transform.position = transform.position + _MovementSpeed * vb * Time.fixedDeltaTime;
        }
		if (Input.GetKey(KeyCode.A))
		{
            transform.Rotate(0, 0, 5f);
		}
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -5f);
        }

    }
    void PlayerSpriteController()
	{
		if (Input.GetKey(KeyCode.D) &&  _CountAngle == 1)
		{
            PlayerMask.transform.Rotate(0,0,90f);
            _CountAngle = 0;
        }
        if (Input.GetKey(KeyCode.W) && _CountAngle == 0 )
        {
            PlayerMask.transform.Rotate(0, 0, 90f);
            _CountAngle = 3;
        }
        if (Input.GetKey(KeyCode.A) && _CountAngle== 3)
        {
            PlayerMask.transform.Rotate(0, 0,90f);
            _CountAngle = 2;
        }
        if (Input.GetKey(KeyCode.S) &&  _CountAngle == 2)
        {
            PlayerMask.transform.Rotate(0, 0, 90f);
            _CountAngle = 1;
        }



        if (Input.GetKey(KeyCode.D) && _CountAngle == 3)
        {
            PlayerMask.transform.Rotate(0, 0, -90f);
            _CountAngle = 0;
        }
        if (Input.GetKey(KeyCode.W) && _CountAngle == 2)
        {
            PlayerMask.transform.Rotate(0, 0, -90f);
            _CountAngle = 3;
        }
        if (Input.GetKey(KeyCode.A) && _CountAngle == 1)
        {
            PlayerMask.transform.Rotate(0, 0, -90f);
            _CountAngle = 2;
        }
        if (Input.GetKey(KeyCode.S) && _CountAngle == 0)
        {
            PlayerMask.transform.Rotate(0, 0, -90f);
            _CountAngle = 1;
        }

    }
}
