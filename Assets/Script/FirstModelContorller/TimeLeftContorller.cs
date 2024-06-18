using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftContorller : MonoBehaviour
{
    // Start is called before the first frame update
    //倒计时开始数字
    public float timeleft;
    //文本先是倒计时
    public Text CountdownText;
    //是否开始倒计时
    private bool isCounting;
    void Start()
    {
        //开始倒计时
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {

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
