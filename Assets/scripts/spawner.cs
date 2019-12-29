using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
    public GameObject pinPrefab;
	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            SpawnPin();
        }
	}
    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
