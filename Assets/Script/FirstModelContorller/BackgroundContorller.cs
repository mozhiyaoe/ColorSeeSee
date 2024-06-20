
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using Unity.VisualScripting;

public class BackgroundContorller : TimeLeftContorller
{
  //倒计时开始数字
 
  //是否开始倒计时
  private bool isCounting;

  //创建一个背景颜色变量

  SpriteRenderer BackgroundColor;





  //给背景附上颜色，并创建数组
  public static Color32 BackGroundColor1 = new Color32(239, 52, 115, 255);

  public static Color32 BackGroundColor2 = new Color32(251, 164, 20, 255);
  public static Color32 BackGroundColor3 = new Color32(255, 153, 0, 255);
  public static Color32 BackGroundColor4 = new Color32(189, 221, 34, 255);
  public static Color32 BackGroundColor5 = new Color32(22, 97, 171, 255);
  public static Color32 BackGroundColor6 = new Color32(59, 46, 126, 255);
  public static Color32 BackGroundColor7 = new Color32(126, 22, 113, 255);

  Color32[] BackGroundArry = new Color32[] { BackGroundColor1, BackGroundColor2, BackGroundColor3 ,BackGroundColor4,
  BackGroundColor5,BackGroundColor6, BackGroundColor7};

  //固定背景颜色随机取（如：点名器）
  public Color32 BackgroundChange(Color32[] arr)
  {
    Random ran = new Random();
    int n = ran.Next(arr.Length - 1);
   
    return arr[n];
  }

  // Start is called before the first frame update
  void Start()
  {
    BackgroundColor = gameObject.GetComponent<SpriteRenderer>();

    BackgroundColor.color = BackgroundChange(BackGroundArry);
  }

    private static void Update()
    {
        





    }
}
