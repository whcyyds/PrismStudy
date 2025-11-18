using PrismDialog.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrismDialog.ViewModels
{
    public class DialogUC2ViewModel:IDialogAware
    {
        public string Title => "窗口2";
        public DialogCloseListener RequestClose { get; set; }
        public DelegateCommand SubCmm { get; set; }

        public DialogUC2ViewModel(IEventAggregator eventAggregator)
        {
            SubCmm = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<MsgEventPara>().Subscribe(ExeSubBusin);
            });
            UnSubCmm = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<MsgEventPara>().Unsubscribe(ExeSubBusin);
            });
        }
        /// <summary>
        /// 收到订阅消息后处理的业务
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void ExeSubBusin(string obj)
        {
            MessageBox.Show($"窗口2收到了{obj}");
        }

        public DelegateCommand UnSubCmm { get; set; }

       

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
