using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Polymorphism
{
    public abstract class Developer
    {
        private string _devLanguage;

        public Developer(string devLanguage)
        {
            _devLanguage = devLanguage;
        }

        public virtual void Code()
        {
            Console.WriteLine(string.Format("I would rather coding my dev language {0}.", this._devLanguage));
        }

        public virtual void Code(string newDevLanguage)
        {
            Console.WriteLine(string.Format("I would rather coding my dev language {0}. Additionally, I like {1} as new dev language.", this._devLanguage, newDevLanguage));
        }
    }
}
