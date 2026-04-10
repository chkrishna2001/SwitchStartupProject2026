using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchStartupProject
{
    public class Configuration
    {
        public bool ListSingleProjects { get; private set; }
        public IList<MultiProjectConfiguration> MultiProjectConfigurations { get; private set; }

        public Configuration(bool listSingleProjects, IList<MultiProjectConfiguration> multiProjectConfigurations)
        {
            this.ListSingleProjects = listSingleProjects;
            this.MultiProjectConfigurations = multiProjectConfigurations;
        }
    }
}
