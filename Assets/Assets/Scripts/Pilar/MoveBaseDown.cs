using UnityEngine;

public class MoveBaseDown : MonoBehaviour
{
    private float _speed = 10;
    
    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.down);
    }
}
