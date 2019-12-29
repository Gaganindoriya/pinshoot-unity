using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    public bool gameHasEnded = false;

    public rotator mRotator;
    public spawner mSpawner;

    public Animator animator;

	// Use this for initialization
    public void EndGame()
    {
        if (gameHasEnded)
            return;

        mRotator.enabled = false;
        mSpawner.enabled = false;
        gameHasEnded = true;

        //for showing animations
        animator.SetTrigger("EndGame");
        Debug.Log("Game Has Ended");
    }

    //for restatrting a level

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
