namespace MonkeyFinder.ViewModel;

//[INotifyPropertyChanged]
// partial class because the MVVM toolkit is generating the other half of the code

// by inheriting ObservableObject will give more function in addition to INotifyPropertyChanged
public partial class BaseViewModel : ObservableObject
{
    //private bool isBusy = false; // activity indicator
    //private string title = ""; // title of the app

    #region Will be removed because of the MVVM toolkit
    //public bool IsBusy
    //{
    //    get => isBusy; // if getting, just returns the value
    //    set // if setting (Changing the value)
    //    {
    //        if (isBusy == value) // checks if the value is the same
    //            return; // if so, just returns actual value

    //        isBusy = value; // if not the same, update the value
    //        //OnPropertyChanged("IsBusy"); // notifies the view that a value has changed
    //        // alternative
    //        //OnPropertyChanged(nameof(IsBusy)); // nameof returns the string name of the method
    //        OnPropertyChanged(); // this only works if CallerMemberName is used.
    //        OnPropertyChanged(nameof(IsNotBusy)); // notifies MAUI that IsNotBusy is also updated
    //    }
    //}

    //public string Title
    //{
    //    get => title;
    //    set
    //    {
    //        if (title == value)
    //            return;
    //        title = value;
    //        OnPropertyChanged();
    //    }
    //}

    //public bool IsNotBusy => !IsBusy; // just updates the value of IsNotBusy to have the opposite value of IsBusy

    //// event that maui is registering and signing up for
    //public event PropertyChangedEventHandler PropertyChanged;

    //// caller member name is a compile time event. 
    //// if the OnPropertyChanged event is called and no string name has been called,
    //// it will just assume its the name of the method that has been passed.
    //public void OnPropertyChanged([CallerMemberName] string name = null)
    ////public void OnPropertyChanged(string name)
    //{
    //    // is anyone subscribed to this event? If so, invoke it
    //    // its going to pass itself and give it a new event which will pass the name property
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //}
    #endregion

    public BaseViewModel()
    {
        
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(isNotBusy))] //>>> NotifyPropertyChangedFor is replacing AlsoNotifyChangeFor >>> https://stackoverflow.com/questions/73295604/in-which-package-can-i-find-alsonotifychangefor-in-net-maui
    bool isBusy = false;

    [ObservableProperty]
    string title = "";

    public bool isNotBusy => !IsBusy;
}
