using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftContorller : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeleft;

    public Text CountdownText;

    private bool isCounting;
    void Start()
    {

        isCounting = true;
    }

    // Update is called once per frame
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
