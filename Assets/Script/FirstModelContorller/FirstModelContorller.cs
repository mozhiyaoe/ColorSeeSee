
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using Unity.VisualScripting;
using System.Drawing;
using System;

public class FirstModelContoller : MonoBehaviour
{


    //创建一个背景颜色图像
    [HideInInspector]
    public UnityEngine.UI.Image BackgroundImage;

    //左按钮的图像
    public Image LeftButtonImage;
    //剩下的时间
    public float timeleft;
    //倒数文字
    public Text CountdownText;
    //是否开始倒数
    private bool isCounting;
    //文字
    public Text WordText;
    //右按钮图像
    public Image RightButtonImage;


    public Word word;
    public static Color32 WordColor;
    public static Color32 BanckgroundColor;





    //给背景附上颜色，并创建数组
    public static Color32 Color1 = new Color32(239, 52, 115, 255);

    public static Color32 Color2 = new Color32(251, 164, 20, 255);
    public static Color32 Color3 = new Color32(255, 153, 0, 255);
    public static Color32 Color4 = new Color32(189, 221, 34, 255);
    public static Color32 Color5 = new Color32(22, 97, 171, 255);
    public static Color32 Color6 = new Color32(59, 46, 126, 255);
    public static Color32 Color7 = new Color32(126, 22, 113, 255);

    //给字附上颜色和文字属性
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


    //创建文字数组
    public static Word Word1 = new Word("红", Color1);
    public static Word Word2 = new Word("橙", Color2);
    public static Word Word3 = new Word("黄", Color3);
    public static Word Word4 = new Word("绿", Color4);
    public static Word Word5 = new Word("青", Color5);
    public static Word Word6 = new Word("蓝", Color6);
    public static Word Word7 = new Word("紫", Color7);

    [HideInInspector]
    public Color32[] BackGroundArry = new Color32[] { Color1, Color2, Color3 ,Color4,
  Color5,Color6, Color7};
    public Word[] WordArry = new Word[] { Word1, Word2, Word3, Word4, Word5, Word6, Word7 };



    LeftButtonContorller leftButtonContorller = new LeftButtonContorller();

    //文字随机取
    public Word WordnameChange(Word[] arry)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(arry.Length - 1);
        return arry[n];
    }


    //背景颜色随机取
    public Color32 BackgroundChange(Color32[] arr)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(arr.Length - 1);
        return arr[n];
    }
    public void LeftButtonColor()
    {
        Random ran = new Random();
        int n = ran.Next(1, 2);

        if (n == 1)
        {
            LeftButtonImage.color = WordColor;
        }
        else
        {
            LeftButtonImage.color = BanckgroundColor;
        }


    }



    // Start is called before the first frame update
    void Start()
    {

        BackgroundImage = gameObject.GetComponent<Image>();

        BackgroundImage.color = BackgroundChange(BackGroundArry);
        BanckgroundColor = BackgroundImage.color;

        isCounting = true;
        word = WordnameChange(WordArry);

        WordText.text = word.Name;
        WordColor = word.Color;
    
        LeftButtonColor();







    }
    void Update()
    {

        CountdownText.text = timeleft.ToString(format: "0.00");
        //判定是否开始倒计时
        if (isCounting)
        {
            timeleft -= Time.deltaTime;

        }
        //当倒计时小于等于0时，停止倒计时
        if (timeleft <= 0 && isCounting)
        {
            //停止倒计时
            isCounting = false;
        }
    }

}



