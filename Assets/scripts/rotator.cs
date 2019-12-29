using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(0.0f, 0.0f, speed * Time.deltaTime); 
     }
}
