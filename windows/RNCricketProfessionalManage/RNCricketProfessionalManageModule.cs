using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cricket.Professional.Manage.RNCricketProfessionalManage
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCricketProfessionalManageModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCricketProfessionalManageModule"/>.
        /// </summary>
        internal RNCricketProfessionalManageModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCricketProfessionalManage";
            }
        }
    }
}
