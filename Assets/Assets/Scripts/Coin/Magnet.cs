using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Magnet : MonoBehaviour
{

    public int _speed = 10;


    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(_speed * Time.deltaTime * Vector3.down);
    }
    
    
}
