using MVP_DesignProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_DesignProject.Presenter
{    
    public class ValidatedUserPresenter
    {
        public IValidatedUserView _validatedUserView;
        public ValidatedUserPresenter(IValidatedUserView validatedUserView)
        {
            _validatedUserView = validatedUserView;
            _validatedUserView.CancelClicked += buttonCancel_Click;
            _validatedUserView.SubmitClicked += buttonSubmit_Click;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ValidatedUser validatedUser = GetUserDetails(_validatedUserView.AccountNumber);
            _validatedUserView.Name = validatedUser.Name;
            _validatedUserView.AccStatus = validatedUser.AccStatus;
            _validatedUserView.Currency = validatedUser.Currency;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        private ValidatedUser GetUserDetails(string accNo)
        {
            // Call for API
            return null;
        }
    }
}
