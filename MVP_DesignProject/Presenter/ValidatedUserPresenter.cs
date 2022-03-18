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
        }
    }
}
