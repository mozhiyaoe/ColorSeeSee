
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using Unity.VisualScripting;
using System.Drawing;

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






    //给背景附上颜色，并创建数组
    public static Color32 BackGroundColor1 = new Color32(239, 52, 115, 255);

    public static Color32 BackGroundColor2 = new Color32(251, 164, 20, 255);
    public static Color32 BackGroundColor3 = new Color32(255, 153, 0, 255);
    public static Color32 BackGroundColor4 = new Color32(189, 221, 34, 255);
    public static Color32 BackGroundColor5 = new Color32(22, 97, 171, 255);
    public static Color32 BackGroundColor6 = new Color32(59, 46, 126, 255);
    public static Color32 BackGroundColor7 = new Color32(126, 22, 113, 255);
    [HideInInspector]
    public Color32[] BackGroundArry = new Color32[] { BackGroundColor1, BackGroundColor2, BackGroundColor3 ,BackGroundColor4,
  BackGroundColor5,BackGroundColor6, BackGroundColor7};
    //给字附上颜色和文字属性

    public static class Word1
    {
        public static string wordname = "红";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    public static class Word2
    {
        public static string wordname = "橙";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    public static class Word3
    {
        public static string wordname = "黄";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    public static class Word4
    {
        public static string wordname = "绿";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    public static class Word5
    {
        public static string wordname = "青";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    public static class Word6
    {
        public static string wordname = "紫";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    public static class Word7
    {
        public static string wordname = "红";
        public static Color32 wordcolor = new Color32(239, 52, 115, 255);


    }
    //创建文字数组
    string[] WordName = { Word1.wordname, Word2.wordname, Word3.wordname, Word4.wordname, Word5.wordname, Word6.wordname, Word7.wordname };
    //文字随机取
    public string WordnameChange(string[] arry)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(arry.Length - 1);
        return arry[n];
    }


    //背景颜色随机取
    public Color32 BackgroundChange(Color32[] arr)
    {
        Random ran = new Random();
        int n = ran.Next(arr.Length - 1);

        return arr[n];
    }

    public Color32 BackgrounColor()
    {
        return BackgroundImage.color;
    }



    // Start is called before the first frame update
    void Start()
    {
        BackgroundImage = gameObject.GetComponent<Image>();

         BackgroundImage.color = BackgroundChange(BackGroundArry);
        isCounting = true;
        WordText.text = WordnameChange(WordName);
        if (isCounting) 
        {
          
        }







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
