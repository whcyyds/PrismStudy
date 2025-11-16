using PrismBaseObj.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrismBaseObj.ViewModels
{
    public class CheckWinViewModel : BindableBase
    {

        private string _data;
        public string Data 
        {   get { return _data; }
            set { SetProperty(ref _data, value); ExeCmm.RaiseCanExecuteChanged(); }
        }
        public DelegateCommand ExeCmm { get; set; }
        public CheckWinViewModel()
        {
            ExeCmm = new DelegateCommand(Exe, CanExe);
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool CanExe()
        {
            return !string.IsNullOrEmpty(Data);
        }




        /// <summary>
        /// 执行业务
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void ExeBusin()
        {
            MessageBox.Show("Execute ExeBusin");
        }

        private void Exe()
        {
            MessageBox.Show("Execute Successfully");
        }
    }
}
