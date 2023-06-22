# WhatOffice

一款自动识别 Office 文档文件来源并使用对应程序将其打开的小工具。

## 适用场景

本程序的设计初衷是为了解决班级白板上课件的兼容性问题，除此之外我实在想不到其他适用的情况了\_(:з」∠)\_

## 使用方法

0. 使用前请先下载并安装[.NET 6.0 桌面运行时 (x86)](https://dotnet.microsoft.com/zh-cn/download/dotnet/6.0)环境！
1. 从 Release 界面下载最新版本的 zip 压缩包;
2. 将文件解压到磁盘内即可完成安装。
3. 直接运行 `WhatOffice.exe` 会打开设置界面，初次运行建议将所有 Office 程序的对应路径都填好。直接关闭设置界面即可保存设置。
4. 将所有 Office 文档（`.docx`,`.pptx`,`.xlsx`,`.doc`,`.ppt`,`.xls`）的打开方式都修改为 `WhatOffice` 即可完成配置。

## 支持的 Office 程序

- [x] Mircosoft Office 全系
- [x] [WPS Office](https://platform.wps.cn/)
- [x] [LibreOffice](https://zh-cn.libreoffice.org/)

## 注意事项

- 只有您的电脑上安装多款 Office 程序，本工具才有使用意义。本工具仅仅实现了文档识别和调用程序的功能，并不能通过修改文档的方式解决兼容性问题！
- 由于 Windows 对于文件打开方式的处理，所有的 Office 文档图标都会变成 WhatOffice 的图标。如果需要将文档图标还原，推荐使用 [FileTypesMan](https://www.nirsoft.net/utils/file_types_manager.html)。
- 如果您确定已经安装了 `.NET 6.0 桌面运行时` 但仍然无法运行本程序，请使用 `x86` （兼容 32 位）架构的运行时版本*而不是* `x64` 版本（仅适用于 64 位）。
- 如果您的操作系统为 Windows 7 且碰到了无法运行本程序的问题，请尝试为系统安装所有可用的更新补丁。

## 帮助本程序变得更好

如果您在使用过程中遇到 BUG 等意外问题，请转到 Issue 界面发送反馈（需要注册 GitHub 账号）。

如果你懂开发并且想帮助实现新功能，欢迎 Fork 并提交 PR。

## ~~一般人懒得看的~~法律声明

本程序使用 [MIT 协议](https://mit-license.org/)向用户授权，开源免费。

我们尊重您的隐私安全。本程序不需要联网工作，不会在电脑后台保持运行，不收集任何用户信息。日志文件仅记录错误信息，不会保存任何用户使用过的文档或使用记录。
