using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Interfaces;

public interface IAction
{
    public void Do();
    public void Undo();
    public String Description { get; }
}
