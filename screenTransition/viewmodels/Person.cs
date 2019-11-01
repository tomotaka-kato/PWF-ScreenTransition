using System;
using System.Collections.Generic;
using System.Text;

namespace screenTransition.viewmodels
{
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }

        public Boolean AllInputed()
        {
            return !string.IsNullOrEmpty(Id)
                && !string.IsNullOrEmpty(Name)
                && !string.IsNullOrEmpty(Birthday)
                && !string.IsNullOrEmpty(Gender);
        }
    }
}
