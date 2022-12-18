using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine.UI;

public class clock : MonoBehaviour
{

    float currentVaule;
    public Text show;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void s() {
    //         SceneManager.LoadScene("SampleScene");
    //     }

    public  void  s(){
        // show.text = currentVaule.ToString("00");

        // int y = 2022, m = 12, d = 30;     //设置考试时间，eg.2022年12月30日
        DateTime ddl = new DateTime(2022, 12, 30, 14, 00, 00, 00);
        DateTime now = DateTime.Now;
        TimeSpan timeSpan = ddl.Subtract(now).Duration();
        int day = timeSpan.Days;    //获取当前 TimeSpan 结构所表示的时间间隔的天数部分。 
        int hour = timeSpan.Hours;  //获取当前 TimeSpan 结构所表示的时间间隔的小时数部分。
        int min = timeSpan.Minutes; //获取当前 TimeSpan 结构所表示的时间间隔的分钟数部分。
        int sec = timeSpan.Seconds; //获取当前 TimeSpan 结构所表示的时间间隔的秒数部分。
        // string str1 = "考试时间为"+ddl.Yesr.ToString()+"年"+ddl.Month.ToString()+"月"+ddl.Day.ToString()+"日";
        string str1 = "考试时间为" + string.Format("{0:yyyy/MM/dd dddd}", ddl) + "\n";
        string str2 = "距离考试还有" + day + "天" + hour + "小时\n";
        // string str = "test";
        int IQ = int.Parse(show.text), need = 80;
        string str3 = "当前智力值为：" + IQ + "\n", str4;
        if (need - IQ <= 0) str4 = "当前智力值已达到要求！\n";
        else str4 = "通过考试需要智力值为" + need + "，还需" + (need-IQ) + "智力值\n";
        UnityEditor.EditorUtility.DisplayDialog("考试倒计时", str1 + str2 + str3 + str4, "确认");
        }
}
