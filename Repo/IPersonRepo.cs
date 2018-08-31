using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tester.Models;

namespace Tester.Repo
{
    public class IPersonRepo
    {
        private PersonContext context = new PersonContext();
        public IEnumerable<Person> People
        {
            get { return context.Persons; }
        }

    }
}