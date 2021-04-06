using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public interface IPageService
    {
        String GetString(string page);
    }
}
