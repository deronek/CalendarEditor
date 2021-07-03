using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CalendarEditor.Annotations;
using CalendarEditor.Exceptions;

namespace CalendarEditor
{
    public sealed class MyCalendarEvent : INotifyPropertyChanged
    {
        private DateTime end;
        private string message;
        private DateTime start;
        private string title;

        public MyCalendarEvent()
        {
            Reset();
        }

        public string Title
        {
            get => title;
            set
            {
                if (value == title) return;
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Message
        {
            get => message;
            set
            {
                if (value == message) return;
                message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        public DateTime Start
        {
            get => start;
            set
            {
                if (value.Equals(start)) return;
                start = value;
                OnPropertyChanged(nameof(Start));
            }
        }

        public DateTime End
        {
            get => end;
            set
            {
                if (value.Equals(end)) return;
                end = value;
                OnPropertyChanged(nameof(End));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Reset()
        {
            Title = string.Empty;
            Message = string.Empty;
            Start = DateTime.Now;
            End = DateTime.Now.AddHours(1);
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CheckValidity()
        {
            if (DateTime.Compare(Start, End) >= 0)
                throw new InvalidEndDateException("End date is greater or equal to start date");
        }
    }
}