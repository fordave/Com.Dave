#region 版 本 注 释 
/*----------------------------------------------------------------
* class ：TableFieldModel
* description ：
* namespace ：ModelCreator.ViewModels
* CLR version ：4.0.30319.42000
* author ：sez
* create time ：2019-07-31 10:54:26
* update time ：2019-07-31 10:54:26
*******************************************************************
* Copyright @ sez 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using ModelCreator.Commands;
using Newtonsoft.Json;

namespace ModelCreator.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase()
        {
        }
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class FieldItem : ViewModelBase
    {
        private bool selected;
        private string fieldName;
        private TypeItem company;

        public bool IsChecked
        {
            get => selected;
            set
            {
                selected = value;
                RaisePropertyChanged();
            }
        }
        public string FieldName
        {
            get => fieldName;
            set
            {
                fieldName = value;
                RaisePropertyChanged();
            }
        }
        public TypeItem Company
        {
            get => company;
            set
            {
                company = value;
                RaisePropertyChanged();
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                RaisePropertyChanged();
            }
        }

        public FieldItem()
        {
            CompanyList = new ObservableCollection<TypeItem>{
            new TypeItem { ID = 1, Name = "String" },
            new TypeItem { ID = 2, Name = "Number" },
            new TypeItem { ID = 3, Name = "Date" },
            new TypeItem { ID = 4, Name = "Buffer" },
            new TypeItem { ID = 5, Name = "Booolean" },
            new TypeItem { ID = 6, Name = "Mixed" },
            new TypeItem { ID = 7, Name = "ObjectId" },
            new TypeItem { ID = 8, Name = "Array" },
            new TypeItem { ID = 9, Name = "Decimal128" },
            new TypeItem { ID = 10, Name = "Map" },};
            Company = CompanyList.ToList()[0];
        }

        [JsonIgnore]
        public IEnumerable<TypeItem> CompanyList { get; set; }
    }

    public class TypeItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString() { return Name; }
    }

    public class ViewModel : ViewModelBase
    {
        private FieldItem selectedFieldItem;

        public FieldItem SelectedFieldItem
        {
            get => selectedFieldItem;
            set
            {
                selectedFieldItem = value;
                RaisePropertyChanged();
            }
        }


        private string tostring;

        public string Tostring
        {
            get { return tostring; }
            set
            {
                tostring = value;
                RaisePropertyChanged();
            }
        }

        private string tableName;

        public string TableName
        {
            get { return tableName; }
            set
            {
                if (!string.IsNullOrEmpty(tableName) && fieldItemsDic[tableName].Count != 0)
                {

                }
                tableName = value;

                RaisePropertyChanged();
            }
        }

        private readonly string directiory = @".\jsons\";

        public ViewModel()
        {
            Files = new ObservableCollection<string>();

            LoadFilesFromDisk();
            if (Files.Count > 0)
            {
                TableName = Files[0];
            }
            FieldItems = new ObservableCollection<FieldItem>();

            ClearFieldCommand = new DelegateCommand(_ =>
            {
                if (string.IsNullOrEmpty(TableName))
                {
                    return;
                }
                var result = MessageBox.Show("确定清空现有属性列表", "提示", MessageBoxButton.YesNo) == MessageBoxResult.No;
                if (result)
                {
                    return;
                }
                FieldItems.Clear();
                TableName = null;
                Tostring = null;
            });

            RemoveTableCommand = new DelegateCommand(_ =>
            {
                if (string.IsNullOrEmpty(TableName))
                {
                    return;
                }
                var result = MessageBox.Show("确定移除现有的模板", "提示", MessageBoxButton.YesNo) == MessageBoxResult.No;
                if (result)
                {
                    return;
                }
                var path = directiory + tableName + ".json";
                File.Delete(path);
                fieldItemsDic.Remove(TableName);
                Files.Remove(TableName);
                TableName = null;
            });

            DeleteCommand = new DelegateCommand(_ =>
            {
                if (SelectedFieldItem == null)
                {
                    return;
                }
                FieldItems.Remove(SelectedFieldItem);
                SelectedFieldItem = null;
            });

            SaveCommand = new DelegateCommand(_ =>
            {
                var result = MessageBox.Show("确定覆盖现有的模板", "提示", MessageBoxButton.YesNo) == MessageBoxResult.No;
                if (result)
                {
                    return;
                }
                using (var fs = new FileStream(directiory + tableName + ".json", FileMode.Create, FileAccess.Write))
                {
                    var temp = new List<FieldItem>();
                    FieldItems.ToList().ForEach(s =>
                    {
                        if (s.IsChecked)
                        {
                            temp.Add(s);
                        }
                    });
                    var jsonstring = JsonConvert.SerializeObject(temp);

                    var array = Encoding.UTF8.GetBytes(jsonstring);
                    fs.Write(array, 0, array.Length);
                    fs.Flush();
                    fs.Close();
                }
                LoadFilesFromDisk();
            });

            LoadCommand = new DelegateCommand(_ =>
            {
                if (string.IsNullOrEmpty(TableName))
                {
                    return;
                }
                FieldItems.Clear();
                var jsonstring = "";
                using (var fs = new FileStream(directiory +  tableName + ".json", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BufferedStream streamReader = new BufferedStream(fs);
                    var buffer = new byte[1024];
                    var bytes = new List<byte>();
                    while (streamReader.Read(buffer, 0, buffer.Length) > 0)
                    {
                        bytes.AddRange(buffer);
                        Array.Clear(buffer, 0, buffer.Length);
                    }
                    streamReader.Close();
                    fs.Close();
                    jsonstring = Encoding.UTF8.GetString(bytes.ToArray());
                }
                if (string.IsNullOrEmpty(jsonstring))
                {
                    return;
                }
                var fieldItems = JsonConvert.DeserializeObject<List<FieldItem>>(jsonstring);
                Debug.Assert(fieldItems != null, "null object");
                foreach (var item in fieldItems)
                {
                    item.IsChecked = true;
                    FieldItems.Add(item);
                }
            });

            ToStringCommand = new DelegateCommand(_ =>
            {
                Tostring = "";
                var stringBuilder = new StringBuilder();
                foreach (var item in FieldItems)
                {
                    stringBuilder.Append(item.FieldName + " : { type: " + item.Company + " , default :");
                    switch (item.Company.Name.ToLower())
                    {
                        case "string":
                            stringBuilder.Append("'',");
                            break;
                        case "number":
                            stringBuilder.Append("0,");
                            break;
                        case "date":
                            stringBuilder.Append("Date.now,");
                            break;
                        default:
                            break;
                    }
                    stringBuilder.Append("info :\"" + item.Description + "\"}," + Environment.NewLine);
                }
                Tostring = stringBuilder.ToString();
            });

        }

        private void Initial()
        {

        }




        private void LoadFilesFromDisk()
        {
            if (Directory.Exists(directiory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directiory);

                foreach (var item in directoryInfo.GetFiles())
                {
                    var fileName = item.Name.Split('.')[0];
                    if (!Files.Contains(fileName))
                    {
                        Files.Add(fileName);
                    }
                    if (!fieldItemsDic.ContainsKey(fileName))
                    {
                        fieldItemsDic.Add(fileName, new List<FieldItem>());
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(directiory);
            }
        }

        public ICommand SaveCommand { get; set; }

        public ICommand LoadCommand { get; set; }

        public ICommand ToStringCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public ICommand RemoveTableCommand { get; set; }

        public ICommand ClearFieldCommand { get; set; }

        private Dictionary<string, List<FieldItem>> fieldItemsDic = new Dictionary<string, List<FieldItem>>();


        public ObservableCollection<string> Files { get; set; }

        public ObservableCollection<FieldItem> FieldItems { get; set; }
    }
}
