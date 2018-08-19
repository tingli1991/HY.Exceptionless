# Stack.Exceptionless  
基于Exceptionless日志收集系统的扩展

### 使用教程（该项目是基于.NET Core 项目）
## 1. 添加 appsettings.json 的配置文件
``` js
 "Exceptionless": {
    "ServerUrl": "http://192.168.3.18:81",
    "ApiKey": "T1uijEtbtbNcPs0aI1izX6cyscuZbowQKYmEbyUH"
  }
````
**ServerUrl：**表示Exceptionless的api地址  
**ApiKey：**是在Exceptionless后台项目管理里面生成的项目唯一标识（关于apiKey的生成這里不过多描述）
**注意：** appsettings.json 如果没有请记得在项目的更目录自行添加，并且要记得右键属性将其设置为始终复制（或者如果较新则复制）哦  

## 2. 使用示例  
完成appsettings.json配置后，我们就可以正常在代码里面使用啦  
#### 2.1 特性日志使用示例
``` C#

```
