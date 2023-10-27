using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTest : MonoBehaviour
{

    public float speed = 10;
    public float time = 3;
    float CurrentTime;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = time;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        {
            gameObject.SetActive(false);

        }
    }
}
