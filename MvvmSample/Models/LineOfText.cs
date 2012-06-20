using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmSample.Models
{
    class LineOfText
    {
        #region Fields

        string _line;

        #endregion

        #region Properties

        public string Line
        {
            get { return _line; }
            set { _line = value; }
        }

        #endregion
    }
}
