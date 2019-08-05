#region 版 本 注 释 
/*----------------------------------------------------------------
* class ：DelegateCommand
* description ：
* namespace ：ModelCreator.Commands
* CLR version ：4.0.30319.42000
* author ：sez
* create time ：2019-07-31 14:20:01
* update time ：2019-07-31 14:20:01
*******************************************************************
* Copyright @ sez 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModelCreator.Commands
{
    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action<object> action = null, Func<object, bool> func = null)
        {
            ExecuteAction = action;
            CanExecuteFunc = func;
        }
        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc == null)
            {
                return true;
            }

            return this.CanExecuteFunc(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (this.ExecuteAction == null)
            {
                return;
            }
            this.ExecuteAction(parameter);
        }

        private Action<object> ExecuteAction { get; set; }
        private Func<object, bool> CanExecuteFunc { get; set; }
    }
}
