using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

namespace FoheartMC
{
    public class NetFrameDataReceiver : MonoBehaviour
    {
        //UDP命令下发IP地址
        public string UDP_Target_IP = "127.0.0.1";
        public int UDP_Target_Port = 5002;
        //UDP广播接收端口
        public int UDPPort;
        //校准类型定义
        private int CalibrateType_standard = 0x0FFFFFF1;
        private int CalibrateType_arm = 0x0FFFFFF2;
        private int CalibrateType_standard_arm = 0x0FFFFFF3;
        //角色列表,需要手动指定
        public FoheartModel[] PlayerList;
        public bool BonePosition;
        public bool BoneEuler;
        public bool BoneQuat;
		public bool SensorAccel;
        public bool SensorGyro;
        public bool SensorMag;
        //调试文本
        //string OutText;

        public UI_Calibrate Calibrate;
        
        public NetFrameDataReceiver()
        {
            UDPPort = 5001;
            BonePosition = true;
            BoneEuler = true;
            BoneQuat = false;
			SensorAccel = false;
            SensorMag = false;
            SensorGyro = false;
            udpSender = new System.Net.Sockets.UdpClient();
            
        }

        //初始化
        void Start()
        {
            if (true == BoneEuler && true == BoneQuat)
            {
                Debug.Log("You can not set BoneEuler and BoneQuat at the same time.");
                return;
            }
            initRec();
        }

        //UI界面
        void OnGUI()
        {
           // GUI.Label(new Rect(0, 0, 100, 50), OutText);

            Calibrate.ShowCalibrateTips();

        }
        public void OnClickCalibration_standard()
        {
            //模型名称
            string CurActorName = GameObject.Find("Canvas/Edit_ActorName").GetComponent<InputField>().text;

            if (CurActorName == "")
            {
                Debug.Log("请输入校准模型的名称！");
                return;
            }

            bool standard = GameObject.Find("Canvas/Toggle_standard").GetComponent<Toggle>().isOn;
            bool arm = GameObject.Find("Canvas/Toggle_arm").GetComponent<Toggle>().isOn;

            if(!standard && !arm)
            {
                Debug.Log("请选择校准方式！");
                return;
            }
            int CurCalibrateType = CalibrateType_standard;
            if (standard)
                if (arm)
                    CurCalibrateType = CalibrateType_standard_arm;
                else
                    CurCalibrateType = CalibrateType_standard;
            else
                if (arm)
                    CurCalibrateType = CalibrateType_arm;
                else
                {
                    Debug.Log("请选择校准方式！");
                    return;
                }

            //下发校准命令
            OnSendCalibrate(CurActorName, CurCalibrateType);
            
            Debug.Log("点击校准（标准）");
        }
        //UDP接收线程
        Thread thrUDPRecv;
        //UDP接收端
        UdpClient udpReceiver;
        //UDP发送端
        private UdpClient udpSender;

        //初始化接收器
        void initRec()
        {
            udpReceiver = new UdpClient(new IPEndPoint(IPAddress.Any, UDPPort));
            thrUDPRecv = new Thread(mcReceiveData);
            thrUDPRecv.Start();

            udpSender = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
            
            Calibrate = new UI_Calibrate();
        }

        //接收数据的工作线程
        void mcReceiveData()
        {
            //接收广播
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
            ActorFrameData frameDataTemp = new ActorFrameData();
            while (true)
            {
                try
                {
                    byte[] data = udpReceiver.Receive(ref endpoint);

                    if (data.Length == UI_Calibrate.STANDARD_UDP_STATUS_BUFFER_SIZE)
                    {
                        Calibrate.status = BitConverter.ToInt32(data, 0);
                        Calibrate.second = BitConverter.ToInt32(data, Marshal.SizeOf(Calibrate.status));

                    }else
                    {
						int dataErro = frameDataTemp.deComposeData(data, BonePosition, BoneEuler, BoneQuat,SensorAccel,SensorMag,SensorGyro);
                        if (dataErro != 0)
                        {
                            Debug.Log("Data Erro:" + dataErro);
                            continue;
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.Log(e.ToString());
                }

                foreach (FoheartModel model in PlayerList)
                {
                    if (string.Equals(model.ActorName, frameDataTemp.strActorName))
                    {
                        model.copyData(frameDataTemp);
                    }
                }
            }
        }
        //发送命令
        void OnSendCalibrate(string ActorName, int type)
        {
            try
            {
                Byte[] byteArrayData = System.Text.Encoding.Default.GetBytes(ActorName);
                Int32 NameLen = byteArrayData.Length;
                Byte[] sendBytes1 = BitConverter.GetBytes(NameLen);
                Byte[] sendBytes2 = BitConverter.GetBytes(type);
                /*  4 + nameLen + 4
                    * 4字节：nameLen
                    * nameLen：名字内容
                    * 4字节：校准方式
                    * */
                Byte[] TotalData = new Byte[sendBytes1.Length + byteArrayData.Length + sendBytes2.Length];
                System.Buffer.BlockCopy(sendBytes1, 0, TotalData, 0, sendBytes1.Length);
                System.Buffer.BlockCopy(byteArrayData, 0, TotalData, sendBytes1.Length, byteArrayData.Length);
                System.Buffer.BlockCopy(sendBytes2, 0, TotalData, sendBytes1.Length + byteArrayData.Length, sendBytes2.Length);

                udpSender.Send(TotalData, TotalData.Length, UDP_Target_IP, UDP_Target_Port);

            }
            catch (Exception s)
            {
                Debug.Log(s.Message);
            }

        }

        //脚本退出时,停止线程
        void OnApplicationQuit()
        {
            thrUDPRecv.Abort();
            Debug.Log("OnApplicationQuit...");
        }

        void OnDisable()
        {
            //结束接收
            udpReceiver.Close();
            udpSender = null;
        }
        //查找
        FoheartModel getConnectModel(uint packNumber)
        {
            if (packNumber == 0)
            {
                return null;
            }
            //遍历已经连接的模型
            foreach (FoheartModel player in PlayerList)
            {
                if (player && player.ConnectPackNumber == packNumber)
                {
                    return player;
                }
            }
            //如果没有连接的模型,则指定一个,并保存下来
            foreach (FoheartModel player in PlayerList)
            {
                if (player.ConnectPackNumber == 0)
                {
                    player.ConnectPackNumber = packNumber;
                    return player;
                }
            }
            //没有找到可用的模型,则返回空
            return null;
        }
    }
}
