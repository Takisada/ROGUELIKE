using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YESNO : MonoBehaviour
{
    public void YesButton()
    {
        Application.Quit();
    }
    public void NoButton()
    {
        SceneManager.LoadScene(0);
    }
}
