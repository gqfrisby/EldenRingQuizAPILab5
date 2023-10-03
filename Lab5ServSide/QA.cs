
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{

    /// <summary>
    /// The Class QA will be used to hold text for each node within the binary tree
    /// by creating QA objects. 
    /// </summary>
    internal class QA
    {
        /// <summary>
        /// Prompt Field it The actual Question or anwser that needs to be held
        /// </summary>
        public string Prompt { get; set; }

        /// <summary>
        /// Constructor class to enable instance creation of the QA Class
        /// </summary>
        /// <param name="prompt">The desired message or text attached to the QA instance</param>
        public QA(string prompt)
        {
            Prompt = prompt;
        }
    }
}
