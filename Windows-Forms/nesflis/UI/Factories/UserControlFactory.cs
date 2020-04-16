using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.UserControls;

namespace UI.Factories
{
    public static class UserControlFactory
    {
        public static UserControl CreateUserControl(int userControlCode, Dictionary<string, int> additionalParameters, Action<int, Dictionary<string, int>> doNavigation)
        {
            switch (userControlCode)
            {
                case UserControlRegistry.HOME_USER_CONTROL:
                    return new HomeUserControl(doNavigation);
                case UserControlRegistry.SEARCH_USER_CONTROL:
                    return new SearchUserControl(doNavigation);
                case UserControlRegistry.MOVIE_DETAILS_USER_CONTROL:
                    return new MovieDetailsUserControl(additionalParameters);
                default:
                    return new HomeUserControl(doNavigation);
            }
        }
    }
}
