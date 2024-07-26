using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class urilearning
    {
        public void u_r_i()
        {
            UriBuilder builder = new UriBuilder
            {
                Scheme = "https",
                Host = "google.com",
                Port = 443,
                Path = "api/data",
                Query = "id=10&value=test"
            };

            // Get the constructed URI
            Uri uri = builder.Uri;

            // Output the URI
            Console.WriteLine(uri.ToString());
        }
    }
}
