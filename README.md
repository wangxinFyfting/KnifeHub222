
<h1 align="center">QQBotHub</h1>

> QQ 机器人 | 基于 Konata.Core | 一键免费部署

[![repo size](https://img.shields.io/github/repo-size/yiyungent/QQBotHub.svg?style=flat)]()
[![LICENSE](https://img.shields.io/github/license/yiyungent/QQBotHub.svg?style=flat)](https://github.com/yiyungent/QQBotHub/blob/master/LICENSE)
[![QQ Group](https://img.shields.io/badge/QQ%20Group-894031109-deepgreen)](https://jq.qq.com/?_wv=1027&k=q5R82fYN)
![hits](https://api-onetree.moeci.com/hits.svg?id=QQBotHub)

## Introduce

QQ 机器人 | 基于 Konata.Core | 一键免费部署

- **Web 可视化** 无需再在 Console 上操作
- **插件化架构** 轻松使用插件扩展

> **注意** : 本项目仅供学习使用, 所有第三方插件与本项目无关

## 功能

- [x] 在线登录
- [x] 其它大部分功能由 插件提供

## Quick Start

### 部署

#### 方式1: 使用 Railway 免费 一键部署 

> 点击下方按钮 一键部署

[![Deploy on Railway](https://railway.app/button.svg)](https://railway.app/new/template/A3JY-J?referralCode=8eKBDA)


##### Railway 环境变量

| 环境变量名称                | 必填 | 备注                    |
| --------------------------- | ---- | ----------------------- |
| `PLUGINCORE_ADMIN_USERNAME` | √    | PluginCore Admin 用户名 |
| `PLUGINCORE_ADMIN_PASSWORD` | √    | PluginCore Admin 密码   |
| `BOT_QQ` | √    | 机器人 QQ   |
| `BOT_PASSWORD` | √    | 机器人 QQ 密码   |


> 注意:    
> - Railway 修改环境变量 会 触发 重新 Deploy   
> - Railway 重新 Deploy 后会删除数据, 你安装的所有插件及数据都将清空。


> 部署完成后
> > 一定要先登录 `PluginCore Admin`   
> 1. 访问: <https://your-domain/PluginCore/Admin>  进入 `PluginCore Admin`
> 2. 访问: <https://your-domain/login> 进行 QQ机器人 登录


#### 方式2: 使用 Docker

```bash
docker run -d -p 5004:80 -e ASPNETCORE_URLS="http://*:80" --name qqbothub yiyungent/qqbothub
```

> 现在访问: <http://localhost:5004/PluginCore/Admin>



### QQ 登录

> 若为 `短信验证` , 则直接输入收到的验证码, 点击 `提交验证` 即可

> 若为 `滑动验证` , 则 `点击前往验证`, 浏览器在 `滑动验证` 页面 `F12`, 再选择 `Network`, 通过滑动验证后, 复制 `ticket` 如下 (不要包括双引号), 将 `ticket` 粘贴到输入框, 点击 `提交验证` 即可

![login_slide.png](./screenshots/login_slide.png)

> 注意验证不要等待太久, 否则尝试刷新登录页面 以重新登录及获取新验证



### 插件

> 插件:   
> 下载插件包, 
> > 插件包下载见 [Release](https://github.com/yiyungent/QQBotHub/releases) , 
> > 直接插件上传 下载的 `QQHelloWorldPlugin-net6.0.zip` 即可    
> 
> 然后直接 `上传 -> 安装 -> 文档 -> 设置 -> 启用 -> 文档` 即可


## Screenshots




## 相关项目


- [KonataDev/Konata.Core](https://github.com/KonataDev/Konata.Core)
- [yiyungent/PluginCore](https://github.com/yiyungent/PluginCore)


## Donate

QQBotHub is an GPL-3.0 licensed open source project and completely free to use. However, the amount of effort needed to maintain and develop new features for the project is not sustainable without proper financial backing.

We accept donations through these channels:

- <a href="https://afdian.net/@yiyun" target="_blank">爱发电</a> (￥5.00 起)
- <a href="https://dun.mianbaoduo.com/@yiyun" target="_blank">面包多</a> (￥1.00 起)

## Author

**QQBotHub** © [yiyun](https://github.com/yiyungent), Released under the [GPL-3.0](./LICENSE) License.<br>
Authored and maintained by yiyun with help from contributors ([list](https://github.com/yiyungent/QQBotHub/contributors)).

> GitHub [@yiyungent](https://github.com/yiyungent) Gitee [@yiyungent](https://gitee.com/yiyungent)

