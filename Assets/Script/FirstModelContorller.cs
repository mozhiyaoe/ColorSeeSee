
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using System.Collections;
using System.Collections.Generic;
using Random = System.Random;

public class FirstModelController : MonoBehaviour
{

    //倒计时开始数字
    public float timeleft;
    //文本先是倒计时
    public Text CountdownText;
    //是否开始倒计时
    private bool isCounting;
    //创建一个背景颜色数组
     string[] Backgroundcolor = new string[] { "ef3473", "fba414", "ff9900", "BDDD22", "1661ab", "3B2E7E", "7e1671" };

    //创建一个“字”的类
    public class Word
    {

        public string[] WordName = new string[] { "红", "橙", "黄", "绿", "青", "蓝", "紫" };
        public string[] Wordcolor = new string[] { "ef3473", "fba414", "ff9900", "BDDD22", "1661ab", "3B2E7E", "7e1671" };
    }
    //创建一个背景类
    public class Background
    {
        public static string[] Backgroundcolor = new string[]{ "ef3473", "fba414", "ff9900", "BDDD22", "1661ab", "3B2E7E", "7e1671" };
    }
    //固定字符串随机取（如：点名器）
    private string Get_stringRandom(string[] arr)
    {
        Random ran =new System.Random();
        int n = ran.Next(arr.Length - 1);
        return arr[n];
    }

    // Start is called before the first frame update
    void Start()
    {
        //开始倒计时
        isCounting = true;
        //gameObject.GetComponent<Image>.Color.Hexadecimal =

    }

    // Update is called once per frame
    void Update()
    {
        //使用函数开始变换背景
       // gameObject.GetComponent<Image>().color.Hexadecimal = Get_stringRandom(Backgroundcolor);








        //判定是否开始倒计时
        if (isCounting)
        {
            timeleft -= Time.deltaTime;

        }
        //文本倒计时先是数字
        CountdownText.text = timeleft.ToString(format: "0.00");
        //当倒计时小于等于0时，停止倒计时
        if (timeleft <= 0 && isCounting)
        {
            //停止倒计时
            isCounting = false;
        }
    }
}
