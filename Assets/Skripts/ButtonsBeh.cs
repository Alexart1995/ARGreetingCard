using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBeh : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadARScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitApplication()
    {
        Application.Quit();
        Debug.Log("Exit App");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
