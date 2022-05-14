using System;
using System.Collections.Generic;
using System.Text;

namespace Slice.LocalDB
{
    internal interface ISQLite
    {
        string GetDbPath(string fileName);
    }
}
