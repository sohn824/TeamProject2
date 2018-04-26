using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject coin;
 
    void Start()
    {
        InvokeRepeating("SpawnCoin", 0f, 1f);
    }


    void SpawnCoin()
    {
       
        float randomY = Random.Range(1f, 4f);
        GameObject newCoin;
        newCoin = Instantiate(coin, new Vector3(23.9f, randomY, 0f), Quaternion.identity) as GameObject;
        
    }
}
