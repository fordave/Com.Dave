#region 版 本 注 释 
/*----------------------------------------------------------------
* class ：HWSignApi
* description ：
* nameace ：HWSignTest.SDK
* CLR version ：4.0.30319.42000
* author ：sez
* create time ：2019-08-14 08:52:32
* update time ：2019-08-14 08:52:32
*******************************************************************
* Copyright @ sez 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HWSignTest.SDK
{
    public enum DeviceStatus : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        OK,
        /// <summary>
        /// 设备没有正确连接到电脑
        /// </summary>
        NODEV,
        /// <summary>
        /// 设备ID错误
        /// </summary>
        ID_ERROR,
        /// <summary>
        /// 设备下发命令失败
        /// </summary>
        SENDCMD_FAIL,
        /// <summary>
        /// 打开设备失败
        /// </summary>
        FAILED_OPEN_DEVICE,
        /// <summary>
        /// 设备认证失败
        /// </summary>
        VERIFY_FAIL,
        /// <summary>
        /// 无效的参数
        /// </summary>
        INVALID_PARAMETER = 9,
    }

    public struct TOUCH_INFO
    {
        public int x;

        public int y;

        public int pressure;

        public int timestamp;

        public int pressstate;

        public int btnId;
    }

    public struct HWTabletRect
    {
        public int left;

        public int top;

        public int right;

        public int bottom;
    }
    public struct DEVICE_INFO
    {
        /// <summary>
        /// 厂商信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 56)]
        public string VendorName;

        /// <summary>
        /// 设备型号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]

        public string ProductName;
        /// <summary>
        /// dll版本
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]

        public string DllVersion;

        public HWTabletRect MonitorBounds;

        public int PressureLevel;

        public int DeviceType;

        public ushort vendorID;

        public ushort productID;

        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string serial;
    }
    public delegate void callBackDeviceStatusFunc(int status);
    public delegate int callBackTouchInfoFunc(TOUCH_INFO data);
    public class HWSignApi
    {

        [DllImport("HWTablet.dll")]
        public static extern int GetDeviceInfo(ref DEVICE_INFO info);

        [DllImport("HWTablet.dll")]
        public static extern int GetDeviceStatus();

        [DllImport("HWTablet.dll")]
        public static extern uint HWInit(IntPtr tt);

        [DllImport("HWTablet.dll")]
        public static extern int HWClose(IntPtr tt);

        [DllImport("HWTablet.dll")]
        public static extern int RegisterDevStatusCallBack(callBackDeviceStatusFunc func);

        [DllImport("HWTablet.dll")]
        public static extern int UnregisterDevStatusCallBack(callBackDeviceStatusFunc func);

        [DllImport("HWTablet.dll")]
        public static extern int RegisterTouchInfoCallBack(callBackTouchInfoFunc func);

        [DllImport("HWTablet.dll")]
        public static extern int UnregisterTouchInfoCallBack(callBackTouchInfoFunc func);

        [DllImport("HWTablet.dll")]
        public static extern int GetErrorMessage(int errorCode, StringBuilder msg);

    }
}
