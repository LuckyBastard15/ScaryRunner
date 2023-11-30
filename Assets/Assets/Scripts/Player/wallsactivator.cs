using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsactivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.CompareTag("Arriba") || other.CompareTag("Izquieda")|| other.CompareTag("Derecha"))
        {
            Debug.Log("b");
            other.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Arriba") || other.CompareTag("Izquieda")|| other.CompareTag("Derecha"))
        {
            other.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
