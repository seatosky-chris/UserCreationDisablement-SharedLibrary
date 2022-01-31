using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAppSharedLibrary
{
    public class ADFolderDefaultModel
    {
        /// <summary>
        /// A randomly generated uuid that is unique to this entry.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The priority to give this selection if multiple options match the user.
        /// The lower the number, the higher the priority (e.g. 1 is the highest).
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// A friendly name for the folder location.
        /// </summary>
        public string FolderName { get; set; }

        /// <summary>
        /// The folder location in AD.
        /// This will be used to determine where to place the user account in AD.
        /// Also used in the disablement script to determine where to search for users.
        /// </summary>
        /// <remarks>
        /// This should be the "canonical name of object" found under the folders properties > Object page.
        /// This is the only property in this model used by the Disablement app.
        /// </remarks>
        /// <example>seatosky.local/Divisions/Accounting</example>
        public string FolderLocation { get; set; }

        /// <summary>
        /// A list of ITG locations to apply this folder to by default.
        /// </summary>
        /// <see cref="CompanyConfigurationModel.Locations"/>
        public List<int> Locations { get; set; } = new List<int>();

    }
}
