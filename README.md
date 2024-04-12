## 简介

根据 `proto` 协议文件生成CS 类文件。 不支持各种嵌套骚操作
该库主要服务于 `https://github.com/AlianBlank/GameFrameX` 作为子库使用。

# 使用方式(三种方式)

1. 直接在 `manifest.json` 文件中添加以下内容
   ```json
      {"com.alianblank.gameframex.unity.protobuff2cs": "https://github.com/AlianBlank/com.alianblank.gameframex.unity.protobuff2cs.git"}
    ```

2. 在Unity 的`Packages Manager` 中使用`Git URL` 的方式添加库,地址为：https://github.com/AlianBlank/com.alianblank.gameframex.unity.protobuff2cs.git

3. 直接下载仓库放置到Unity 项目的`Packages` 目录下。会自动加载识别

## 使用说明

### 常规内容

以下为测试协议和注释,以 `#` 开始为说明。

```protobuf
syntax = "proto3";
package common;

// 返回码  # 这行是对消息体的注释。会生成类的注释
enum ResultCode {
  Success = 0; //成功 # 这个是字段的注释。会生成对应的字段注释
  Failed = 1; //失败 # 这个是字段的注释。会生成对应的字段注释
}

// 玩家基础信息
message UserInfo {
  string RoleName = 1; // 角色名
  int64 RoleId = 2; // 角色ID
  int32 Level = 3; // 角色等级
  int64 CreateTime = 4; // 创建时间
  int32 VipLevel = 5; // vip等级
}
```

### 请求和消息响应

以下为测试协议和注释,以 `#` 开始为说明。

```protobuf
// 出售道具 # 这行是对消息体的注释。会生成类的注释
message ReqSellItem {// IRequestMessage 103  # 这个按// 切分，前面为消息父类, 后面为消息码，自己掌握消息码分类
  int32 ItemId = 1; // 道具id # 这个是字段的注释。会生成对应的字段注释
}

// 出售道具 # 这行是对消息体的注释。会生成类的注释
message ResItemChange {// IResponseMessage 103 # 这个按// 切分，前面为消息父类, 后面为消息码，自己掌握消息码分类
  map<int32, int32> ItemDic = 1; // 变化的道具 # 这个是字段的注释。会生成对应的字段注释
}
```

`IRequestMessage` 为从客户端向服务器发 也成为`CS` 或`C2S`

`IResponseMessage` 为从服务器向客户端发 也成为`SC` 或`S2C`

#### *特别说明*

上面消息码一致。表示`请求`和`返回`是`成对`出现。

有时候可能会出现以下情况：

- 只有发送：正常发送
- 一个发送多个返回：正常接收
- 服务器推送：正常接收

## 运行说明

方式1. Unity菜单 `Tools/Proto2CS` 点击执行

方式2. 快捷键 `Alt + C` 执行

# 版权声明

1. 主体代码逻辑来自于 `ET` 修改而来(版权归属为ET)
2. MessagePack 部分由 `GameFrameX` 支持(版权归属为`GameFrameX`、AlianBlank(Blank))

# Licenses

```
MIT License

Copyright (c) 2023 AlianBlank(Blank)

https://github.com/AlianBlank

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
