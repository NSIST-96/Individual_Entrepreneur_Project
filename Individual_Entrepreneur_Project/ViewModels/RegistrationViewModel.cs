using System.Windows.Input;
using System.Windows;
using Individual_Entrepreneur_Project.ViewModels.Base;
using Individual_Entrepreneur_Project.Infrastructure.Commands;

namespace Individual_Entrepreneur_Project.ViewModels
{
    internal class RegistrationViewModel : ViewModel
    {

        #region Commands

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p) { Application.Current.Shutdown(); }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        #endregion

        #region MinimizeWindowCommand
        public ICommand MinimizeWindowCommand { get; }
        private void OnMinimizeWindowCommandExecuted(object p) { p = WindowState.Minimized; }
        private bool CanMinimizeWindowCommandExecute(object p) => true;

        #endregion

        #endregion

        public RegistrationViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            MinimizeWindowCommand = new LambdaCommand(OnMinimizeWindowCommandExecuted, CanMinimizeWindowCommandExecute);

            #endregion
        }
    }
}
