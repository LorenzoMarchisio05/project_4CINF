using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12_Email.Interface
{
    public interface IMessaggio : IVisualizza
    {
       string NomeDestinatario { get; set; }

       string TestoMessaggio { get; set; }

    }
}
