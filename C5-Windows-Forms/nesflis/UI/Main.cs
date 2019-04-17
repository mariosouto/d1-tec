using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Factories;
using UI.UserControls;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DoNavigation(UserControlRegistry.HOME_USER_CONTROL);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            DoNavigation(UserControlRegistry.HOME_USER_CONTROL);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DoNavigation(UserControlRegistry.SEARCH_USER_CONTROL);
        }

        private void DoNavigation(int userControlCode, Dictionary<string, int> additionalParameters = null)
        {
            this.mainPanel.Controls.Clear();
            UserControl currentUserControl = UserControlFactory.CreateUserControl(userControlCode, additionalParameters, this.DoNavigation);
            this.mainPanel.Controls.Add(currentUserControl);
        }
    }
}
