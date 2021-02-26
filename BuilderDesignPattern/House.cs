using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class House
    {
        private List<string> _components = new List<string>();

        public void AddPart(string part)
        {
            this._components.Add(part);
        }

        public string DisplayComponents()
        {
            var results = string.Empty;
            foreach (var item in this._components)
            {
                results += item + " ";
            }
            return results;
        }

    }
}
