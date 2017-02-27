using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHop
{
    public interface ITournament
    {
        #region Update, Add, Remove,Save,Read
        void update();
        void Add(Diver diver);
        void Remove(int index);
        void SaveToFile();
        void ReadFromFile();
        #endregion

    }
}
