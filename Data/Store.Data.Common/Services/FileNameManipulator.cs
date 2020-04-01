using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Common.Services
{
    public class FileNameManipulator
    {
        public static string GenerateName()
        {
            return Guid.NewGuid().ToString().Substring(0, 10);
        }
    }
}
