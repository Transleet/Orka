using System.Threading.Tasks;

namespace Orka.Core;

public interface IOrkaClient
{
    Uin Uin { get; set; }
    
    Task LoginAsync();
}
