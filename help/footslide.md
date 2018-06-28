# 绑定后的模型滑步/浮空或者脚部在地面下等问题如何解决？
## 一、问题分析
在MotionVenus中，按照严格流程，需要详细准确测量人体每段骨骼的长度，填入【骨骼】参数后，再进行动作捕捉。然而为了方便，大部分情况下我们只选用内置模版，但是即使选择了与自身不完全匹配的尺寸模版，MotionVenus也能通过算法计算出没有漂移和滑步的位置信息。<br>
但是由于在Unity3D中的绑定模型尺寸、比例与MotionVenus中输出位移数据的模型不一致，所以会导致腰部位移一致，但是脚部悬空或者伸入地面以下的情况，这种情况是正常的，我们需要采取措施进行修复即可。<br>
例如，在unity3D中绑定了一个身高只有半米的矮人模型，当运行时，由于正常的腰部位置在0.95m，所以此矮人模型的脚部会腾空。
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
若在Unity3D中绑定的模型，胯高若小于H1（胯部到脚跟的距离，不包括鞋底厚度），则模型运动过程中脚部会腾空，若胯高大于H1则脚部会踩到地面以下。

## 四、设置胯高偏移
假设需要模型在距离地面某个高度，或在地面下某个高度，或任意一个区域。需要将模型整体平移一个位移，这个位移在Location Offset XYZ中设置。<br>
选中绑定的模型，在右侧设置Location Offset XYZ：确定模型的偏移量，填入XYZ中即可。


<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/footslide/locationoffset.png"/>
</div>

## 五、设置XYZ轴倍率值
选中绑定的模型，在右侧设置Location Scale XYZ：
在设置完成胯高之后，只是确定了模型的**整体**空间位置，但是若H2小于H1（腿短），则模型运动时，会出现走路过快的情形，若H2大于H1则会出现模型运动过慢的情形，这时需要缩放XYZ轴运动的倍率为H2/H1。

<div align=center>
<img src="https://raw.githubusercontent.com/FOHEART/FOHEART_Unity3D_Plugin/master/help/footslide/locationscale.png"/>
</div>

例如：Unity3D模型的胯高为43cm，在MotionVenus中使用男175cm模版胯高91.58cm，则倍率为43/91.58=0.4695，将0.4695填入Location Scale XYZ中即可。
## 六、细节调整
1. 执行完第5步之后，若脚部仍有下限或者腾空情况发生，原因是未考虑模型鞋底的厚度，将模型鞋底厚度填入Location Offset XYZ中的Y中即可。例如模型鞋底高度为3cm，则将Location Offset XYZ设置为（0,0.03,0）。
2. 由于建模过程中造成的胯高并不是真正位于胯部的胯高，或者由于蒙皮权重导致的胯高实际位置不一致，还需要按照实际情况调整Location Offset XYZ与Location Scale XYZ的值，直到做到使模型无滑步腾空。

## 七、仅适用于相近比例骨骼模型
以上所说方法仅适用于U3D中模型腿部大腿/小腿/脚长比例与MotionVenus中使用模版比例相同，或接近相同的情况。<br>
大部分类人模型或正常人体模型大腿：小腿：脚长基本符合1:0.7~0.8:0.4~0.5，若模型符合此比例那么绑定效果可以达到理想效果。<br>
例如，MotionVenus中[男175cm模版](https://github.com/FOHEART/MotionVenusHelp/blob/v1.4.0/software/bodyparam.md)，其中大腿长44.34cm、小腿长36.74cm、脚长24.99cm，比例为1：0.83：0.56，那么Unity3D中的模型下半身也要与此比例相符或者接近，经过第五节的步骤之后，脚部可以做到紧贴地面无滑步、陷地、腾空。

## 八、非正常比例骨骼模型如何处理？
若在Unity3D中使用的模型已经制作完成不便更改，或者骨骼比例需要以一种夸张的比例设置，那么必须在动捕开始之前就在MotionVenus中提前设置夸张的长度或者比例，具体方法可以按照以下方式实现：<br>
在MotionVenus中[身体参数设置](https://github.com/FOHEART/MotionVenusHelp/blob/v1.4.0/software/bodyparam.md)窗体中，详细设置大腿、小腿、脚长的数值，使之与Unity3D中需要绑定的模型保持长度一致，或者比例一致，然后穿戴动捕进行表演实时捕捉、或捕捉完成后回放数据。