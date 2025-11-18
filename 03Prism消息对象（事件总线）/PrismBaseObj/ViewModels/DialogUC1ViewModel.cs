using PrismDialog.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrismDialog.ViewModels
{
    public class DialogUC1ViewModel : IDialogAware
    {
        public string Title => "窗口1";
        public DialogCloseListener RequestClose { get; set; }

        public DelegateCommand SubCmm { get; set; }

        public DialogUC1ViewModel(IEventAggregator eventAggregator)
        {
            SubCmm = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<MsgEventPara>().Subscribe((msg) => {
                    MessageBox.Show($"弹窗1收到了{msg}");
                });
            });
        }

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
