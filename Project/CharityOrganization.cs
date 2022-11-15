using System.Collections.Generic;

namespace Project
{
    internal class CharityOrganization
    {
        internal string Name { get; set; }

        internal List<Sponsors> sponsors = new List<Sponsors>();
    }
}
