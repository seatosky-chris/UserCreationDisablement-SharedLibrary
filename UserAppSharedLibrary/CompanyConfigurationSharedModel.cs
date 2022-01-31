using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAppSharedLibrary
{
    public class CompanyConfigurationSharedModel
    {
       /// <summary>
       /// The AD types possible for configuration.
       /// </summary>
        public enum ADTypeConfiguration { OnPremise, Azure, None }

        /// <summary>
        /// The Email types possible for configuration.
        /// </summary>
        public enum EmailTypeConfiguration { O365, Exchange, None }
    }
}
