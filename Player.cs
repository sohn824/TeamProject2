using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigid;
    // Use this for initialization
    void Start ()
    {
        myRigid = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        KeyProcess();
	}

    void KeyProcess()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            myRigid.AddForce(Vector2.up * 8, ForceMode2D.Impulse);  //위쪽으로 힘을 줘서 점프효과를 줬다

        }
    }
}
