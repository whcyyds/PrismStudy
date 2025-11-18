using Prism.Dialogs;
using PrismDialog.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrismDialog.ViewModels
{
    public class MainWinViewModel
    {
        public DelegateCommand OpenCmm1 { get; set; }//弹出窗体命令1
        public DelegateCommand OpenCmm2 { get; set; }//弹出窗体命令2
        public DelegateCommand PubCmm { get; set; }//弹出窗体命令2

        public MainWinViewModel(DialogService dialogService,IEventAggregator eventAggregator)
        {
            OpenCmm1 = new DelegateCommand(() => {
                dialogService.Show("DialogUC1");

            });

            OpenCmm2 = new DelegateCommand(() => {
                dialogService.Show("DialogUC2");
                //dialogService.ShowDialog("DialogUCNew");
            });

            PubCmm = new DelegateCommand(() => {
                eventAggregator.GetEvent<MsgEventPara>().Publish("发布的参数");
            });


               

        }

        
    }
}
