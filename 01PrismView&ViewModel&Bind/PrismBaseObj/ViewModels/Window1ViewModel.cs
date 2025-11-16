using PrismBaseObj.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrismBaseObj.ViewModels
{
    public class Window1ViewModel:BindableBase
    {
        private string _Title="龙马精神";

        public string Title
        {
            get { return _Title; }
            set {
                //第一种
                //_Title = value;
                //RaisePropertyChanged();

                //第二种
                SetProperty(ref _Title, value);
            }
        }

        #region UserInfo
        private UserInfo _UserInfo;
        public UserInfo UserInfo
        {
            get { return _UserInfo; }
            set { _UserInfo = value;RaisePropertyChanged(); }
        }
        #endregion

        //public DelegateCommand EditCmm=new DelegateCommand(()=> 
        //{
        //Title = "标题被修改了";
        //});

        public DelegateCommand<UserInfo> EditCmm { get; set; }

        public Window1ViewModel()
        {
            UserInfo = new UserInfo();
            EditCmm = new DelegateCommand<UserInfo>((UserInfo userinfo) =>
            {
                 MessageBox.Show($"用户信息：身份证号：{userinfo.IdCard}，用户名：{userinfo.UserName}");
            });
        }
    }
}
