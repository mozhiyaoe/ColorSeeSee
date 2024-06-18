
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using Unity.VisualScripting;

public class FirstModelController : MonoBehaviour
{

    //倒计时开始数字
    public float timeleft;
    //文本先是倒计时
    public Text CountdownText;
    //是否开始倒计时
    private bool isCounting;
    //创建一个背景颜色变量
    SpriteRenderer BackGroundColor1;
    SpriteRenderer BackGroundColor2;
    SpriteRenderer BackGroundColor3;
    SpriteRenderer BackGroundColor4;
    SpriteRenderer BackGroundColor5;
    SpriteRenderer BackGroundColor6;
    SpriteRenderer BackGroundColor7;



    //创建一个“字”的类
    public class Word
    {

        public string[] WordName = new string[] { "红", "橙", "黄", "绿", "青", "蓝", "紫" };
        public string[] Wordcolor = new string[] { "ef3473", "fba414", "ff9900", "BDDD22", "1661ab", "3B2E7E", "7e1671" };
    }

    //固定背景颜色随机取（如：点名器）
    private SpriteRenderer ChangeBackGround(SpriteRenderer[] arr)
    {
        Random ran = new System.Random();
        int n = ran.Next(arr.Length - 1);
        return arr[n];
    }

    // Start is called before the first frame update
    void Start()
    {
        //给背景颜色绑定组件

        BackGroundColor1 = gameObject.GetComponent<SpriteRenderer>();
        BackGroundColor2 = gameObject.GetComponent<SpriteRenderer>();
        BackGroundColor3 = gameObject.GetComponent<SpriteRenderer>();
        BackGroundColor4 = gameObject.GetComponent<SpriteRenderer>();
        BackGroundColor5 = gameObject.GetComponent<SpriteRenderer>();
        BackGroundColor6 = gameObject.GetComponent<SpriteRenderer>();
        BackGroundColor7 = gameObject.GetComponent<SpriteRenderer>();

        //创建颜色数组
        SpriteRenderer[] BackGroundColor = new SpriteRenderer[] { BackGroundColor1, BackGroundColor2, BackGroundColor3, BackGroundColor4,
         BackGroundColor5, BackGroundColor6, BackGroundColor7 };
        //给背景数组赋值，附上颜色
        BackGroundColor[0].color = new Color(239, 52, 115);
        BackGroundColor[1].color = new Color(251, 164, 20);
        BackGroundColor[2].color = new Color(255, 153, 0);
        BackGroundColor[3].color = new Color(189, 221, 34);
        BackGroundColor[4].color = new Color(22, 97, 171);
        BackGroundColor[5].color = new Color(59, 46, 126);
        BackGroundColor[6].color = new Color(126, 22, 113);









        if (timeleft <= 0)
        {
            ChangeBackGround(BackGroundColor);
        }




        //开始倒计时
        isCounting = true;



    }

    // Update is called once per frame
    void Update()
    {
        //使用函数开始变换背景






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
