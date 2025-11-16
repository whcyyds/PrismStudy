using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDialog.ViewModels
{
    public class DialogUCNewViewModel : IDialogAware
    {
        public string Title => "新标题";
        public DialogCloseListener RequestClose{ get; set; }

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
