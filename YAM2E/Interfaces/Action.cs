using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Interfaces;

internal interface Action
{
    public void Do();
    public void Undo();
    public String Description { get; }
}
