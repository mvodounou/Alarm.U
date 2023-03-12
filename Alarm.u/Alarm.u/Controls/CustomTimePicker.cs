using System;
using System.Collections.ObjectModel;
using Syncfusion.SfPicker.XForms;

namespace Alarm.u.Controls
{
    public class CustomTimePicker : SfPicker
    {

        public ObservableCollection<object> Time { get; set; }

        public ObservableCollection<object> Minute;

        public ObservableCollection<object> Hour;

        public ObservableCollection<object> Format;

        public ObservableCollection<string> Headers { get; set; }

        public CustomTimePicker()

        {

            Time = new ObservableCollection<object>();

            Hour = new ObservableCollection<object>();

            Minute = new ObservableCollection<object>();

            Format = new ObservableCollection<object>();

            PopulateTimeCollection();

            this.ItemsSource = Time;

        }

        private void PopulateTimeCollection()

        {
            //Populate Hour

            for (int i = 1; i <= 12; i++)
            {
                Hour.Add(i.ToString());
            }

            //Populate Minute

            for (int j = 0; j < 60; j++)

            {
                if (j < 10)
                {
                    Minute.Add("0" + j);
                }
                else
                    Minute.Add(j.ToString());

            }

            Time.Add("7 : 50");
            Time.Add("7 : 50");
            Time.Add("7 : 50");

        }
    }
}

