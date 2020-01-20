﻿using System;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace QSF.Examples.DateTimePickerControl.TimePickerExample
{
    public class Alarm : NotifyPropertyChangedBase
    {
        private DateTime? selectedHour;
        private string name;
        private bool isEnabled;
        private Color pickerTextColor;
        private Color nameTextColor;

        public Alarm()
        {
            this.name = "Alarm";
            this.isEnabled = false;
            this.pickerTextColor = Color.Black;
            this.nameTextColor = Color.FromHex("#6A6A6A");
            this.AccentColor = Color.FromHex("#B73562");
            this.SwitchColor = Color.FromHex("#66008265");
        }

        public DateTime? SelectedHour
        {
            get
            {
                return this.selectedHour;
            }
            set
            {
                if (this.selectedHour != value)
                {
                    this.selectedHour = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    this.OnPropertyChanged();
                    this.ChangeToggledColor();
                }
            }
        }

        public Color PickerTextColor
        {
            get
            {
                return this.pickerTextColor;
            }
            set
            {
                if (this.pickerTextColor != value)
                {
                    this.pickerTextColor = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public Color NameTextColor
        {
            get
            {
                return this.nameTextColor;
            }
            set
            {
                if (this.nameTextColor != value)
                {
                    this.nameTextColor = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public Color AccentColor { get; }

        public Color SwitchColor { get; }

        private void ChangeToggledColor()
        {
            if (this.isEnabled)
            {
                this.PickerTextColor = this.AccentColor;
                this.NameTextColor = this.AccentColor;
            }
            else
            {
                this.PickerTextColor = Color.Black;
                this.NameTextColor = Color.FromHex("#6A6A6A");
            }
        }
    }
}