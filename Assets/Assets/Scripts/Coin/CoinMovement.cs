using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 0;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }

}
