using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{

    public GameObject _coinDetector;
    public CoinMovement _coinScript;

    
    public int _speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        _coinDetector = GameObject.FindGameObjectWithTag("CoinDetector");
       

        _coinDetector.SetActive(false);
       

    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Jugador")
        {
            StartCoroutine(ActivateCoin());     

        }
    }
    IEnumerator ActivateCoin()
    {
        _coinDetector.SetActive(true);
        //_coinScript.enabled = false;
        yield return new WaitForSeconds(10f);
        _coinDetector.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(_speed * Time.deltaTime * Vector3.down);
    }
    
    
}
