using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float m_speed = 0.8f;
	// Use this for initialization
	void Start ()
    {}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject); //Destroy(this)는 이 스크립트만 파괴함
        }
        if(collision.tag == "LeftWall")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        transform.position += Vector3.left * m_speed * Time.deltaTime;
    }

}
