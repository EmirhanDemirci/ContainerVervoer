using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class ExceptionHandler : Exception
    {
        /// Exception title.
        public string Index { get; }

        /// Create the exception with description.
        /// <param name="message">Exception description</param>
        public ExceptionHandler(string message) : base(message) { }


        /// Create the exception with title and description.
        /// <param name="index">Exception title</param>
        /// <param name="message">Exception description</param>
        public ExceptionHandler(string index, string message) : base(message)
        {
            Index = index;
        }
    }
}
