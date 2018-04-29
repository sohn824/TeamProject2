using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public int hpMax = 10;
    [HideInInspector]
    public int hp;
    private bool isDamage = false;
    private Rigidbody2D myRigid;
    private SpriteRenderer mySprite;
    private CapsuleCollider2D myCollider;
    float elapsed;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform bulletTf;
    // Use this for initialization
    void Start()
    {
        myRigid = gameObject.GetComponent<Rigidbody2D>();
        mySprite = gameObject.GetComponent<SpriteRenderer>();
        myCollider = gameObject.GetComponent <CapsuleCollider2D>();
        elapsed = Time.time;
        hp = hpMax;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            StartCoroutine("PlayerDamage");
        }
    }
    // Update is called once per frame
    void Update ()
    {
        KeyProcess();
        if (isDamage)
        {
            if (Time.time - elapsed >= 0.15f)
            {
                mySprite.enabled = !mySprite.enabled;
                elapsed = Time.time;
            }
        }
        else
        {
            if (mySprite.enabled == false)
                mySprite.enabled = true;
        }
    }

    void KeyProcess()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            myRigid.AddForce(Vector2.up * 7, ForceMode2D.Impulse);  //위쪽으로 힘을 줘서 점프효과를 줬다

        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(bullet, bulletTf.position, Quaternion.identity);
        }
        
    }
    IEnumerator PlayerDamage()
    {
        hp -= 1;
        isDamage = true;
        yield return new WaitForSeconds(1.5f);
        isDamage = false;
        mySprite.enabled = true;
    }

}


