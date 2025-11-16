using Prism.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrismDialog.ViewModels
{
    public class MainWinViewModel
    {
        public DelegateCommand OpenCmm { get; set; }//弹出窗体命令
        public DelegateCommand OpenNewCmm { get; set; }//弹出窗体命令

        public MainWinViewModel(DialogService dialogService)
        {
            OpenCmm = new DelegateCommand(() => { 
                DialogParameters dialogParas = new DialogParameters();
                dialogParas.Add("userName", "你是最棒的");
                dialogService.Show("DialogUC", dialogParas, ExeRstBusin);
                //dialogService.ShowDialog("DialogUC");

            });

            OpenNewCmm = new DelegateCommand(() => {
                dialogService.Show("DialogUCNew");
                //dialogService.ShowDialog("DialogUCNew");

            });

        }

        /// <summary>
        /// 处理弹窗返回的结果
        /// </summary>
        /// <param name="result"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ExeRstBusin(IDialogResult result)
        {
            string returnMsg = result.Parameters.GetValue<string>("rstMsg");

        }
    }
}
