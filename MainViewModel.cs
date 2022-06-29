using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp4
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool _Button1Visible;
        private bool _Button2Visible;
        private bool _Button3Visible;

        public MainViewModel()
        {
            SetValues1Command = new Command(
                execute: () => SetValues1());

            SetValues2Command = new Command(
                execute: () => SetValues2());
            
            SetValues3Command = new Command(
                execute: () => SetValues3());

            Button1Visible = true;
            Button2Visible = false;
            Button3Visible = false;
        }

        public ICommand SetValues1Command { get; private set; }
        public ICommand SetValues2Command { get; private set; }
        public ICommand SetValues3Command { get; private set; }

        public bool Button1Visible
        {
            get => _Button1Visible;
            set
            {
                _Button1Visible = value;
                OnPropertyChanged();
            }
        }

        public bool Button2Visible
        {
            get => _Button2Visible;
            set
            {
                _Button2Visible = value;
                OnPropertyChanged();
            }
        }
        
        public bool Button3Visible
        {
            get => _Button3Visible;
            set
            {
                _Button3Visible = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetValues1()
        {
            Button1Visible = false;
            Button2Visible = true;
            Button3Visible = true;
        }
        
        public void SetValues2()
        {
            Button1Visible = true;
            Button2Visible = false;
            Button3Visible = false;
        }

        public void SetValues3()
        {
            Button1Visible = true;
            Button2Visible = true;
            Button3Visible = false;
        }
    }
}
