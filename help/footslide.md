# 绑定后的模型滑步/浮空或者脚部在地面下等问题如何解决？
## 一、问题分析
在MotionVenus中，按照严格流程，需要详细准确测量人体每段骨骼的长度，填入【骨骼】参数后，再进行动作捕捉。然而为了方便，大部分情况下我们只选用内置模版，但是即使选择了与自身不完全匹配的尺寸模版，MotionVenus也能通过算法计算出没有漂移和滑步的位置信息。<br>
但是由于在Unity3D中的绑定模型尺寸、比例与MotionVenus中输出位移数据的模型不一致，所以会导致腰部位移一致，但是脚部悬空或者伸入地面以下的情况，这种情况是正常的，我们需要采取措施进行修复即可。<br>
例如，在unity3D中绑定了一个腿部长度只有半米的矮人模型，当运行时，由于正常的腰部位置在0.95m，所以此矮人模型的脚部会腾空。
## 二、确定骨骼长度
1. 实时模式
在实时模式下，通过人物栏->骨骼窗口，设置或者查看当前使用的骨骼长度，设置方法请参考[【身体参数设置】](https://github.com/FOHEART/MotionVenusHelp/blob/v1.4.0/software/bodyparam.md)。
2. 回放模式
在已经录制完成的文件上使用右键->属性打开属性窗口，如下所示：

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/footslide/prop.png"/>
</div>

右侧骨骼信息即为录制文件时使用的骨骼长度信息。

## 三、确定根骨骼位置
首先应该确定在MotionVenus中Hips，也就是根骨骼的起始高度，即：**胯高**，在此设为**H1**。
若在Unity3D中绑定的模型，胯高若小于H1，则模型运动过程中脚部会腾空，若胯高大于H1则脚部会踩到地面以下。

## 四、设置跨高偏移
选中绑定的模型，在右侧设置Location Offset XYZ：
确定模型在T-Pose下的胯高H2，将Offset Y设置为H2-H1。


<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/footslide/locationoffset.png"/>
</div>

## 五、设置XY轴倍率值
选中绑定的模型，在右侧设置Location Scale XYZ：
在设置完成胯高之后，若H2小于H1，则模型运动时，会出现走路过快的情形，若H2大于H1则会出现模型运动过慢的情形，这时需要缩放XY轴运动的倍率为H2/H1。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/footslide/locationscale.png"/>
</div>

## 六、细节调整
由于建模过程中造成的胯高并不是真正的位于实际胯高，或者由于蒙皮导致的胯高实际位置不一致，还需要按照实际情况调整Location Offset XYZ与Location Scale XYZ的值。