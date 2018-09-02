using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment5
{
    interface IBeverageCollection
    {
        bool ItemExists(string id);

        string FindById(string id);

        string FindByName(string name);

        void AddNewItem(string id, string description, string pack, string price, string active);

        bool UpdateById(string id, string name, string pack, string price, string active);

        bool DeleteById(string deleteSearchQuery);
    }
}
