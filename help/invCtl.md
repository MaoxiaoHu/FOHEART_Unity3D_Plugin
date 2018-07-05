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

# 如何使用Unity3D反向控制MotionVenus？
## 一、简介
在某些预先编译完成的Unity3D工程运行时，不方便在MotionVenus与Unity3D之间反复切换，这时可以使用我们提供的Unity3D脚本实现反向控制MotionVenus完成人物校准动作。
## 二、使用准备
穿戴准备好FOHEART C1套装，并打开MotionVenus软件，可以看到左侧设备栏出现套装Actor1(Live)，如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/invCtl/devicelist.png"/>
</div>

## 三、Unity3D端配置
点击运行Unity3D工程，在Edit_ActorName控件中填入第二步中的套装名称Actor1(Live)，然后点击校准按钮并依照提示做出相应校准动作即可：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/invCtl/config.png"/>
</div>

## 四、注意事项
需要确保Unity3D中的NetFrameDataReceiver中的UDP_Target_IP与UDP_Target_Port与运行MotionVenus的主机的IP与端口相同。其中UDP_Target_Port在MotionVenus中的设置->选项->命令接收中配置。

<div align=center>
<table>
   <tr><th>选项</th><th>功能</th></tr>
   <tr><th>UDP_Target_IP</th><th>反向控制MotionVenus，代表对方运行MotionVenus的PC机的IP地址</th></tr>
	<tr><th>UDP_Target_Port</th><th>反向控制MotionVenus，代表对方运行MotionVenus的PC机的Port端口</th></tr>


</table>
</div>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/invCtl/ipport.png"/>
</div>

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/tail.png"/>
</div>