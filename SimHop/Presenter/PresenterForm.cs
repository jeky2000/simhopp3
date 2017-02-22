using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHop
{
    public class PresenterForm
    {
        
        public IForm _view { get; set; }
        public ITournament _model { get; set; }
        public PresenterForm(IForm view, Tournament tr)

        {
            this._model = tr;
            this._view = view;
            //connect to database
            this._model.update();


            this._view.AddToDiverList(tr.List);

            
            this._view.EventAdd += Add;
            this._view.EventDelete += DeleteDiver;
            this._view.EventRead += ReadFromFile;
            this._view.EventSave += SaveToFile;


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
        
    }
}
