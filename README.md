# Official Unity3D Plugin for FOHEART Mocap Suits
<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/softwareName.png"/>
</div>
<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/AssassinsCreedUnity.jpg"/>
</div>

# 前言
此手册介绍实时数据流驱动Unity3D模型运动，如果您对于硬件设备或者MotionVenus软件的使用有问题，请参看MotionVenus软件安装目录下的Help文件夹下的《FOHEART C1驱动安装与软件使用手册》.pdf。
“MotionVenus”如没有特别说明，均指“FOHEART MotionVenus”。如果对该软件有任何问题可直接电子邮件反馈给我们：motionvenus@foheart.com
# 一、下载插件包
方法一：打开官网 [http://www.foheart.com/resource.html](http://www.foheart.com/resource.html) 下载Unity3D插件。<br>
方法二：git clone本库到硬盘任意位置即可。<br>
下载后我们可以得到以下文件：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/zip.png"/>
</div>

由于版本更新原因，可能文件不同。
# 二、文件简介
在文件目录中，其中FHMCScript是插件的代码部分，Template中是示例模型，**DefaltActor.xml**是示例模型的配置文件。
## 2.1 FHMCScript主要文件简介
1. **NetFrameDataReceiver.cs**用于接收来自MotionVenus软件的网络数据流，需要将其安置在场景当中的一个单独的永久物体上（2D、3D物体均可），例如新建一个3D Object->Cube，命名为**NetworkReceiver**将**NetFrameDataReceiver.cs**拖动到它之上。在整个运行过程中，不要对NetworkReceiver再进行其它操作，以免出现不可预料的网络问题。
2. **FoheartModel.cs**用于控制模型运动。将其拖动到需要控制运动的类人体模型之上即可。
3. **ActorFrameData.cs**是数据解析文件，不需要进行操作。
4. 其他 .cs文件是一些定制功能的脚本文件。
## 2.2 配置文件xml
这个配置文件决定了网络数据中骨骼数据与用户骨骼模型骨骼的绑定关系，它决定了人体骨骼的旋转和位移，正常情况下，我们需要自己编写这个配置文件，配置方法参照**DefaltActor.xml**的配置方法。<br>
配置文件中的**ConnectId** 是骨骼的索引编号，**name**是这个位置控制的模型骨骼的名称，**X Y Z**为骨骼初始旋转顺序，**XR YR ZR**为**T_Pose**下骨骼的本地旋转**角度**值。<br>

&lt;bone ConnectId = "0" name = "Hips" X="-Y" Y="-X" Z="-Z" XR="-90.0" YR="0.0" ZR="90.0"&gt;&lt;/bone&lt;

默认的编号对应的人体骨骼关系是：
<center>表1：完整骨骼列表</center>
<div align=center>
<table>
   <tr><th>索引</th><th>名称</th><th>备注</th></tr>
   <tr><th>0</th><th>Spine或Hips</th><th>类人模型的根节点，控制整个人体的位移和根关节点的旋转</th></tr>
	<tr><th>1</th><th>Spine1</th><th>相当于人体L3~L5段骨骼</th></tr>
	<tr><th>2</th><th>Spine2</th><th>相当于人体T12~L2段骨骼</th></tr>
	<tr><th>3</th><th>Spine3</th><th>相当于人体T8~T11段骨骼</th></tr>
	<tr><th>4</th><th>Spine4</th><th>相当于人体T1~T7段骨骼</th></tr>
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
	<tr><th>18</th><th>RightToeBase </th><th>五块趾骨组成的前脚掌部分</th></tr>
	<tr><th>19</th><th>LeftUpLeg</th><th></th></tr>
	<tr><th>20</th><th>LeftLeg</th><th></th></tr>
	<tr><th>21</th><th>LeftFoot</th><th></th></tr>
	<tr><th>22</th><th>LeftToeBase</th><th>五块趾骨组成的前脚掌部分</th></tr>
</table>
</div>


需要将模型的对应骨骼名称填写在xml文件的name栏中，即可对这段骨骼进行旋转控制。
## 2.3 非标准骨骼绑定
1. 如果模型的骨骼数目大于23段，比如背部骨骼有5段如何操作？<br>
需要将背部骨骼中的某两段合为一段控制，由于在Unity3D中旋转父骨骼会带动它所有的子节点旋转，所以只需要将父骨骼的名称填到xml文件中即可，最后要保证所有骨骼数目小于等于23段。
2. 如果模型的骨骼数目小于23段，比如背部骨骼只有2段如何操作？<br>
在这种情况下需要去掉xml文件中不需要的索引，但是必须要留下Hips或Spine节点，因为这个节点还控制整个模型的位置，如果去掉整个模型就不会运动。例如以下：

&lt;bone ConnectId="0" name="Hips X="-Y" Y="-X" Z="-Z" XR="-90.0" YR="0.0" ZR="90.0"&gt;&lt;/bone&gt;

&lt;bone ConnectId="3" name="Spine1" X="Z" Y="Y" Z="-X" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;

在这里首先去掉了1 2 4这三段骨骼，因为模型中没有这三段骨骼，因此也就相当于用标准模型的T8~T11段骨骼运动代替了模型的Spine1段骨骼运动，当然也可以使用索引1或2（如果模型的Spine1段骨骼比较靠下接近胯部）或4（如果模型的Spine1段骨骼比较靠上接近颈部），需要根据实际情况而定。
# 三、插件使用流程
下面是使动捕数据流在Unity3D中驱动任意模型的具体步骤：
1. 新建一个Unity工程，或是使用你自己的工程。
2. 将FHMCScript文件夹拷贝到工程目录的Assets目录下，将DefaltActor.xml 拷贝到工程根目录下。
3. 创建一个任意一个2D或3D物体，命名为NetworkReceiver，设置scale为0.1，去掉Mesh Renderer使之基本不可见。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/addreceiver.png"/>
</div>

4. 将NetFrameDataReceiver.cs 拖放到NetworkReceiver上，在其Inspector中会显示下面属性：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/bindreceiver.png"/>
</div>

UDP Port的设定需要与MotionVenus中的设定相同，如果在MotionVenus中没有设置远程地址，可以在IP地址栏中输入远程地址的IP，在端口中输入远程地址的端口，然后点击添加按钮，这个地址就被添加到了发送列表。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/mvremoteipport.png"/>
</div>

Position、Euler、Quat的设定需要与**MotionVenus**中的转发规则设置中位移、欧拉角、四元数的选择保持一致，例如：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/mvtransrule.png"/>
</div>

5. 将Template文件夹中的FoActorRig.fbx拖放到场景中，并且添加FoheartModel.cs为Component，最终显示如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/bindmodel.png"/>
</div>

其中ActorName需要与MotionVenus中对应的人物**套装编号**一致，例如下面这一套的套装编号是**Actor1(Live)**。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/actorname.png"/>
</div>

而ConfigName需要与工程根目录里的xml配置文件名称一致。<br>
然后选择NetworkReceiver，将ActorList中Size设为1，点击Element 0右侧选择按钮，在弹出的窗口中选择刚才设置好的FoActorRig。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/addtoactorlist.png"/>
</div>

设置完成之后如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/addactorlistsuccess.png"/>
</div>

如果在MotionVenus中连接有多套设备，在这里只需要将Size设为设备数目，然后依次选择设备需要绑定的Model，例如下面为添加了两个Model：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/multisuits.png"/>
</div>

6. 穿戴并完成校准动作，此时模型在MotionVenus中就可以正常的运动起来了。

# 四、模型绑定
由于在建模过程中使用的3D建模软件不同，或者在建模过程中没有使用软件推荐的骨骼系统，就会造成骨骼坐标系的不统一，这里的工作就是将任意旋转任意坐标系朝向的骨骼系统使用动捕数据流驱动。
## 4.1 默认数据流格式
MotionVenus使用下面格式的数据流输出人物的姿态位置信息：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/stream.png"/>
</div>

## 4.2 默认坐标系定义
在MotionVenus中的坐标系定义如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/skeletoncoord.png"/>
</div>

即MotionVenus使用右手坐标系。<br>
在T-Pose时所有骨骼的坐标轴定义都为左手边为x轴（红色轴），上方为z轴（蓝色轴），身体后方为y轴（绿色轴），数据流输出的是骨骼在世界坐标系（右手坐标系）中的旋转，骨骼位移也是在世界坐标系中的位移。<br>
更加详细的坐标系解释请见[【链接】](https://github.com/FOHEART/MotionVenusHelp/blob/v1.4.0/software/coordsystem.md)。

## 4.3 旋转转换

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/leftrighthand.png"/>
</div>

在Unity3D中的坐标系为左手坐标系，例如上图中的手，如果同样沿y轴旋转90度，则左侧手转向屏幕外，而右侧手转向屏幕里，其它两个轴也存在相同的问题，这样会造成同一段骨骼在MotionVenus中的旋转和U3D中的旋转现象不一致，在这里我们需要手动纠正这种不同坐标系造成的旋转变换。<br>
以左胳膊为例，在Unity3D工具栏中选择显示左胳膊的Local坐标系。<br>
例如胳膊在U3D中沿+x轴旋转，在U3D中为+x，而在MotionVenus中要想达到同样效果也为+x（因为左右手旋转规则不同）；在U3D中沿+y轴旋转，在MotionVenus中要想达到同样效果为沿-y轴旋转；z轴的规则也相同。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/img/axiscompare.png"/>
</div>

所以在FoheartModel.cs中applyBoneRotations函数中，对左胳膊的旋转设置为：

&lt;bone ConnectId = "12" name = "LeftArm" X="X" Y="-Y" Z="-Z" XR="0.0" YR="0.0" ZR="0.0"&gt;&lt;/bone&gt;

其它所有段骨骼的设置均遵守相同方法。
## 4.4 模型绑定
使用任意3D建模工具构建的人体或类人骨骼模型均可使用MotionVenus数据流驱动。<br>
MotionVenus可以驱动的骨骼标准为本文2.2节中[表1]所列的骨骼数目，最大为23段。当然，也可灵活配置以驱动少于23段骨骼的类人模型。例如以下配置都是可以实现的：
- 胯及胯部以上的上半身运动。
- 胯及胯部以下的下半身运动。
- 单独的单臂运动。
- 单独的单腿运动。
- 单独的头部运动。
### 4.4.1 建模建议
在MotionVenus中，以模型T-POSE为起始旋转输出每段骨骼相对于父骨骼的相对（Local）旋转值或相对于世界坐标的全局（Global）旋转值。所以在建模及绑定蒙皮时，建议使用T-Pose进行建模，要保证在T-Pose时模型肩部无耸起、拉扯等情况。<br>
[什么是T-Pose?]<br>
[[为什么使用T-Pose?]](https://github.com/FOHEART/FOHEART_Unity3D_Plugin/blob/master/help/whytpose.md)
### 4.4.2 配置文件说明
每一个需要控制运动的模型，当添加完FoheartModel.cs脚本之后，需要唯一绑定一个xml配置文件，如下图：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.3.6/help/img/configfile.png"/>
</div>

该配置文件默认位置为Unity3D工程的根目录。<br>
默认配置文件DefaultActor.xml的内容如下：
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


其中：

<div align=center>
<table>
   <tr><th>字段名称</th><th>功能</th></tr>
   <tr><th>ConnectId</th><th>控制骨骼的索引</th></tr>
	<tr><th>name</th><th>骨骼在U3D中的名字</th></tr>
	<tr><th>X Y Z</th><th>骨骼Local坐标系与MotionVenus右手坐标系的变换关系</th></tr>
<tr><th>XR YR ZR</th><th>骨骼在T-POSE时的初始姿态角（Local坐标系下）</th></tr>
</table>
</div>

若模型并不满足23段骨骼，可适当删除不存在的某段骨骼代表的行。但ConnectId为0的骨骼作为根骨骼提供整个模型的空间位移，不可删除。
### 4.4.3 第一步：调整模型为T-POSE
首先需要将导入模型调整为T-POSE，直到所有骨骼都落在人体冠状面。<br>
要点：在调整过程中，需要将坐标系系统调整为Local，并同时观察在T-POSE时每段骨骼的姿态角，若模型符合4.4.1节中的建模建议，此时每段骨骼的姿态角应为0°、±90°或±180°其中之一。
### 4.4.4 第二步：写入骨骼名
将需要控制的骨骼名称写入xml文件中的name栏中，并确定对应部位正确。如下图所示：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.3.6/help/img/namelink.jpg"/>
</div>

### 4.4.5 第三步：写入初始角度
将T-POSE中的每段骨骼的初始姿态角，填入与其对应的配置文件行中。也就是配置文件中对应行中的XR YR ZR值。如下图所示：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.3.6/help/img/xryrzr.jpg"/>
</div>

### 4.4.6 第四步：确定旋转顺序
选择每段骨骼的Local坐标，在下图中A11~A64中找到与之完全对应的旋转顺序：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.3.6/help/img/skeletoncoord.jpg"/>
</div>

文字版：
<div align=center>
<table>
   <tr><th>A11</th><th>X="X" Y="-Z" Z="Y"</th><th>A12</th><th>X="X" Y="Y" Z="Z"</th><th>A13</th><th>X="X" Y="Z" Z="-Y"</th><th>A14</th><th>X="X" Y="-Y" Z="-Z"</th></tr>
   <tr><th>A21</th><th>X="-X" Y="Z" Z="Y"</th><th>A22</th><th>X="-X" Y="-Y" Z="Z"</th><th>A23</th><th>X="-X" Y="-Z" Z="-Y"</th><th>A24</th><th>X="-X" Y="Y" Z="-Z"</th></tr>
   <tr><th>A21</th><th>X="-Z" Y="-X" Z="Y"</th><th>A22</th><th>X="-Z" Y="-Y" Z="-X"</th><th>A23</th><th>X="-Z" Y="X" Z="-Y"</th><th>A24</th><th>X="-Z" Y="Y" Z="X"</th></tr>
   <tr><th>A21</th><th>X="Z" Y="X" Z="Y"</th><th>A22</th><th>X="Z" Y="Y" Z="-X"</th><th>A23</th><th>X="Z" Y="-X" Z="-Y"</th><th>A24</th><th>X="Z" Y="-Y" Z="X"</th></tr>
   <tr><th>A21</th><th>X="Y" Y="X" Z="-Z"</th><th>A22</th><th>X="Y" Y="-Z" Z="-X"</th><th>A23</th><th>X="Y" Y="-X" Z="Z"</th><th>A24</th><th>X="Y" Y="Z" Z="X"</th></tr>
   <tr><th>A21</th><th>X="-Y" Y="-X" Z="-Z"</th><th>A22</th><th>X="-Y" Y="Z" Z="-X"</th><th>A23</th><th>X="-Y" Y="X" Z="Z"</th><th>A24</th><th>X="-Y" Y="-Z" Z="X"</th></tr>
</table>
</div>

将对应Axx右侧所附的X="?" Y="?" Z="?"填入对应的配置文件行中的相应位置：

# 五、注意事项
插件使用时，需要注意以下地方：
1. 在模型绑定过程中，需要首先将模型调整到标准的T姿势，并且人物正面朝向Unity3D的Z轴正方向。
2. 使用Unity3D的过程中MotionVenus不可最小化。
