using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1ButtonContorller: MonoBehaviour
{
    public void FirstModelStartButton()
    {
        Debug.Log("游戏开始");
        SceneManager.LoadScene("FirstModel");



    }
}
