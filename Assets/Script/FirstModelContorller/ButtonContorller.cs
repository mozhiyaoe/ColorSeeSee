using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class ButtonContorller : MonoBehaviour


{
    public BackgroundContorller backgroundcontorller = new BackgroundContorller();
    public WordContorller wordcontorller = new WordContorller();
    public TimeLeftContorller tiemleftcontorller = new TimeLeftContorller();
    public GameObject LeftButtonColor=GameObject.Find("LeftButton");

    public void Leftbutton()
    {
        Debug.Log("这是左边的按钮");
        //for (tiemleftcontorller.timeleft = 5;)
        


    }
    public void RightButton()
    {
        Debug.Log("这是右边按钮");
    }
    void Start()
    {
        

    }






}
