using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12_Email.Interface
{
    public interface IDocumento : IVisualizza
    {
        string Titolo { get; set; }

        string Path { get; set; }
    }
}
