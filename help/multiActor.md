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
THE INFORMATION PROVIDED IS BASED UPON CUSTOMERS’ 
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
**北京总部**<br>
Tel：(+86)010-56106165<br>
Email：contact@foheart.com<br>
地址：北京市海淀区黑山扈路红山口8号D2-南-3号<br>
邮编：100091<br>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/address1.png"/>
</div>

**Copyright © FOHEART Co., Ltd. 2015-2018. All rights reserved.**<br>

# 如何使用MotionVenus驱动Unity3D中多个模型运动？
## 一、使用准备
MotionVenus可以实时或者离线驱动Unity3D中的一个或者多个模型运动，U3D中的模型可以单独设置起始位置、大小缩放等。
## 二、添加模型
作为演示，这里我们添加一个模型：FoActorRig2<br>
绑定脚本FoheartModel.cs，如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/multiActor/addActor.png"/>
</div>

## 三、添加控制列表
在Canvas->Button_calibration的控制脚本中，将Player List的Size改为2，并选中Element1的控制对象为FoActorRig2，如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/multiActor/modifyList.png"/>
</div>

## 四、MotionVenus端配置
作为演示，这里我们打开两个离线文件：（1）NPC2 （2）wushu_3_30 如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/multiActor/mvconfig.png"/>
</div>

## 五、Unity3D端绑定
在这里，我们假设使用NPC2数据流控制FoActorRig运动，使用wushu_3_30控制FoActorRig2运动，那么设置如下：<br>
（1）设置FoActorRig的脚本中Actor Name为**NPC2**。<br>
（2）设置FoActorRig2的脚本中Actor Name为**wushu_3_30**。<br>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/multiActor/rig1.png"/>
</div>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/multiActor/rig2.png"/>
</div>

## 六、运行
在MotionVenus端点击播放，在Unity3D端也点击播放，则两部分都可以同步运动，如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/multiActor/run.png"/>
</div>

## 七、Q&A:
1. 最多可以控制多少组模型运动？<br>
MotionVenus最多可以发送4组实时数据流、或者5组离线数据流到Unity3D。但是在Unity3D端可以将多个模型绑定到一组数据流上。
2. 可以分别控制每个模型的起始位置与大小吗？<br>
可以。设置每个模型控制脚本中的**Location Offset XYZ**与**Location Scale XYZ**实现。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/tail.png"/>
</div>