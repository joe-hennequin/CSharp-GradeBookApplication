using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook (string name):base(name)
        {
            
        }

        public RankedGradeBook()
        {
            Type = Enums.GradeBookType.Ranked;
        }

    }
}
