# TencentYoutuyun-person-face-service

CSharp sdk for [腾讯优图开放平台](http://open.youtu.qq.com)

### 说明

- 本SDK由开发者：根（qq418871901）提供，后续将由开放平台和根共同维护，也欢迎大家提pull request

### 使用方法
从github下载dll文件，并添加到你项目引用里，本sdk依赖Newtonsoft.Json，也需一起引用

### 名词

- `AppId` 平台添加应用后分配的AppId
- `SecretId` 平台添加应用后分配的SecretId
- `SecretKey` 平台添加应用后分配的SecretKey
- `签名` 接口鉴权凭证，由`AppId`、`SecretId`、`SecretKey`等生成，详见<http://open.youtu.qq.com/#/develop/tool-authentication>

### 使用示例

```
// 设置为你自己的密钥对
string appid = "you appid";
string secretId = "you secretid";
string secretKey = "you secretkey";
string userid = "you qq";

//优图开放平台初始化
Conf.Instance().setAppInfo(appid, secretId, secretKey, userid, Conf.Instance().YOUTU_END_POINT);
//腾讯云初始化；2种初始化方式选择一种即可，优图是免费提供给大家使用的
Conf.Instance().setAppInfo(appid, secretId, secretKey, userid, Conf.Instance().TENCENTYUN_END_POINT);


string path = System.IO.Directory.GetCurrentDirectory();
string result = string.Empty;
// 人脸检测调用demo
result = Youtu.detectface(path + "\\test.jpg");
Console.WriteLine(result);
Console.ReadKey();
```
