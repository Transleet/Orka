using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka;

public interface IOrkaClient
{
    Task LoginAsync();
}
