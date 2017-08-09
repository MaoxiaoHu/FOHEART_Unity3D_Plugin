# Official Unity3D Plugin for FOHEART Mocap Suits
<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/softwareName.png"/>
</div>
<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/AssassinsCreedUnity.jpg"/>
</div>

# 前言
此手册介绍实时数据流驱动Unity3D模型运动，如果您对于硬件设备或者MotionVenus软件的使用有问题，请参看MotionVenus软件安装目录下的Help文件夹下的《FOHEART C1驱动安装与软件使用手册》.pdf。
“MotionVenus”如没有特别说明，均指“FOHEART MotionVenus”。如果对该软件有任何问题可直接电子邮件反馈给我们：motionvenus@foheart.com
# 一、下载插件包
方法一：打开官网 [http://www.foheart.com/resource.html](http://www.foheart.com/resource.html) 下载Unity3D插件。<br>
方法二：git clone本库到硬盘任意位置即可。<br>
下载后我们可以得到以下文件：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/zip.png"/>
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
这个配置文件决定了网络数据中骨骼数据与用户骨骼模型骨骼的绑定关系，它的决定人体骨骼的旋转和位移，正常情况下，我们需要自己编写这个配置文件，配置方法参照**DefaltActor.xml**的配置方法。配置文件中的**ConnectId** 是骨骼的索引编号，**name**是这个位置控制的模型骨骼的名称。<br>
默认的编号与骨骼的对应关系是：
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
	<tr><th>18</th><th>RightToeBase </th><th></th></tr>
	<tr><th>19</th><th>LeftUpLeg</th><th></th></tr>
	<tr><th>20</th><th>LeftLeg</th><th></th></tr>
	<tr><th>21</th><th>LeftFoot</th><th></th></tr>
	<tr><th>22</th><th>LeftToeBase</th><th></th></tr>
</table>
</div>

需要将模型的对应骨骼名称填写在xml文件的name栏中，即可对这段骨骼进行旋转控制。
## 2.3 非标准骨骼绑定
1. 如果模型的骨骼数目大于23段，比如背部骨骼有5段如何操作？<br>
需要将背部骨骼中的某两段合为一段控制，由于在Unity3D中旋转父骨骼会带动它所有的子节点旋转，所以只需要将父骨骼的名称填到xml文件中即可，最后要保证所有骨骼数目小于等于23段。
2. 如果模型的骨骼数目小于23段，比如背部骨骼只有2段如何操作？<br>
在这种情况下需要去掉xml文件中不需要的索引，但是必须要留下Hips或Spine节点，因为这个节点还控制整个模型的位置，如果去掉整个模型就不会运动。例如以下：

&lt;bone ConnectId = "0" name = "Hips"&gt;&lt;/bone&gt;

&lt;bone ConnectId = "3" name = "Spine1"&gt;&lt;/bone&gt;

在这里首先去掉了1 2 4这三段骨骼，因为模型中没有这三段骨骼，因此也就相当于用标准模型的T8~T11段骨骼运动代替了模型的Spine1段骨骼运动，当然也可以使用索引1或2（如果模型的Spine1段骨骼比较靠下接近胯部）或4（如果模型的Spine1段骨骼比较靠上接近颈部），需要根据实际情况而定。
# 三、插件使用流程
下面是使动捕数据流在Unity3D中驱动任意模型的具体步骤：
1. 新建一个Unity工程，或是使用你自己的工程。
2. 将FHMCScript文件夹拷贝到工程目录的Assets目录下，将DefaltActor.xml 拷贝到工程根目录下。
3. 创建一个任意一个2D或3D物体，命名为NetworkReceiver，设置scale为0.1，去掉Mesh Renderer使之基本不可见。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/addreceiver.png"/>
</div>

4. 将NetFrameDataReceiver.cs 拖放到NetworkReceiver上，在其Inspector中会显示下面属性：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/bindreceiver.png"/>
</div>

UDP Port的设定需要与MotionVenus中的设定相同，如果在MotionVenus中没有设置远程地址，可以在IP地址栏中输入远程地址的IP，在端口中输入远程地址的端口，然后点击添加按钮，这个地址就被添加到了发送列表。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/mvremoteipport.png"/>
</div>

Position、Euler、Quat的设定需要与MotionVenus中的转发规则设置中位移、欧拉角、四元数的选择保持一致，例如：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/mvtransrule.png"/>
</div>

5. 将Template文件夹中的FoActorRig.fbx拖放到场景中，并且添加FoheartModel.cs为Component，最终显示如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/bindmodel.png"/>
</div>

其中ActorName需要与MotionVenus中对应的人物套装编号一致，例如：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/actorname.png"/>
</div>

而ConfigName需要与工程根目录里的xml配置文件名称一致。<br>
然后选择NetworkReceiver，将ActorList中Size设为1，点击Element 0右侧选择按钮，在弹出的窗口中选择刚才设置好的FoActorRig。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/addtoactorlist.png"/>
</div>

设置完成之后如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/addactorlistsuccess.png"/>
</div>

如果在MotionVenus中连接有多套设备，在这里只需要将Size设为设备数目，然后依次选择设备需要绑定的Model，例如下面为添加了两个Model：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/multisuits.png"/>
</div>

6. 穿戴并完成校准动作，此时模型在MotionVenus中就可以正常的运动起来了。

# 四、模型绑定
由于在建模过程中使用的3D建模软件不同，或者在建模过程中没有使用软件推荐的骨骼系统，就会造成骨骼坐标系的不统一，这里的工作就是将任意旋转任意坐标系朝向的骨骼系统使用动捕数据流驱动。
## 4.1 默认数据流格式
MotionVenus使用下面格式的数据流输出人物的姿态位置信息：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/stream.png"/>
</div>

## 4.2 默认坐标系定义
在MotionVenus中的坐标系定义如下：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/defaultaxis.png"/>
</div>

即在T-Pose时所有骨骼的坐标轴定义都为左手边为x轴（红色轴），上方为z轴（蓝色轴），身体后方为y轴（绿色轴），数据流输出的是骨骼在世界坐标系（右手坐标系）中的旋转，骨骼位移也是在世界坐标系中的位移。
## 4.3 旋转转换

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/leftrighthand.png"/>
</div>

在Unity3D中的坐标系为左手坐标系，例如上图中的手，如果同样沿y轴旋转90度，则左侧手转向屏幕外，而右侧手转向屏幕里，其它两个轴也存在相同的问题，这样会造成同一段骨骼在MotionVenus中的旋转和U3D中的旋转现象不一致，在这里我们需要手动纠正这种不同坐标系造成的旋转错误。<br>
以左胳膊为例，选择显示左胳膊的Local坐标系。例如胳膊在U3D中沿+x轴旋转，在U3D中为+x，而在MotionVenus中要想达到同样效果也为+x（因为左右手旋转规则不同）；在U3D中沿+y轴旋转，在MotionVenus中要想达到同样效果为沿-y轴旋转；z轴的规则也相同。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/v1.2.8/help/img/axiscompare.png"/>
</div>

所以在FoheartModel.cs中applyBoneRotations函数中，对左胳膊的旋转设置为：

 if (BoneR.Key == 12) <br>
 {<br>
    Quaternion convQuatApply = new Quaternion (BV.x, -BV.y, -BV.z, BV.w);<br>
    BoneT.localRotation = convQuatApply;<br>
 }<br>

其它所有段骨骼的设置均遵守相同方法。
# 五、注意事项
插件使用时，需要注意以下地方：
1. 在模型绑定过程中，需要首先将模型调整到标准的T姿势，并且人物正面朝着Unity的Z轴正方向。
2. 使用Unity的过程中MotionVenus不可最小化。
