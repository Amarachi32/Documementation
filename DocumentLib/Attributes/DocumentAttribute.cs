using DocumentLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLib.Attributes
{
    [AttributeUsage(AttributeTargets.All | AttributeTargets.Enum, Inherited = false, AllowMultiple = true)]
    public class DocumentAttribute : Attribute
    {
        public DocumentAttribute(string description)
        {
            Description = description;
        }

        public DocumentAttribute(string description, string input = "", string output = "")
        {
            Description = description;
            Input = input;
            Output = output;
        }

        public string Description { get; }
        public string Input { get; }
        public string Output { get; }

    }
}
