using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstScreen : MonoBehaviour {

    public void PlayGame(string newgameleve)
    {
        SceneManager.LoadScene(1);
    }


    public void ExitGame(string exit)
    {
        Application.Quit();
    }


    public void CloseGame(string menu)
    {
        SceneManager.LoadScene(0);
    }

}
