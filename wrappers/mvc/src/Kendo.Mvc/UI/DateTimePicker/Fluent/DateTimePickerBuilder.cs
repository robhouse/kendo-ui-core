namespace Kendo.Mvc.UI.Fluent
{
    using Kendo.Mvc.Infrastructure;
    using Kendo.Mvc.Resources;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="TimePicker"/> component.
    /// </summary>
    public class DateTimePickerBuilder : DatePickerBuilderBase<DateTimePicker, DateTimePickerBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimePickerBuilder"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public DateTimePickerBuilder(DateTimePicker component)
            : base(component)
        {
        }

        /// <summary>
        /// Sets the interval between hours.
        /// </summary>
        public DateTimePickerBuilder Interval(int interval) 
        {

            Component.Interval = interval;

            return this;
        }

        /// <summary>
        /// Binds the TimeView to a list of DateTime objects.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TimePicker()
        ///             .Name("TimePicker")
        ///             .BindTo(new List<DateTime>
        ///             {
        ///                 DateTime.Now
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public DateTimePickerBuilder BindTo(List<DateTime> dates)
        {

            Component.Dates = dates;

            return this;
        }

        public DateTimePickerBuilder Footer(string footer)
        {
            Component.Footer = footer;

            return this;
        }

        public DateTimePickerBuilder FooterId(string id)
        {
            Component.FooterId = id;

            return this;
        }

        public DateTimePickerBuilder Depth(CalendarView depth)
        {

            Component.Depth = depth.ToString().ToLower();

            return this;
        }

        public DateTimePickerBuilder Start(CalendarView start)
        {

            Component.Start = start.ToString().ToLower();

            return this;
        }

        public DateTimePickerBuilder MonthTemplateId(string id)
        {
            Component.MonthTemplate.ContentId = id;

            return this;
        }

        public DateTimePickerBuilder MonthTemplate(string content)
        {
            Component.MonthTemplate.Content = content;

            return this;
        }

        public DateTimePickerBuilder MonthTemplate(Action<MonthTemplateBuilder> monthTemplateAction)
        {
            monthTemplateAction(new MonthTemplateBuilder(Component.MonthTemplate));

            return this;
        }

        /// <summary>
        /// Sets the minimal date, which can be selected in DatePicker.
        /// </summary>
        public DateTimePickerBuilder Min(string date)
        {

            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Min = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }

        /// <summary>
        /// Sets the maximal date, which can be selected in DatePicker.
        /// </summary>
        public DateTimePickerBuilder Max(string date)
        {

            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Max = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }
    }
}