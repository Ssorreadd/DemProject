using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Project
{
    public class Base
    {
        public static List<Admin> admins = new List<Admin>();
     
        public static List<Runners> runners = new List<Runners>();
     
        public static ObservableCollection<Base> ToList()
        {

            return new ObservableCollection<Base>();
        }
    }
}
