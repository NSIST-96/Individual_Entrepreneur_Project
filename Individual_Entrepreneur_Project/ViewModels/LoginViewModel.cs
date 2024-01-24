using Individual_Entrepreneur_Project.Infrastructure.Commands;
using Individual_Entrepreneur_Project.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace Individual_Entrepreneur_Project.ViewModels
{
    internal class LoginViewModel : ViewModel
    {
        #region Title

        private string _Title = "LOGIN";

        public string Title
        {
            get => _Title;
            set => Set(_Title, value);
        }

        #endregion

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

        #region TryLoginCommand

        public ICommand TryLoginCommand { get; }
        private void OnTryLoginCommandExecuted(object p)
        {

        }

        private bool CanTryLoginCommandExecute(object p) => true;

        #endregion

        #region GetRegistrationCommand

        public ICommand GetRegistrationCommand { get; }
        private void OnGetRegistrationCommandExecuted(object p)
        {

        }

        private bool CanGetRegistrationCommandExecute(object p) => true;

        #endregion

        #endregion

        public LoginViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            MinimizeWindowCommand = new LambdaCommand(OnMinimizeWindowCommandExecuted, CanMinimizeWindowCommandExecute);
            TryLoginCommand = new LambdaCommand(OnTryLoginCommandExecuted, CanTryLoginCommandExecute);
            GetRegistrationCommand = new LambdaCommand(OnGetRegistrationCommandExecuted, CanGetRegistrationCommandExecute);

            #endregion
        }
    }
}
