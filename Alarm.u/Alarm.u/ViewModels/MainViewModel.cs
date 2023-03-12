using System;
using System.Collections.Generic;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace Alarm.u.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IList<object> Times { get; } = new List<object>
        {
            new { time = "7 : 50" }, new { time = "7 : 50" }, new { time = "7 : 50" }, new { time = "7 : 50" }, new { time = "7 : 50" }, new { time = "7 : 50" }, new { time = "7 : 50" }
        };

        public Command ItemSelectedCommand { get; }

        public MainViewModel()
        {
            ItemSelectedCommand = new Command<(int, int, IList<int>)>(tuple =>
            {
                var (selectedWheelIndex, selectedItemIndex, selectedItemsIndex) = tuple;
                var selectedValue = Times[selectedItemIndex];
                //Do whatever you want here
            });
        }
    }
}

