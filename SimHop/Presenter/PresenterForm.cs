using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHop
{
    public class PresenterForm
    {
        public IAdmin _view { get; set; }
        public IForm _look { get; set; }
        public ITournament _model { get; set; }
        public PresenterForm( Tournament tr,IAdmin view )

        {
            this._model = tr;
            this._view = view;
            //this._look = look;
            //connect to database
            this._model.update();
            

            this._view.AddToDiverList(tr.List);

            
            this._view.EventAdd += Add;
            this._view.EventDelete += DeleteDiver;
            this._view.EventUpdate += ReadFromFile;
            this._view.EventSave += SaveToFile;

            #region Add, Delete, save, read

        }
        public void Add()
        {
            this._model.Add(new Diver());
        }
        public void DeleteDiver(int index)
        {
            this._model.Remove(index);
        }
        public void SaveToFile()
        {
            this._model.SaveToFile();
        }
        public void ReadFromFile()
        {
            this._model.ReadFromFile();
        }
        #endregion
    }
}
