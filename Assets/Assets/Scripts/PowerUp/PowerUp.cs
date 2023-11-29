using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PowerUp : MonoBehaviour
{
    //public GameObject _coinDetector;
    public GameObject _coinPrefab;
    public GameObject _player;
    

    private void Start()
    {
        this.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Jugador"))
        {
            this.enabled = true;
            
        }
    }


}
