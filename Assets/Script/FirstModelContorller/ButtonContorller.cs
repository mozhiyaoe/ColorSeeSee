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

            //���ȡ������WordRandom�������ȡ������
            WordRandom = WordChange(WordArry);
            //ʹ�ý�������ֺ����ȡ��Word�����������һ��
            WordText.text = WordRandom.Name;
            //�����ȡ��word�����ɫ,��ֵ��wordcolor
            WordColor = WordRandom.Color;
            //��ť��ɫ����
            LeftButtonColor();
            //ʵ���Ұ�ť��ɫ����
            RightButtonColor();
            timeleft = 5;


        }

    }

}
