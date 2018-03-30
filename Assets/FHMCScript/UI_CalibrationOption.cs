using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FoheartMC
{
    public class UI_Calibrate
    {

        //UDP 校准命令状态定义
        public const int STANDARD_UDP_STATUS_BUFFER_SIZE = 8;
        public const int STANDARD_UDP_STATUS_Z_PRE = 11;
        public const int STANDARD_UDP_STATUS_Z_GET = 12;
        public const int STANDARD_UDP_STATUS_I_PRE = 21;
        public const int STANDARD_UDP_STATUS_I_GET = 22;
        public const int STANDARD_UDP_STATUS_T_PRE = 31;
        public const int STANDARD_UDP_STATUS_T_GET = 32;
        public const int STANDARD_UDP_STATUS_S_PRE = 41;
        public const int STANDARD_UDP_STATUS_S_GET = 42;
        public const int STANDARD_UDP_STATUS_COMPLETE = 100;

        public Text CalibrateStatusText= null;
        public Int32 status;
        public Int32 second;

         public UI_Calibrate()
        {
            CalibrateStatusText = GameObject.Find("Canvas/Tips").GetComponent<Text>();
        }
        // Use this for initialization
        void Start()
        {

        }


        public delegate void TaskDelegate(Int32 type, Int32 ms); 
        
        //显示校准状态信息
        public void ShowCalibrateTips(/*Int32 status, Int32 second*/)
        {
            //Int32 status, Int32 second

            string Tips_Second = string.Format("{0:D1}", second);
            string Tips_All = "";
            
            switch (status)
            {
                case STANDARD_UDP_STATUS_Z_PRE:    //准备Z
                    Tips_All = "校准中【Z-Pos】，准备倒计时(" + Tips_Second+"s)...";
                    break;
                case STANDARD_UDP_STATUS_Z_GET:    //收集Z
                    Tips_All = "校准中【Z-Pos】，数据收集中...";
                    break;
                case STANDARD_UDP_STATUS_I_PRE:    //准备I
                    Tips_All = "校准中【I-Pos】，准备倒计时(" + Tips_Second + "s)...";
                    break;
                case STANDARD_UDP_STATUS_I_GET:    //收集I
                    Tips_All = "校准中【I-Pos】，数据收集中...";
                    break;
                case STANDARD_UDP_STATUS_T_PRE:    //准备T
                    Tips_All = "校准中【T-Pos】，准备倒计时(" + Tips_Second + "s)...";
                    break;
                case STANDARD_UDP_STATUS_T_GET:    //收集T
                    Tips_All = "校准中【T-Pos】，数据收集中...";
                    break;
                case STANDARD_UDP_STATUS_S_PRE:    //准备S
                    Tips_All = "校准中【S-Pos】，准备倒计时(" + Tips_Second + "s)...";
                    break;
                case STANDARD_UDP_STATUS_S_GET:    //收集S
                    Tips_All = "校准中【S-Pos】，数据收集中...";
                    break;
                case STANDARD_UDP_STATUS_COMPLETE:
                    Tips_All = "校准完成！";
                    break;
            }
            CalibrateStatusText.text = Tips_All;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
