using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftButtonContorller : BackgroundContorller
{
    public UnityEngine.UI.Image LeftButtonImage;
    public void Test()
    {
        Debug.Log("ÕâÊÇ×ó±ß°´Å¥");
    }
    // Start is called before the first frame update
    void Start()
    {
        LeftButtonImage = gameObject.GetComponent<UnityEngine.UI.Image>();
        LeftButtonImage.color = BackgrounColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
