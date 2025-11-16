using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PrismDialog.ViewModels
{
    public class DialogUCViewModel:IDialogAware
    {
        public string Title => "这是一个弹出窗体"; 
        public DialogCloseListener  RequestClose{ get; set; }

        /// <summary>
        /// 是否可关闭   
        /// </summary>
        /// <returns></returns>
        public bool CanCloseDialog()
        {
            return true;
        }
        private IDialogParameters _dialogParameters;

        public DelegateCommand ExeCmm { get; set; }

        public DialogUCViewModel()
        {

            ExeCmm = new DelegateCommand(() =>
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult.Parameters.Add("rstMsg", "这是弹出窗体返回的信息");
                RequestClose.Invoke(dialogResult);
            });
        }


        public void OnDialogClosed()
        {
            
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
            _dialogParameters = parameters;
            string uName = parameters.GetValue<string>("userName");
        }

      
    }
}
