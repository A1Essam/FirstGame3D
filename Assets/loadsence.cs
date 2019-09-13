using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsence : MonoBehaviour
{
    public void movelevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void quitgm()
    {
        Application.Quit();
    }
}
