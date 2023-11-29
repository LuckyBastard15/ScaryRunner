using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    //[SerializeField] private GameObject powerUp;
    [SerializeField] private float _speed = 0;
    [SerializeField] private bool _Move;
    public bool _move = true;
    private void Start()
    {
        
    }
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        if(_move == true)
        {
            transform.Translate(_speed * Time.deltaTime * Vector3.forward);
        }

    }
    public void DesableMove()
    {
        _move = false;


    }

    
}
