using System;
using VisualHint.SmartFieldPackEditor.DateTimePack;

namespace DateTimePickerShowRoom
{
    public class MyDateTimePicker : DateTimePicker
    {
        public event EventHandler CustomFormatChanged;

        public override string CustomFormat
        {
            get { return base.CustomFormat; }

            set
            {
                if (base.CustomFormat != value)
                {
                    base.CustomFormat = value;
                    if (CustomFormatChanged != null)
                        CustomFormatChanged(this, EventArgs.Empty);
                }
            }
        }
    }
}
