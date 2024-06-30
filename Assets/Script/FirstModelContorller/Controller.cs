
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using Unity.VisualScripting;
using System.Drawing;
using System;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{


    public Image BackgroundImage;


    public Image LeftButtonImage;


    public float TimeLeft;

    public Text CountdownText;
    

    public Text WordText;

    public Image RightButtonImage;


    public Word WordRandom;

    public static Color32 WordColor;

    public static Color32 BackgroundColor;
    public Text FaileText;
    public Image FalieImage;
    public Button Restart;

    [HideInInspector]
    public bool RightButtonIsRight;
    [HideInInspector]
    public bool LeftButtonIsRight;


    public static Color32 Color1 = new Color32(255, 0, 0, 255);
    public static Color32 Color2 = new Color32(242, 253, 255, 255);
    public static Color32 Color3 = new Color32(255, 255, 0, 255);
    public static Color32 Color4 = new Color32(0, 255, 0, 255);
    public static Color32 Color5 = new Color32(0, 255, 255, 255);
    public static Color32 Color6 = new Color32(0, 0, 128, 255);
    public static Color32 Color7 = new Color32(128, 0, 128, 255);




    public class Word
    {
        public string Name { get; set; }
        public UnityEngine.Color Color { get; set; }
        public Word(string name, Color32 color)
        {
            Name = name;
            Color = color;
        }
    }



    public static Word Word1 = new Word("红", Color1);
    public static Word Word2 = new Word("白", Color2);
    public static Word Word3 = new Word("黄", Color3);
    public static Word Word4 = new Word("绿", Color4);
    public static Word Word5 = new Word("青", Color5);
    public static Word Word6 = new Word("蓝", Color6);
    public static Word Word7 = new Word("紫", Color7);



    [HideInInspector]
    public Color32[] ColorArry = new Color32[] { Color1, Color2, Color3 ,Color4,
  Color5,Color6, Color7};

    public Word[] WordArry = new Word[] { Word1, Word2, Word3, Word4, Word5, Word6, Word7 };






    public Word WordChange(Word[] arry)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(0, 7);
        return arry[n];
    }



    public Color32 ColorChange(Color32[] arr)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(0, 7);
        return arr[n];
    }

    public void ButtonColoring()
    {
        Random ran = new Random();
        int n = ran.Next(1, 3);

        if (n == 1)
        {
            LeftButtonImage.color = WordColor;
        }
        else
        {
            LeftButtonImage.color = BackgroundColor;
        }
        if (LeftButtonImage.color == WordColor)
        {
            RightButtonImage.color = BackgroundColor;
        }
        else
        {
            RightButtonImage.color = WordColor;
        }


    }

    //public void RightButtonColor()
    //{
    //    if (LeftButtonImage.color == WordColor)
    //    {
    //        RightButtonImage.color = BackgroundColor;
    //    }
    //    else
    //    {
    //        RightButtonImage.color = WordColor;
    //    }

    //}
    public void Coloring()
    {

        BackgroundImage.color = ColorChange(ColorArry);

        WordRandom = WordChange(WordArry);


        while (BackgroundImage.color == WordRandom.Color)
        {

            BackgroundImage.color = ColorChange(ColorArry);

            WordRandom = WordChange(WordArry);
        }

        BackgroundColor = BackgroundImage.color;



        WordText.text = WordRandom.Name;

        WordColor = WordRandom.Color;

        ButtonColoring();

        

    }
    public void Right()
    {
        Coloring();
        TimeLeft = 5;

    }
    public void Fail()
    {



        FaileText.gameObject.SetActive(true);
        FalieImage.gameObject.SetActive(true);
        Restart.gameObject.SetActive(true);
        TimeLeft = 0;
    }

    public void LeftGameJudge()
    {


        if (LeftButtonIsRight == true)
        {

            Right();
        }
        else
        {
            Fail();
        }
    }

    public void RightGameJudge()
    {
     


        if (RightButtonIsRight == true)
        {
            Right();
        }
        else
        {
            Fail();
        }






    }

    void Start()
    {
        TimeLeft = 5F;


        Coloring();
        FaileText.gameObject.SetActive(false);
        FalieImage.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);
    }
    void Update()
    {
        CountdownText.text = TimeLeft.ToString(format: "0.00");
     

        TimeLeft -= Time.deltaTime;

        if (TimeLeft <= 0 )
        {
            FaileText.gameObject.SetActive(false);
            FalieImage.gameObject.SetActive(false);
            Restart.gameObject.SetActive(false);
            TimeLeft= 0;    
            
        }
        if (BackgroundImage.color == RightButtonImage.color)
        {
            RightButtonIsRight = false;
            LeftButtonIsRight = true;
        }
        if (BackgroundImage.color == LeftButtonImage.color)
        {
            RightButtonIsRight = true;
            LeftButtonIsRight = false;
        }
    }
}


