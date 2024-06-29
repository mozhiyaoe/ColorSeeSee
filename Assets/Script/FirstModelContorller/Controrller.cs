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

public class Controrller : MonoBehaviour
{
    //����һ��������ɫͼ��
    
    public Image BackgroundImage;

    //��ť��ͼ��
    public Image LeftButtonImage;
    //ʣ�µ�ʱ��
    
    public float TimeLeft;
    //��������
    public Text CountdownText;
    //�Ƿ�ʼ����
    private bool isCounting;
    //����
    public Text WordText;
    //�Ұ�ťͼ��
    public Image RightButtonImage;

    //����һ��word���������������Word����
    public Word WordRandom;
    //����һ���ֱ�ʾ��ɫ�ı��������������������ɫ
    public static Color32 WordColor;
    //����һ��������ɫ�ı������������ձ�������ɫ
    public static Color32 BackgroundColor;





    //����ɫʵ����
    public static Color32 Color1 = new Color32(255, 0, 0, 255);

    public static Color32 Color2 = new Color32(242, 253, 255, 255);
    public static Color32 Color3 = new Color32(255, 255, 0, 255);
    public static Color32 Color4 = new Color32(0, 255, 0, 255);
    public static Color32 Color5 = new Color32(0, 255, 255, 255);
    public static Color32 Color6 = new Color32(0, 0, 128, 255);
    public static Color32 Color7 = new Color32(128, 0, 128, 255);


    //���ָ�����ɫ����������
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


    //����������ʵ����
    public static Word Word1 = new Word("��", Color1);
    public static Word Word2 = new Word("��", Color2);
    public static Word Word3 = new Word("��", Color3);
    public static Word Word4 = new Word("��", Color4);
    public static Word Word5 = new Word("��", Color5);
    public static Word Word6 = new Word("��", Color6);
    public static Word Word7 = new Word("��", Color7);
    //������ɫ����
    [HideInInspector]
    public Color32[] ColorArry = new Color32[] { Color1, Color2, Color3 ,Color4,
  Color5,Color6, Color7};
    //����������
    public Word[] WordArry = new Word[] { Word1, Word2, Word3, Word4, Word5, Word6, Word7 };





    //���������ȡ
    public Word WordChange(Word[] arry)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(0, 7);
        return arry[n];
    }


    //������ɫ���ȡ
    public Color32 ColorChange(Color32[] arr)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(0, 7);
        return arr[n];
    }
    //����һ����ťȡ��ɫ�ķ���
    public void LeftButtonColor()
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


    }
    //�����Ұ�ťȡ��ɫ�ķ���
    public void RightButtonColor()
    {
        if (LeftButtonImage.color == WordColor)
        {
            RightButtonImage.color = BackgroundColor;
        }
        else
        {
            RightButtonImage.color = WordColor;
        }

    }
    public void Coloring()
    {
        //ʹ�ñ���ͼƬ��ɫ���
        BackgroundImage.color = ColorChange(ColorArry);
        //���ȡ������WordRandom�������ȡ������
        WordRandom = WordChange(WordArry);


        //while (BackgroundImage.color == WordRandom.Color)
        //{
        //    //ʹ�ñ���ͼƬ��ɫ���
        //    BackgroundImage.color = ColorChange(ColorArry);
        //    //���ȡ������WordRandom�������ȡ������
        //    WordRandom = WordChange(WordArry);
        //}
        //��һ���������ܱ�����ɫ�������Ķ�
        BackgroundColor = BackgroundImage.color;


        //ʹ�ý�������ֺ����ȡ��Word�����������һ��
        WordText.text = WordRandom.Name;
        //�����ȡ��word�����ɫ,��ֵ��wordcolor
        WordColor = WordRandom.Color;
        //��ť��ɫ����
        LeftButtonColor();
        //ʵ���Ұ�ť��ɫ����
        RightButtonColor();

    }




    // Start is called before the first frame update
    void Start()
    {
        //��ʼ��ʱ
        isCounting = true;
        
      




        Coloring();




    }
    void Update()
    {
        //�������ָ�ʽ
        CountdownText.text = TimeLeft.ToString(format: "0.00");
        //�ж��Ƿ�ʼ����ʱ
        if (isCounting)
        {
            TimeLeft -= Time.deltaTime;

        }
        //������ʱС�ڵ���0ʱ��ֹͣ����ʱ
        if (TimeLeft <= 0 && isCounting)
        {
            //ֹͣ����ʱ
            isCounting = false;
        }
    



    }
}
