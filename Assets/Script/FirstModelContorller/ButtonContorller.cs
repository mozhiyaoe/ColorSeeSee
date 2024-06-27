using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonContorller : FirstModelContoller

{
    public void GameJudge()
    {
        if (LeftButtonImage.color == WordColor || RightButtonImage.color == WordColor)
        {

            //随机取，并用WordRandom接收随机取的字类
            WordRandom = WordChange(WordArry);
            //使得界面的文字和随机取的Word类里面的文字一样
            WordText.text = WordRandom.Name;
            //将随机取的word类的颜色,赋值给wordcolor
            WordColor = WordRandom.Color;
            //左按钮颜色方法
            LeftButtonColor();
            //实现右按钮颜色方法
            RightButtonColor();
            timeleft = 5;


        }

    }

}
