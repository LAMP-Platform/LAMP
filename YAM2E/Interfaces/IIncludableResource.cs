using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Interfaces;

public interface IIncludableResource : INamedResource
{
    public bool Include { get; set; }
}
