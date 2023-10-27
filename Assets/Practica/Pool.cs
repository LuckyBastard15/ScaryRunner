using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public GameObject coinPrefab;
    List<GameObject> coinPool;


    // Start is called before the first frame update
    void Start()
    {
        coinPool = new List<GameObject>();
        //InvokeRepeating("CoinMovement", 0, 1);
    }

    void CoinMovement()
    {
        for(int i = 0; i < coinPool.Count; i++)
        {
            if (!coinPool[i].activeInHierarchy)
            {
                coinPool[i].transform.position = transform.position;
                coinPool[i].SetActive(true);
                return;
            }
        }
        GameObject currentCoin = Instantiate(coinPrefab, transform.position, coinPrefab.transform.rotation);
        coinPool.Add(currentCoin);


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        { 
            CoinMovement();
        }
        
    }
    
}
