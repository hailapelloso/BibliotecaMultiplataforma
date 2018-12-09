using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrabalhoFinalFIB.ViewModels
{
    public class BaseViewModel :
        // Essa interface indica que instâncias dessa classe disparam evento
        // avisando quando alguma propriedade muda de valor. Isso é usado pelos
        // bindings, para atualizar valores diversos
        INotifyPropertyChanged
    {
        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        bool mIsLoading = true;
        public bool IsLoading
        {
            get => mIsLoading;
            set
            {
                mIsLoading = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLoading"));
            }
        }

    }
}
