using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoteGame.Model
{
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string name { get; set; }
        public Nature_Player nature { get; set; }
        public Nullable<Boolean> isOne { get; set; }
        public BindingList<Space> tokens { get; set; }
        public int _score { get; set; }
        public int score
        {
            get { return _score; }
            set
            {
                if (_score != value)
                {
                    _score = value;
                    OnPropertyChanged("score");
                }
            }
        }

        public Player() { }

        public Player(string name, Boolean isOne)
        {
            this.isOne = isOne;
            this.name = name;
            this.nature = (name == "Ordinateur") ? Nature_Player.Computeur
                                                 : Nature_Player.Human;
            this.tokens = new BindingList<Space>();
            this.tokens.ListChanged += delegate (object sender, ListChangedEventArgs args)
            {
                OnPropertyChanged("tokens");
            };
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
