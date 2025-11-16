using PrismDialog.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PrismBaseObj
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        /// <summary>
        ///启动窗体
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell()
        {
           return Container.Resolve<MainWin>();
        }
        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="containerRegistry"></param>
        /// <exception cref="NotImplementedException"></exception>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //注册弹窗
            containerRegistry.RegisterDialog<DialogUC>();
            containerRegistry.RegisterDialog<DialogUCNew>();
            containerRegistry.RegisterDialogWindow<DialogOuter>();
        }
    }

}
