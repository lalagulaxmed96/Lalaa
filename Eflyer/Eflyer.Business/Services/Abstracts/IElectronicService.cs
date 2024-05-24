using Eflyer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eflyer.Business.Services.Abstracts
{
   public interface IElectronicService
    {
        void RemoveElectronic(int id);
        void AddElectronic(Electronic electronic);
        void UpdateElectronic(Electronic electronic);

        Electronic GetElectronic(Func<Electronic, bool>? func = null);
        List<Electronic> GetAllElectronics(Func<Electronic, bool>? func =null);
    }
}
