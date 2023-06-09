﻿namespace BiliLite.Models.Common
{
    public enum LogType
    {
        INFO,
        DEBUG,
        ERROR,
        FATAL
    }

    public enum LoginStatus
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        Success,
        /// <summary>
        /// 登录失败
        /// </summary>
        Fail,
        /// <summary>
        /// 登录错误
        /// </summary>
        Error,
        /// <summary>
        /// 登录需要验证码
        /// </summary>
        NeedCaptcha,
        /// <summary>
        /// 需要安全认证
        /// </summary>
        NeedValidate
    }

    public enum LoginQRStatusCode
    {
        /// <summary>
        /// 扫码成功
        /// </summary>
        Success = 0,

        /// <summary>
        /// 二维码失效
        /// </summary>
        Fail = 86038,

        /// <summary>
        /// 二维码已扫码未确认
        /// </summary>
        Unconfirmed = 86090,

        /// <summary>
        /// 未扫码
        /// </summary>
        NotScanned = 86101,
    }

    public enum MouseMiddleActions
    {
        /// <summary>
        /// 返回或关闭页面
        /// </summary>
        Back=0,

        /// <summary>
        /// 打开新标签页但不跳转 
        /// </summary>
        NewTap=1,

        /// <summary>
        /// 无操作
        /// </summary>
        None=2,
    }

    public enum DownloadType
    {
        /// <summary>
        /// 视频
        /// </summary>
        Video = 0,
        /// <summary>
        /// 番剧、电影、电视剧等
        /// </summary>
        Season = 1,
        /// <summary>
        /// 音乐，暂不支持
        /// </summary>
        Music = 2,
        /// <summary>
        /// 课程，暂不支持
        /// </summary>
        Cheese = 3
    }
}