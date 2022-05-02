using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Interface
{
    public interface IPolygon : IsWritableToFile
    {
        double GetArea();
    }
}
