using System.Collections.Generic; 
using System.ComponentModel; 
using Exiled.API.Interfaces;

/// <summary>
/// QQ远程ban人系统，利用OneBot和WebSockets以exiled插件形式运行在sl服务器上
/// 作者：Nacho_Neko
/// </summary>
namespace OneBotIntegration
{
    public class Config : IConfig
    {
        // 使用 Description 特性为属性添加描述信息
        // IsEnabled 属性表示插件是否启用，默认值为 true
        [Description("是否启用插件")]
        public bool IsEnabled { get; set; } = true;

        // Debug 属性表示是否启用调试模式
        [Description("是否启用调试")]
        public bool Debug { get; set; }

        // AllowedQQs 属性是一个字符串列表，用于存储允许的 QQ 号
        [Description("允许的 QQ 号列表")]
        public List<string> AllowedQQs { get; set; } = new List<string>();

        // OneBotWsUrl 属性表示 OneBot WebSocket 的 URL，默认值为 "ws://127.0.0.1:6700"
        [Description("OneBot WebSocket URL")]
        public string OneBotWsUrl { get; set; } = "ws://127.0.0.1:6700";

        // GroupId 属性表示群号，默认值为 "123456789"
        [Description("群号")]
        public string GroupId { get; set; } = "123456789";
    }
}