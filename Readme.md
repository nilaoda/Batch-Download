# Batch Download 说明文档
***
#### 导语
> Batch Download 是一款为FFmpeg打造的，用于生成批处理文件的轻量级应用。
> 基本功能有 批量下载m3u8视频、批量转换视频封装格式、合并视频等。
> 反馈：<nilaoda@live.com>

#### 你需要准备的
>*  **FFmpeg.exe** : <https://ffmpeg.zeranoe.com/builds/win32/static/>
>* **.NET Framework 4.6** (*Included in Windows 10*) : [Download page for 4.6 offline installer](http://go.microsoft.com/fwlink/?LinkId=528233)

***

## 基本设置
点击**输出选项**

![点击输出选项](http://p1.bqimg.com/567571/4bdc39728e72efa4.png)

点击将下载好的FFmpeg.exe拖入界面，将会显示其路径，这时你就可以正常使用本软件了！
程序将在关闭时保存该路径。

![](http://i1.piimg.com/567571/d2f3b4b0ced7ce29.png)

进行一番设置后，点击**生成批处理文件**，程序将在桌面生成文件，你可以选择双击运行，或者直接在程序内运行。

## 解析 Ckplayer 的xml文档
*本功能可用于下载VIP接口解析出的视频,如 [Meiyouad.com](meiyouad.com)*

你可以拖入xml格式的文本文件或键入网址

>* 支持直接返回xml内容的网址
>* 支持xml内容
>* 支持识别Ckplayer文档中的m3u8链接

程序可以生成Media文件(包含基本信息及Urls)或m3u8文件。
*（您可以选择调用猎影视频下载软件进行后续操作而不是用FFmpeg进行下载）*

如果您下载的是分段视频，强烈建议您勾选**合并**选项，并选择“任务完成后”(默认)

![](http://p1.bqimg.com/567571/fbc2e8d3eafa4749.png)

## 批量下载HLS视频
您可以一行一个的键入HLS地址，点击**生成批处理**。
还可以再输出选项指定视频的输出目录。

## 批量转换视频封装格式
添加本地文件，或直接拖入文件，然后勾选**批量转码**，程序将输出至原视频目录

![](http://p1.bqimg.com/567571/bb840af709836172.png)

##### **当转码出现错误时，尝试将** `-bsf:a aac_adtstoasc` **命令删除后再试。**

## 合并视频分段
添加本地文件，或直接拖入文件，然后勾选合并，并选择**仅合并(本地文件)**

## 关于输出选项
![](http://p1.bqimg.com/567571/d6baf1aafe77949b.png)  

> *   **视频输出路径**：除批量转码外，其他操作默认的输出路径。
> *   **视频封装格式**：生成的视频的封装格式。
> *   **命名规则**：生成的视频的命名规则。

## 小技巧：如何调用IDM下载m3u8链接
第一步：在IDM的设置中，捕获浏览器加入Batch Download的可执行文件
第二步：在Batch Download中写入所需下载的m3u8链接，点击分析xml。
不出意外，IDM将会捕获该m3u8地址，点击下载即可。
接下来，享受IDM的快感吧~
