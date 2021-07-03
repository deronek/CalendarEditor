using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using CalendarEditor.Exceptions;
using CalendarEditor.Facade;
using CalendarEditor.Properties.Resources;

namespace CalendarEditor
{
    public partial class Form1 : Form
    {
        private MyCalendarEvent calendarEvent;

        public Form1()
        {
            InitializeComponent();

            calendarEvent = new MyCalendarEvent();
            BindCalendarEventProperties();
        }

        private void BindCalendarEventProperties()
        {
            textBoxTitle.DataBindings.Clear();
            textBoxMessage.DataBindings.Clear();
            dateTimePickerStart.DataBindings.Clear();
            dateTimePickerEnd.DataBindings.Clear();

            textBoxTitle.DataBindings.Add(
                "Text",
                calendarEvent,
                nameof(calendarEvent.Title),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            textBoxMessage.DataBindings.Add(
                "Text",
                calendarEvent,
                nameof(calendarEvent.Message),
                false,
                DataSourceUpdateMode.OnPropertyChanged);

            dateTimePickerStart.DataBindings.Add(
                "Value",
                calendarEvent,
                nameof(calendarEvent.Start),
                false,
                DataSourceUpdateMode.OnPropertyChanged);

            dateTimePickerEnd.DataBindings.Add(
                "Value",
                calendarEvent,
                nameof(calendarEvent.End),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            calendarEvent.Reset();
        }

        private void toolStripButtonSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                calendarEvent.CheckValidity();
                CalendarSaveFacade.SaveCalendar(calendarEvent);
            }
            catch (InvalidEndDateException)
            {
                ShowInvalidEndDateError();
            }
        }

        private static void ShowInvalidEndDateError()
        {
            MessageBox.Show(
                Strings.InvalidEndDateErrorMessage,
                Strings.ErrorCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void toolStripButtonSaveIcs_Click(object sender, EventArgs e)
        {
            try
            {
                calendarEvent.CheckValidity();
                CalendarSaveFacade.SaveCalendarIcs(calendarEvent);
            }
            catch (InvalidEndDateException)
            {
                ShowInvalidEndDateError();
            }
        }


        private void toolStripButtonSaveXml_Click(object sender, EventArgs e)
        {
            try
            {
                calendarEvent.CheckValidity();
                CalendarSaveFacade.SaveCalendarXml(calendarEvent);
            }
            catch (InvalidEndDateException)
            {
                ShowInvalidEndDateError();
            }
        }

        private void toolStripButtonSaveJson_Click(object sender, EventArgs e)
        {
            try
            {
                calendarEvent.CheckValidity();
                CalendarSaveFacade.SaveCalendarJson(calendarEvent);
            }
            catch (InvalidEndDateException)
            {
                ShowInvalidEndDateError();
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var newCalendarEvent = CalendarOpenFacade.OpenCalendar();
                if (newCalendarEvent == null) return;
                
                calendarEvent = newCalendarEvent;
                BindCalendarEventProperties();
                ShowSuccessfullyLoadedEventMessage();
            }
            catch (FormatException)
            {
                ShowInvalidFileMessage();
            }
            catch (SerializationException)
            {
                ShowInvalidFileMessage();
            }
        }

        private static void ShowInvalidFileMessage()
        {
            MessageBox.Show(
                Strings.InvalidEventFileMessage,
                Strings.ErrorCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private static void ShowSuccessfullyLoadedEventMessage()
        {
            MessageBox.Show(
                Strings.SucessfulyLoadedEventMessage,
                Strings.InformationCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}