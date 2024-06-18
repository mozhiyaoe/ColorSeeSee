using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneMangement;

public class StartSceneButtonContorller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void JoinFirstModel()
    {
        SceneManager.LoadScene("FirstModel");
    }
}
