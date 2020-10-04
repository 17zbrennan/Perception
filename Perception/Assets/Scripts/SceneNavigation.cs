using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    //Switches scene based on build order
    public void SwitchScene(int i)
    {
        SceneManager.LoadScene(i);
    }

    //quits the application
    public void Quit()
    {
        Application.Quit();
    }

}
