using UnityEngine;
using System.Collections;

public class pin : MonoBehaviour {
    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;
    public AudioSource hit,die;

    //for audio
	// Use this for initialization

    
	// Update is called once per frame
	void Update () {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
        }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "rotator")
        {
           
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
            hit.Play();

        }else if(col.tag=="pin")
        {
            die.Play();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
