using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeurologicTest.Resources;

namespace NeurologicTest
{
    public class MyLocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources MyLocalizedResources { get { return _localizedResources; } }
    }
}
