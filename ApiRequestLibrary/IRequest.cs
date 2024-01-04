using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataProject
{
    public interface IRequest
    {
        string requestUrl(string url);
    }
}
