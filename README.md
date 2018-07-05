# Official Unity3D Plugin for FOHEART Mocap Suits

### COPYRIGHT
THE INFORMATION CONTAINED HERE IS PROPRIETARY TECHNICAL 
INFORMATION OF FOHEART CO., LTD. TRANSMITTING, REPRODUCTION, 
DISSEMINATION AND EDITING OF THIS DOCUMENT AS WELL AS 
UTILIZATION OF THE CONTENT ARE FORBIDDEN WITHOUT PERMISSION. 
OFFENDERS WILL BE HELD LIABLE FOR PAYMENT OF DAMAGES. ALL 
RIGHTS ARE RESERVED IN THE EVENT OF A PATENT GRANT OR 
REGISTRATION OF A UTILITY MODEL OR DESIGN.
### GENERAL NOTES
FOHEART OFFERS THE INFORMATION AS A SERVICE TO ITS CUSTOMERS. 
THE INFORMATION PROVIDED IS BASED UPON CUSTOMERS�� 
REQUIREMENTS. FOHEART MAKES EVERY EFFORT TO ENSURE THE 
QUALITY OF THE INFORMATION IT MAKES AVAILABLE. FOHEART DOES 
NOT MAKE ANY WARRANTY AS TO THE INFORMATION CONTAINED 
HEREIN, AND DOES NOT ACCEPT ANY LIABILITY FOR ANY INJURY, LOSS 
OR DAMAGE OF ANY KIND INCURRED BY USE OF OR RELIANCE UPON 
THE INFORMATION. ALL INFORMATION SUPPLIED HEREIN IS SUBJECT TO 
CHANGE WITHOUT PRIOR NOTICE.<br>
**For technical support, please visit:**<br>
[http://www.foheart.com/support.html](http://www.foheart.com/support.html) or<br>
[http://www.foheart.com/question.html](http://www.foheart.com/question.html)<br>
**�����ܲ�**<br>
Tel��(+86)010-56106165<br>
Email��contact@foheart.com<br>
��ַ�������к�������ɽ��·��ɽ��8��D2-��-3��<br>
�ʱࣺ100091<br>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/address1.png"/>
</div>

**Copyright(C) FOHEART Co., Ltd. 2015-2018. All rights reserved.**<br>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/softwareName.png"/>
</div>
<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/AssassinsCreedUnity.jpg"/>
</div>

# ǰ��
���ֲ����ʵʱ����������Unity3Dģ���˶������������Ӳ���豸����MotionVenus�����ʹ�������⣬��ο�MotionVenus�����װĿ¼�µ�Help�ļ����µġ�FOHEART C1������װ�����ʹ���ֲᡷ.pdf��
��MotionVenus����û���ر�˵������ָ��FOHEART MotionVenus��������Ը�������κ������ֱ�ӵ����ʼ����������ǣ�motionvenus@foheart.com
# һ�����ز����
����һ���򿪹��� [http://www.foheart.com/resource.html](http://www.foheart.com/resource.html) ����Unity3D�����<br>
��������git clone���⵽Ӳ������λ�ü��ɡ�<br>
���غ����ǿ��Եõ������ļ���

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/zip.png"/>
</div>

���ڰ汾����ԭ�򣬿����ļ���ͬ��
# �����ļ����
���ļ�Ŀ¼�У�����FHMCScript�ǲ���Ĵ��벿�֣�Template����ʾ��ģ�ͣ�**DefaltActor.xml**��ʾ��ģ�͵������ļ���
## 2.1 FHMCScript��Ҫ�ļ����
1. **NetFrameDataReceiver.cs**���ڽ�������MotionVenus�������������������Ҫ���䰲���ڳ������е�һ�����������������ϣ�2D��3D������ɣ��������½�һ��3D Object->Cube������Ϊ**NetworkReceiver**��**NetFrameDataReceiver.cs**�϶�����֮�ϡ����������й����У���Ҫ��NetworkReceiver�ٽ�������������������ֲ���Ԥ�ϵ��������⡣
2. **FoheartModel.cs**���ڿ���ģ���˶��������϶�����Ҫ�����˶���������ģ��֮�ϼ��ɡ�
3. **ActorFrameData.cs**�����ݽ����ļ�������Ҫ���в�����
4. ���� .cs�ļ���һЩ���ƹ��ܵĽű��ļ���<br>

## 2.2 �����ļ�xml
��������ļ����������������й����������û�����ģ�͹����İ󶨹�ϵ���������������������ת��λ�ƣ���������£�������Ҫ�Լ���д��������ļ������÷������յ������е����÷�����<br>
������ʽ���£�<br>

&lt;bone ConnectId = "0" name = "Hips" X="-Y" Y="-X" Z="-Z" XR="-90.0" YR="0.0" ZR="90.0"&gt;&lt;/bone&lt;

Ĭ�ϵı�Ŷ�Ӧ�����������ϵ�ǣ�
<center>��1�����������б�</center>
<div align=center>
<table>
   <tr><th>����</th><th>����</th><th>��ע</th></tr>
   <tr><th>0</th><th>Spine��Hips</th><th>����ģ�͵ĸ��ڵ㣬�������������λ�ƺ͸��ؽڵ����ת</th></tr>
	<tr><th>1</th><th>Spine1</th><th>�൱������L3~L5�ι���</th></tr>
	<tr><th>2</th><th>Spine2</th><th>�൱������T12~L2�ι���</th></tr>
	<tr><th>3</th><th>Spine3</th><th>�൱������T8~T11�ι���</th></tr>
	<tr><th>4</th><th>Spine4</th><th>�൱������T1~T7�ι���</th></tr>
	<tr><th>5</th><th>Neck</th><th></th></tr>
	<tr><th>6</th><th>Head</th><th></th></tr>
	<tr><th>7</th><th>RightShoulder</th><th></th></tr>
	<tr><th>8</th><th>RightArm</th><th></th></tr>
	<tr><th>9</th><th>RightForeArm</th><th></th></tr>
	<tr><th>10</th><th>RightHand</th><th></th></tr>
	<tr><th>11</th><th>LeftShoulder</th><th></th></tr>
	<tr><th>12</th><th>LeftArm</th><th></th></tr>
	<tr><th>13</th><th>LeftForeArm</th><th></th></tr>
	<tr><th>14</th><th>LeftHand</th><th></th></tr>
	<tr><th>15</th><th>RightUpLeg</th><th></th></tr>
	<tr><th>16</th><th>RightLeg</th><th></th></tr>
	<tr><th>17</th><th>RightFoot</th><th></th></tr>
	<tr><th>18</th><th>RightToeBase </th><th>���ֺ����ɵ�ǰ���Ʋ���</th></tr>
	<tr><th>19</th><th>LeftUpLeg</th><th></th></tr>
	<tr><th>20</th><th>LeftLeg</th><th></th></tr>
	<tr><th>21</th><th>LeftFoot</th><th></th></tr>
	<tr><th>22</th><th>LeftToeBase</th><th>���ֺ����ɵ�ǰ���Ʋ���</th></tr>
</table>
</div>

������ϸ�Ĺ�����������ʵλ�òο�ͼ���뿴[[����]](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/bonebindhelp.md)��

��Ҫ��ģ�͵Ķ�Ӧ����������д��xml�ļ���name���У����ɶ���ι���������ת���ơ�

# �������ʹ������
������ʹ������������Unity3D����������ģ�͵ľ��岽�裺<br>
1. �½�һ��Unity���̣�����ʹ�����Լ��Ĺ��̡�<br>
2. ��FHMCScript�ļ��п���������Ŀ¼��AssetsĿ¼�£���DefaltActor.xml ���������̸�Ŀ¼�¡�<br>
3. ����һ������һ��2D��3D���壬�ڱ������У����Ǵ���һ������Canvas������Canvas����Ӱ�ťButton_calibration������NetFrameDataReceiver.cs���õ�Canvas->Button_calibration�ϡ�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/addreceiver.png"/>
</div>

��ɵ�3��֮����Canvas->Button_calibration��Inspector�л���ʾ�������ԣ�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/bindreceiver.png"/>
</div>


���У�

<div align=center>
<table>
   <tr><th>ѡ��</th><th>����</th></tr>
   <tr><th>UDP_Target_IP</th><th>�������MotionVenus������Է�����MotionVenus��PC����IP��ַ</th></tr>
	<tr><th>UDP_Target_Port</th><th>�������MotionVenus������Է�����MotionVenus��PC����Port�˿�</th></tr>
<tr><th>UDPPort</th><th>MotionVenus���Ʊ������������󶨵Ķ˿ڣ���Ҫ��MotionVenus�е�������ͬ</th></tr>
<tr><th>BonePosition</th><th>ʹ��ģ�͵�λ�ƣ�Ĭ��ʹ�ܣ�</th></tr>
<tr><th>BoneEuler</th><th>ʹ��ŷ�������������˶���Ĭ��ʹ�ܣ�</th></tr>
<tr><th>BoneQuat</th><th>ʹ����Ԫ�����������˶���Ĭ�ϲ�ʹ�ܣ�</th></tr>
<tr><th>SensorAccel</th><th>����ԭʼ���ٶȼƵ����ֵ��Ĭ�ϲ�ʹ�ܣ�</th></tr>
<tr><th>SensorGyro</th><th>����ԭʼ�����ǵ����ֵ��Ĭ�ϲ�ʹ�ܣ�</th></tr>
<tr><th>SensorMag</th><th>����ԭʼ�����Ƶ����ֵ��Ĭ�ϲ�ʹ�ܣ�</th></tr>

</table>
</div>

���У�UDPPort���趨��Ҫ��MotionVenus�е��趨��ͬ�������MotionVenus��û������Զ�̵�ַ��������IP��ַ��������Զ�̵�ַ��IP���ڶ˿�������Զ�̵�ַ�Ķ˿ڣ�Ȼ������Ӱ�ť�������ַ�ͱ���ӵ��˷����б�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/mvremoteipport.png"/>
</div>

BonePosition��BoneEuler��BoneQuat**MotionVenus**�е�ת������������λ�ơ�ŷ���ǡ���Ԫ����ѡ�񱣳�һ�£����磺

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/mvtransrule.png"/>
</div>

5. ��Template�ļ����е�FoActorRig.fbx�Ϸŵ������У��������FoheartModel.csΪComponent��������ʾ���£�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/bindmodel.png" width="100%"/>
</div>

����ActorName��Ҫ��MotionVenus�ж�Ӧ������**��װ���**һ�£�����������һ�׵���װ�����**Actor1(Live)**��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/actorname.png"/>
</div>

��ConfigName��Ҫ�빤�̸�Ŀ¼���xml�����ļ�����һ�¡�<br>
Ȼ��ѡ��NetworkReceiver����ActorList��Size��Ϊ1�����Element 0�Ҳ�ѡ��ť���ڵ����Ĵ�����ѡ��ղ����úõ�FoActorRig��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/addtoactorlist.png"/>
</div>

�������֮�����£�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/addactorlistsuccess.png"/>
</div>

�����MotionVenus�������ж����豸��������ֻ��Ҫ��Size��Ϊ�豸��Ŀ��Ȼ������ѡ���豸��Ҫ�󶨵�Model����������Ϊ���������Model��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/multisuits.png"/>
</div>

6. ���������У׼��������ʱģ����MotionVenus�оͿ����������˶������ˡ�

# �ġ�ģ�Ͱ�
�����ڽ�ģ������ʹ�õ�3D��ģ�����ͬ�������ڽ�ģ������û��ʹ������Ƽ��Ĺ���ϵͳ���ͻ���ɹ�������ϵ�Ĳ�ͳһ������Ĺ������ǽ�������ת��������ϵ����Ĺ���ϵͳʹ�ö���������������
## 4.1 Ĭ����������ʽ
MotionVenusʹ�������ʽ������������������̬λ����Ϣ��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/stream.png"/>
</div>

## 4.2 Ĭ������ϵ����
��MotionVenus�е�����ϵ�������£�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/skeletoncoord.png" width="100%"/>
</div>

��MotionVenusʹ����������ϵ��<br>
��T-Poseʱ���й����������ᶨ�嶼Ϊ���ֱ�Ϊx�ᣨ��ɫ�ᣩ���Ϸ�Ϊz�ᣨ��ɫ�ᣩ�������Ϊy�ᣨ��ɫ�ᣩ��������������ǹ�������������ϵ����������ϵ���е���ת������λ��Ҳ������������ϵ�е�λ�ơ�<br>
������ϸ������ϵ�������[�����ӡ�](https://github.com/FOHEART/MotionVenusHelp/blob/v1.4.0/software/coordsystem.md)��

## 4.3 ��תת��ԭ��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/leftrighthand.png"/>
</div>

��Unity3D�е�����ϵΪ��������ϵ��������ͼ�е��֣����ͬ����y����ת90�ȣ��������ת����Ļ�⣬���Ҳ���ת����Ļ�����������Ҳ������ͬ�����⣬���������ͬһ�ι�����MotionVenus�е���ת��U3D�е���ת����һ�£�������������Ҫ�ֶ��������ֲ�ͬ����ϵ��ɵ���ת�任��<br>
����첲Ϊ������Unity3D��������ѡ����ʾ��첲��Local����ϵ��<br>
����첲��U3D����+x����ת����U3D��Ϊ+x������MotionVenus��Ҫ��ﵽͬ��Ч��ҲΪ+x����Ϊ��������ת����ͬ������U3D����+y����ת����MotionVenus��Ҫ��ﵽͬ��Ч��Ϊ��-y����ת��z��Ĺ���Ҳ��ͬ��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/axiscompare.png"/>
</div>

������FoheartModel.cs��applyBoneRotations�����У�����첲����ת����Ϊ��

&lt;bone ConnectId = "12" name = "LeftArm" X="X" Y="-Y" Z="-Z" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;

�������жι��������þ�������ͬ������
## 4.4 ģ�Ͱ�
ʹ������3D��ģ���߹�������������˹���ģ�;���ʹ��MotionVenus������������<br>
MotionVenus���������Ĺ�����׼Ϊ����2.2����[��1]���еĹ�����Ŀ�����Ϊ23�Ρ���Ȼ��Ҳ�������������������23�ι���������ģ�͡������������ö��ǿ���ʵ�ֵģ�
- �輰�貿���ϵ��ϰ����˶���
- �輰�貿���µ��°����˶���
- �����ĵ����˶���
- �����ĵ����˶���
- ������ͷ���˶���
### 4.4.1 ��ģ����
��MotionVenus�У���ģ��T-POSEΪ��ʼ��ת���ÿ�ι�������ڸ���������ԣ�Local����תֵ����������������ȫ�֣�Global����תֵ�������ڽ�ģ������Ƥʱ������ʹ��T-Pose���н�ģ��Ҫ��֤��T-Poseʱģ�ͼ粿�����������������<br>
[[ʲô��T-Pose?]](http://manual.reallusion.com/3DXchange_6/ENU/Pipeline/04_Modify_Page/Character_Section/Manually_Setting_T_Pose.htm)��[[pdf]](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/Manually_Setting_T-Pose.pdf)(ֱ�Ӹ���url���������)<br>
[[Ϊʲôʹ��T-Pose?]](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/whytpose.md)

### 4.4.2 �����ļ�˵��
ÿһ����Ҫ�����˶���ģ�ͣ��������FoheartModel.cs�ű�֮����ҪΨһ��һ��xml�����ļ�������ͼ��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/configfile.png"/>
</div>

�������ļ�Ĭ��λ��ΪUnity3D���̵ĸ�Ŀ¼��<br>
Ĭ�������ļ�DefaultActor.xml���������£�
> &lt;?xml version="1.0" encoding="utf-8"?&gt;
> 
> &lt;!--
> 0=Spine , 1=Spine1 , 2=Spine2, 3=Spine3, 4=Spine4 , 5=Neck, 6=Head, 
> 7=RightShoulder, 8=RightArm, 9=RightForeArm, 10=RightHand, 
> 11=LeftShoulder, 12=LeftArm, 13=LeftForeArm, 14=LeftHand, 
> 15=RightUpLeg, 16=RightLeg, 17=RightFoot, 18=RightToeBase,
> 19=LeftUpLeg, 20=LeftLeg, 21=LeftFoot, 22=LeftToeBase
> --&gt;
> 
> &lt;!--DefaultActor--&gt;<br>
> &lt;ActorBones&gt;<br>
>   &lt;bone ConnectId = "0" name = "Hips" X="-Y" Y="-X" Z="-Z" XR="-90.0" YR="0.0" ZR="90.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "1" name = "Spine1" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "2" name = "Spine2" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "3" name = "Spine3" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "4" name = "Spine4" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "5" name = "Neck" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "6" name = "Head" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
> 
>   &lt;bone ConnectId = "7" name = "RightShoulder" X="-X" Y="-Y" Z="Z" XR="0.0" YR="90.0" ZR="180.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "8" name = "RightArm" X="-X" Y="-Y" Z="Z" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "9" name = "RightForeArm" X="-X" Y="-Y" Z="Z" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "10" name = "RightHand" X="-X" Y="Z" Z="Y" XR="90.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
> 
>   &lt;bone ConnectId = "11" name = "LeftShoulder" X="X" Y="-Y" Z="-Z" XR="0.0" YR="-90.0" ZR="180.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "12" name = "LeftArm" X="X" Y="-Y" Z="-Z" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "13" name = "LeftForeArm" X="X" Y="-Y" Z="-Z" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "14" name = "LeftHand" X="X" Y="Z" Z="-Y" XR="-90.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
> 
>   &lt;bone ConnectId = "15" name = "RightUpLeg" X="-Z" Y="Y" Z="X" XR="0.0" YR="180.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "16" name = "RightLeg" X="-Z" Y="Y" Z="X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "17" name = "RightFoot" X="-Z" Y="Y" Z="X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "18" name = "RightToeBase" X="-Z" Y="Y" Z="X" XR="0.0" YR="0.0" ZR="-90.0"&gt;&lt;/bone&gt;<br>
> 
>   &lt;bone ConnectId = "19" name = "LeftUpLeg" X="-Z" Y="Y" Z="X" XR="0.0" YR="-180.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "20" name = "LeftLeg" X="-Z" Y="Y" Z="X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "21" name = "LeftFoot" X="-Z" Y="Y" Z="X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;<br>
>   &lt;bone ConnectId = "22" name = "LeftToeBase" X="-Z" Y="Y" Z="X" XR="0.0" YR="0.0" ZR="-90.0"&gt;&lt;/bone&gt;<br>
> &lt;/ActorBones&gt;


���У�

<div align=center>
<table>
   <tr><th>�ֶ�����</th><th>����</th></tr>
   <tr><th>ConnectId</th><th>���ƹ���������</th></tr>
	<tr><th>name</th><th>������U3D�е�����</th></tr>
	<tr><th>X Y Z</th><th>����Local����ϵ��MotionVenus��������ϵ�ı任��ϵ</th></tr>
<tr><th>XR YR ZR</th><th>������T-POSEʱ�ĳ�ʼ��̬�ǣ�Local����ϵ�£�</th></tr>
</table>
</div>

��ģ�Ͳ�������23�ι��������ʵ�ɾ�������ڵ�ĳ�ι���������С���ConnectIdΪ0�Ĺ�����Ϊ�������ṩ����ģ�͵Ŀռ�λ�ƣ�����ɾ����
### 4.4.3 ��һ��������ģ��ΪT-POSE
������Ҫ������ģ�͵���ΪT-POSE��ֱ�����й��������������״�档<br>
Ҫ�㣺�ڵ��������У���Ҫ������ϵϵͳ����ΪLocal����ͬʱ�۲���T-POSEʱÿ�ι�������̬�ǣ���ģ�ͷ���4.4.1���еĽ�ģ���飬��ʱÿ�ι�������̬��ӦΪ0�㡢��90����180������֮һ��
### 4.4.4 �ڶ�����д�������
����Ҫ���ƵĹ�������д��xml�ļ��е�name���У���ȷ����Ӧ��λ��ȷ������ͼ��ʾ��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/namelink.jpg" width="100%"/>
</div>

### 4.4.5 ��������д���ʼ�Ƕ�
��T-POSE�е�ÿ�ι����ĳ�ʼ��̬�ǣ����������Ӧ�������ļ����С�Ҳ���������ļ��ж�Ӧ���е�XR YR ZRֵ������ͼ��ʾ��

<center>Ĭ��ģ�����ã������ο�</center>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/xryrzr.jpg" width="100%"/>
</div>

���磺ѡ����磬ѡ��Local����ϵ�����ʼ�Ƕ�Ϊ(0,-90,180)��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/leftshoulderangle.png" width="100%"/>
</div>

��������xml�ļ��д��������У��õ���
>   &lt;bone ConnectId = "11" name = "LeftShoulder" X="X" Y="-Y" Z="-Z" XR="0.0" YR="-90.0" ZR="180.0"&gt;&lt;/bone&gt;

### 4.4.6 ���Ĳ���ȷ����ת˳��
ѡ��ÿ�ι�����Local���꣬����ͼ��A11~A64���ҵ���֮��ȫ��Ӧ����ת˳��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/skeletoncoord.jpg" width="100%"/>
</div>

���ְ棺
<center>��2��������ʼ������</center>

<div align=center>
<table>
   <tr><th>A11</th><th>X="X" Y="-Z" Z="Y"</th><th>A12</th><th>X="X" Y="Y" Z="Z"</th><th>A13</th><th>X="X" Y="Z" Z="-Y"</th><th>A14</th><th>X="X" Y="-Y" Z="-Z"</th></tr>
   <tr><th>A21</th><th>X="-X" Y="Z" Z="Y"</th><th>A22</th><th>X="-X" Y="-Y" Z="Z"</th><th>A23</th><th>X="-X" Y="-Z" Z="-Y"</th><th>A24</th><th>X="-X" Y="Y" Z="-Z"</th></tr>
   <tr><th>A31</th><th>X="-Z" Y="-X" Z="Y"</th><th>A32</th><th>X="-Z" Y="-Y" Z="-X"</th><th>A33</th><th>X="-Z" Y="X" Z="-Y"</th><th>A34</th><th>X="-Z" Y="Y" Z="X"</th></tr>
   <tr><th>A41</th><th>X="Z" Y="X" Z="Y"</th><th>A42</th><th>X="Z" Y="Y" Z="-X"</th><th>A43</th><th>X="Z" Y="-X" Z="-Y"</th><th>A44</th><th>X="Z" Y="-Y" Z="X"</th></tr>
   <tr><th>A51</th><th>X="Y" Y="X" Z="-Z"</th><th>A52</th><th>X="Y" Y="-Z" Z="-X"</th><th>A53</th><th>X="Y" Y="-X" Z="Z"</th><th>A54</th><th>X="Y" Y="Z" Z="X"</th></tr>
   <tr><th>A61</th><th>X="-Y" Y="-X" Z="-Z"</th><th>A62</th><th>X="-Y" Y="Z" Z="-X"</th><th>A63</th><th>X="-Y" Y="X" Z="Z"</th><th>A64</th><th>X="-Y" Y="-Z" Z="X"</th></tr>
</table>
</div>

����ӦAxx�Ҳ�������X="?" Y="?" Z="?"�����Ӧ�������ļ����е���Ӧλ�ã�

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/coordlink.jpg" width="100%"/>
</div>

���磺ѡ����С�ȣ�ѡ��Local����ϵ���ҵ���֮��ȫ��ͬ����ת˳��A34������ת˳���ʾΪ��X="-Z" Y="Y" Z="X"��

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/rightlegexample.jpg" width="100%"/>
</div>

��������xml�ļ��д�����С�ȵ��У��õ���
>   &lt;bone ConnectId = "16" name = "RightLeg" **X="-Z" Y="Y" Z="X"** XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;

### 4.4.7 ת��ʵ��
[��ʵ��1��](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/bindingexample1.md)
### 4.4.8 ���ڹ��̴��
Unity���̱���������exe֮���轫ģ�Ͱ󶨵�xml�ļ����õ���.exe��ͬ��Ŀ¼�£�һ���ǹ��̸�Ŀ¼��

# �塢����ʹ�ý̳�
1. ��ΰ󶨲��������ģ���˶���<br>
��ϸ�̳������[�����ӡ�](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/multiActor.md)

2. ���ʹ��Unity3D�������MotionVenus��<br>
��ϸ�̳������[�����ӡ�](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/invCtl.md)

3. �󶨺��ģ�ͻ���/���ջ��߽Ų��ڵ����µ�������ν����<br>
��ϸ�̳������[�����ӡ�](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/footslide.md)

# ����ע������
���ʹ��ʱ����Ҫע�����µط���
1. ��ģ�Ͱ󶨹����У���Ҫ���Ƚ�ģ�͵�������׼��T���ƣ������������泯��Unity3D��Z��������
2. ʹ��Unity3D�Ĺ�����MotionVenus������С����

# �ߡ�Q&A
1. ���ģ�͵Ĺ�����Ŀ����23�Σ����米��������5����β�����<br>
��Ҫ�����������е�ĳ���κ�Ϊһ�ο��ƣ�������Unity3D����ת����������������е��ӽڵ���ת������ֻ��Ҫ���������������xml�ļ��м��ɣ����Ҫ��֤���й�����ĿС�ڵ���23�Ρ�
2. ���ģ�͵Ĺ�����ĿС��23�Σ����米������ֻ��2����β�����<br>
�������������Ҫȥ��xml�ļ��в���Ҫ�����������Ǳ���Ҫ����Hips��Spine�ڵ㣬��Ϊ����ڵ㻹��������ģ�͵�λ�ã����ȥ������ģ�;Ͳ����˶����������£�

&lt;bone ConnectId="0" name="Hips X="-Y" Y="-X" Z="-Z" XR="-90.0" YR="0.0" ZR="90.0"&gt;&lt;/bone&gt;

&lt;bone ConnectId="3" name="Spine1" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;

����������ȥ����1 2 4�����ι�������Ϊģ����û�������ι��������Ҳ���൱���ñ�׼ģ�͵�T8~T11�ι����˶�������ģ�͵�Spine1�ι����˶�����ȻҲ����ʹ������1��2�����ģ�͵�Spine1�ι����ȽϿ��½ӽ��貿����4�����ģ�͵�Spine1�ι����ȽϿ��Ͻӽ�����������Ҫ����ʵ�����������<br>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/tail.png" width="100%"/>
</div>