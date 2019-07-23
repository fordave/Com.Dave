using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ValidationRuleDemo.ViewModels
{
    public class MainWindowViewModel :ViewModelBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {               
                RaisePropertyChanged(ref name,value);
            }
        }

    }
}
