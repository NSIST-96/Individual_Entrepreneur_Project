using Individual_Entrepreneur_Project.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
