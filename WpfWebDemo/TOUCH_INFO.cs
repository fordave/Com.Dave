#region 版 本 注 释 
/*----------------------------------------------------------------
* class ：TOUCH_INFO
* description ：
* namespace ：YKBLClient.HanvonSdk
* CLR version ：4.0.30319.42000
* author ：sez
* create time ：2019-08-13 16:29:39
* update time ：2019-08-13 16:29:39
*******************************************************************
* Copyright @ sez 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKBLClient.HanvonSdk
{
    public struct TOUCH_INFO
    {
        public int btnId;

        public int x;

        public int y;

        public int pressure;
    }
}
