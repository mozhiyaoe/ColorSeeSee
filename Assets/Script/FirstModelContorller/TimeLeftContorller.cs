using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftContorller : MonoBehaviour
{
    // Start is called before the first frame update
    //����ʱ��ʼ����
    public float timeleft;
    //�ı����ǵ���ʱ
    public Text CountdownText;
    //�Ƿ�ʼ����ʱ
    private bool isCounting;
    void Start()
    {
        //��ʼ����ʱ
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {

        //�ж��Ƿ�ʼ����ʱ
        if (isCounting)
        {
            timeleft -= Time.deltaTime;

        }
        //�ı�����ʱ��������
        CountdownText.text = timeleft.ToString(format: "0.00");
        //������ʱС�ڵ���0ʱ��ֹͣ����ʱ
        if (timeleft <= 0 && isCounting)
        {
            //ֹͣ����ʱ
            isCounting = false;
        }
    }
}
