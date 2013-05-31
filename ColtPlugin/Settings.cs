using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace ColtPlugin
{
    [Serializable]
    public class Settings
    {
        private String workingFolder = "colt";
        private Boolean fullConfig = false;
        private Boolean alwaysOverwriteProjects = false;
        
        /// <summary> 
        /// Get and sets colt folder
        /// </summary>
        [DisplayName("COLT Working Folder")]
        [Description("Path to COLT working folder."), DefaultValue("colt")]
        public String WorkingFolder 
        {
            get { return this.workingFolder; }
            set { this.workingFolder = value; }
        }

        /// <summary> 
        /// Get and sets full config flag
        /// </summary>
        [DisplayName("Load Full FD Configuration")]
        [Description("Attempt to load full FD configuration in COLT. FD project must be built at least once first."), DefaultValue(false)]
        public Boolean FullConfig 
        {
            get { return this.fullConfig; }
            set { this.fullConfig = value; }
        }

        /// <summary> 
        /// Get and sets full config flag
        /// </summary>
        [DisplayName("Always overwrite COLT projects")]
        [Description("Select this option to always overwrite COLT projects when FD project settings change."), DefaultValue(false)]
        public Boolean AlwaysOverwriteProjects
        {
            get { return this.alwaysOverwriteProjects; }
            set { this.alwaysOverwriteProjects = value; }
        }

    }

}
