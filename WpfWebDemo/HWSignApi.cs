#region 版 本 注 释 
/*----------------------------------------------------------------
* class ：HWSignApi
* description ：
* namespace ：YKBLClient.SDK
* CLR version ：4.0.30319.42000
* author ：sez
* create time ：2019-08-09 13:14:38
* update time ：2019-08-09 13:14:38
*******************************************************************
* Copyright @ sez 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace YKBLClient.HanvonSdk
{
    internal class HWSignApi
    {
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern void GetErrorMessage(int errorCode, StringBuilder errorMsg);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int GetErrorMessage(int errorCode, ref IntPtr errorMsg);

       // [DllImport("GAJTSign_v1.0.0.7.dll")]
        //public static extern int GetDeviceInfo(ref DEVICE_INFO info);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int GetDeviceStatus();

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int SetSymmetricKey(ref byte pKeys, int nKeys);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int SetCmdToDevice(int flag);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int RegisterDeviceStatusCallBack(callBackDeviceStatusFunc func);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int UnregisterDeviceStatusCallBack(callBackDeviceStatusFunc func);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int RegisterTouchInfoCallBack(callBackTouchInfoFunc func);

        [DllImport("GAJTSign_v1.0.0.7.dll")]
        public static extern int UnregisterTouchInfoCallBack(callBackTouchInfoFunc func);

        [DllImport("user32.dll")]
        public static extern bool PtInRect([In] ref HWTabletRect lprc, Point pt);

        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);

        public static byte[] StructToBytes(object structure)
        {
            int num = Marshal.SizeOf(structure);
            Console.WriteLine(num);
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            byte[] result;
            try
            {
                Marshal.StructureToPtr(structure, intPtr, false);
                byte[] array = new byte[num];
                Marshal.Copy(intPtr, array, 0, num);
                result = array;
            }
            catch (Exception)
            {
                result = null;
            }
            finally
            {
                Marshal.FreeHGlobal(intPtr);
            }
            return result;
        }

        public static object BytesToStruct(byte[] bytes, Type strcutType)
        {
            int num = Marshal.SizeOf(strcutType);
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            object result;
            try
            {
                Marshal.Copy(bytes, 0, intPtr, num);
                result = Marshal.PtrToStructure(intPtr, strcutType);
            }
            catch (Exception)
            {
                result = null;
            }
            finally
            {
                Marshal.FreeHGlobal(intPtr);
            }
            return result;
        }

        public static string ShowErrorMessage(int errCode)
        {
            StringBuilder stringBuilder = new StringBuilder();
            HWSignApi.GetErrorMessage(errCode, stringBuilder);
            return stringBuilder.ToString();
        }
    }
}
