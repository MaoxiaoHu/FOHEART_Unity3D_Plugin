# 如何使用Unity3D反向控制MotionVenus？
## 一、简介
在某些预先编译完成的Unity3D工程运行时，不方便在MotionVenus与Unity3D之间反复切换，这事可以使用我们提供的Unity3D脚本实现反向控制MotionVenus完成人物校准动作。
## 二、使用准备
穿戴准备好FOHEART C1套装，并打开MotionVenus软件，可以看到左侧设备栏出现套装Actor1(Live)，如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/invCtl/devicelist.png"/>
</div>

## 三、Unity3D端配置
点击运行Unity3D工程，在Edit_ActorName控件中填入第二步中的套装名称Actor1(Live)，然后点击校准按钮并依照提示做出相应校准动作即可：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/invCtl/config.png"/>
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
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/invCtl/ipport.png"/>
</div>