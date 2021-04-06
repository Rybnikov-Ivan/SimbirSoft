using API.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Tests.BL
{
    [TestFixture]
    public class PageServiceUnitTests
    {
        private PageService _pageService;

        [Test]
        public void GetStringValid()
        {
            string str = "https://www.simbirsoft.com/";
            this._pageService.GetString(str);
        }
    }
}
