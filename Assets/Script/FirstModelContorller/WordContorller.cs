using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.UI;

public class WordContorller : BackgroundContorller
{
    public Text WordText;
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
    string[] WordName = { Word1.wordname, Word2.wordname, Word3.wordname, Word4.wordname, Word5.wordname, Word6.wordname, Word7.wordname };
    public string WordnameChange(string[] arry)
    {
        System.Random ran = new System.Random();
        int n = ran.Next(arry.Length - 1);
        return arry[n];
    }

    // Start is called before the first frame update
    void Start()
    {
        WordText.text = WordnameChange(WordName);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
