using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp4
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _name;

        private readonly Service _service;

        public MainViewModel()
        {
            _service = new Service();

            SetValues1Command = new Command(
                execute: () => SetValues1());

            SetValues2Command = new Command(
                execute: () => SetValues2());
        }

        public ICommand SetValues1Command { get; private set; }
        public ICommand SetValues2Command { get; private set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
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
            Name = "One";
        }
        
        public void SetValues2()
        {
            Name = "Two";
        }
    }
}
