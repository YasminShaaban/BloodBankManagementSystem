﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BloodBank
{
    class AgeException:Exception
    {
        public AgeException(string message):base(message)
        {
            MessageBox.Show(message);

        }

    }
}
