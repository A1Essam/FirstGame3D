using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public void gonextlevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
