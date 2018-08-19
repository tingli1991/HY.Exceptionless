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
string tagName = "特性使用标签";//自定义标签
var data = new ExcDataParam() { Name = "请求参数", Data = new { Id = 001, Name = "张三" } };//自定义单个model
var user = new ExcUserParam() { Id = "No0001", Name = "李廷礼", Email = "litingxian@live.cn", Description = "菁鲤汇高级开发工程师" };//用户信息
var datas = new List<ExcDataParam>()//自定义列表数据
{
    new ExcDataParam(){
        Name="请求参数",
        Data=new { Id = 002, Name = "李四" }
    },
    new ExcDataParam(){
        Name="返回结果",
        Data=new { Id = 003, Name = "王五" }
    }
};

FeatureUsageLess.Submit("不带参数");
FeatureUsageLess.Submit("带标签", tagName);
FeatureUsageLess.Submit("带用户&标签", user, tagName);
FeatureUsageLess.Submit("带自定义数据&标签", data, tagName);
FeatureUsageLess.Submit("带自定义数据&标签", datas, tagName);
FeatureUsageLess.Submit("带用户&自定义数据&标签", user, data, tagName);
FeatureUsageLess.Submit("带用户&自定义数据&标签", user, datas, tagName);
```
#### 2.2 失效链接日志使用示例
``` C#
string tagName = "失效链接标签";//自定义标签
var data = new ExcDataParam() { Name = "请求参数", Data = new { Id = 001, Name = "张三" } };//自定义单个model
var user = new ExcUserParam() { Id = "No0001", Name = "李廷礼", Email = "litingxian@live.cn", Description = "菁鲤汇高级开发工程师" };//用户信息
var datas = new List<ExcDataParam>()//自定义列表数据
{
    new ExcDataParam(){
        Name="请求参数",
        Data=new { Id = 002, Name = "李四" }
    },
    new ExcDataParam(){
        Name="返回结果",
        Data=new { Id = 003, Name = "王五" }
    }
};
BrokenLinksLess.Submit("不带参数：http://www.baidu.com");
BrokenLinksLess.Submit("带标签：http://www.baidu.com", tagName);
BrokenLinksLess.Submit("带用户&标签：http://www.baidu.com", user, tagName);
BrokenLinksLess.Submit("带自定义数据&标签：http://www.baidu.com", data, tagName);
BrokenLinksLess.Submit("带自定义数据&标签：http://www.baidu.com", datas, tagName);
BrokenLinksLess.Submit("带用户&自定义数据&标签：http://www.baidu.com", user, data, tagName);
BrokenLinksLess.Submit("带用户&自定义数据&标签：http://www.baidu.com", user, datas, tagName);
```
#### 2.3 消息日志使用示例
``` C#
string tagName = "消息标签";//自定义标签
var data = new ExcDataParam() { Name = "请求参数", Data = new { Id = 001, Name = "张三" } };//自定义单个model
var user = new ExcUserParam() { Id = "No0001", Name = "李廷礼", Email = "litingxian@live.cn", Description = "菁鲤汇高级开发工程师" };//用户信息
var datas = new List<ExcDataParam>()//自定义列表数据
{
    new ExcDataParam(){
        Name="请求参数",
        Data=new { Id = 002, Name = "李四" }
    },
    new ExcDataParam(){
        Name="返回结果",
        Data=new { Id = 003, Name = "王五" }
    }
};

//日志等级：跟踪信息
LogMessagesLess.Trace("不带参数");
LogMessagesLess.Trace("带标签", tagName);
LogMessagesLess.Trace("带用户&标签", user, tagName);
LogMessagesLess.Trace("带自定义数据&标签", data, tagName);
LogMessagesLess.Trace("带自定义数据&标签", datas, tagName);
LogMessagesLess.Trace("带用户&自定义数据&标签", user, data, tagName);
LogMessagesLess.Trace("带用户&自定义数据&标签", user, datas, tagName);

//日志等级：调试信息
LogMessagesLess.Debug("不带参数");
LogMessagesLess.Debug("带标签", tagName);
LogMessagesLess.Debug("带用户&标签", user, tagName);
LogMessagesLess.Debug("带自定义数据&标签", data, tagName);
LogMessagesLess.Debug("带自定义数据&标签", datas, tagName);
LogMessagesLess.Debug("带用户&自定义数据&标签", user, data, tagName);
LogMessagesLess.Debug("带用户&自定义数据&标签", user, datas, tagName);

//日志等级：普通信息
LogMessagesLess.Info("不带参数");
LogMessagesLess.Info("带标签", tagName);
LogMessagesLess.Info("带用户&标签", user, tagName);
LogMessagesLess.Info("带自定义数据&标签", data, tagName);
LogMessagesLess.Info("带自定义数据&标签", datas, tagName);
LogMessagesLess.Info("带用户&自定义数据&标签", user, data, tagName);
LogMessagesLess.Info("带用户&自定义数据&标签", user, datas, tagName);

//日志等级：警告
LogMessagesLess.Warn("不带参数");
LogMessagesLess.Warn("带标签", tagName);
LogMessagesLess.Warn("带用户&标签", user, tagName);
LogMessagesLess.Warn("带自定义数据&标签", data, tagName);
LogMessagesLess.Warn("带自定义数据&标签", datas, tagName);
LogMessagesLess.Warn("带用户&自定义数据&标签", user, data, tagName);
LogMessagesLess.Warn("带用户&自定义数据&标签", user, datas, tagName);

//日志等级：致命的
LogMessagesLess.Fatal("不带参数");
LogMessagesLess.Fatal("带标签", tagName);
LogMessagesLess.Fatal("带用户&标签", user, tagName);
LogMessagesLess.Fatal("带自定义数据&标签", data, tagName);
LogMessagesLess.Fatal("带自定义数据&标签", datas, tagName);
LogMessagesLess.Fatal("带用户&自定义数据&标签", user, data, tagName);
LogMessagesLess.Fatal("带用户&自定义数据&标签", user, datas, tagName);

//日志等级：异常
LogMessagesLess.Error("不带参数");
LogMessagesLess.Error("带标签", tagName);
LogMessagesLess.Error("带用户&标签", user, tagName);
LogMessagesLess.Error("带自定义数据&标签", data, tagName);
LogMessagesLess.Error("带自定义数据&标签", datas, tagName);
LogMessagesLess.Error("带用户&自定义数据&标签", user, data, tagName);
LogMessagesLess.Error("带用户&自定义数据&标签", user, datas, tagName);
```
#### 2.4 异常日志使用示例
``` C#
string tagName = "异常标签";//自定义标签
var data = new ExcDataParam() { Name = "请求参数", Data = new { Id = 001, Name = "张三" } };//自定义单个model
var user = new ExcUserParam() { Id = "No0001", Name = "李廷礼", Email = "litingxian@live.cn", Description = "菁鲤汇高级开发工程师" };//用户信息
var datas = new List<ExcDataParam>()//自定义列表数据
{
    new ExcDataParam(){
        Name="请求参数",
        Data=new { Id = 002, Name = "李四" }
    },
    new ExcDataParam(){
        Name="返回结果",
        Data=new { Id = 003, Name = "王五" }
    }
};
try
{
    ExceptionsLess.Submit("不带参数");
    ExceptionsLess.Submit("带标签", tagName);
    ExceptionsLess.Submit("带用户&标签", user, tagName);
    ExceptionsLess.Submit("带自定义数据&标签", data, tagName);
    ExceptionsLess.Submit("带自定义数据&标签", datas, tagName);
    ExceptionsLess.Submit("带用户&自定义数据&标签", user, data, tagName);
    ExceptionsLess.Submit("带用户&自定义数据&标签", user, datas, tagName);

    //程序逻辑异常测试，用过try catch 捕获
    int number = 0;
    int nubemr1 = 1 / number;
}
catch (Exception ex)
{
    //注意：同一个异常ExceptionsLess只会提交一次，這就说明第二次提交则会无效
    //ex.Submit();//不带任何参数
    //ex.Submit(tagName);//带标签
    //ex.Submit(user, tagName);//带用户&标签
    //ex.Submit(data, tagName);//带自定义数据&标签
    //ex.Submit(datas, tagName);//带自定义数据&标签
    //ex.Submit(user, data, tagName);//带用户&自定义数据&标签
    ex.Submit(user, datas, tagName);//带用户&自定义数据&标签
}
```
#### 2.5. ASP.NET Core 里面的全局异常处理 
GlobalExceptionFilter：该类则是本人在**Stack.Exceptionless项目当中扩展出来的全局异常过滤器**，它所属的命名空间为：**Stack.Exceptionless.Filters**，我么如果要使用它，除了需要配置appsettings.json文件以外，我们还需要在Startup的ConfigureServices里面加入一段配置，具体配置按照下面的代码配置即可：  
``` C#
/// <summary>
/// 
/// </summary>
/// <param name="services"></param>
public void ConfigureServices(IServiceCollection services)
{
     services.AddMvc(options =>
     {
          //添加全局异常捕获
          options.Filters.Add<GlobalExceptionFilter>();
     });
}
```
