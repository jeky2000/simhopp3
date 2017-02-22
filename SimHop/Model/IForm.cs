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
    public delegate void DelegareRead();
    public interface IForm
    {
        void AddToDiverList(Collection<Diver> diver);
        event DelegateAdd EventAdd;
        event DelegareRead EventRead;
        event DelegateDelete EventDelete;
        event DelegateSave EventSave;
    }
}
