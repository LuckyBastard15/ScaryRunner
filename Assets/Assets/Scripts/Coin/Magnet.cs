using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Magnet : MonoBehaviour
{

    //public GameObject _coinDetector;
    public GameObject _coinPrefab;


    public int _speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        //_coinDetector = GameObject.FindGameObjectWithTag("CoinDetector");
    }

    private void OnTriggerEnter(Collider other)
    {
        _coinPrefab.transform.DOMove(transform.position, 105f);
    }
    IEnumerator ActivateCoin()
    {
        
        yield return new WaitForSeconds(10f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(_speed * Time.deltaTime * Vector3.down);
    }
    
    
}
