﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OfficeClient.Commands
{
    internal class EditWorkCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            MessageBox.Show("Edit");
            //TODO
        }
    }
}
