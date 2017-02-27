using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace SimHop
{
    public delegate void DelegateAdd();
    public delegate void DelegateDelete(int index);
    public delegate void DelegateSave();
    public delegate void DelegateUpdate();
    public interface IAdmin
    {
        void AddToDiverList(Collection<Diver> diver);
        event DelegateUpdate EventUpdate;
        event DelegateAdd EventAdd;
        event DelegateDelete EventDelete;
        event DelegateSave EventSave;
    }
}
