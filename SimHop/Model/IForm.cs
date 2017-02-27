using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SimHop
{
    public delegate void DelegateLoginJudge();
    public delegate void DelegateLoginAdmin();
    public interface IForm
    {
        event DelegateLoginAdmin EventAdmin;
        event DelegateLoginJudge EventJudge;
    

    }
}

