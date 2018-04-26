using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;
using Recipizer.Core.ViewModels;

namespace Recipizer.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<CreateRecipeViewModel>();
        }
    }
}
