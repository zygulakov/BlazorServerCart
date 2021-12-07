using System;
using System.ComponentModel;
using System.Globalization;

namespace BlazorApp
{
    [TypeConverter(typeof(PropertyValueConverter))]
    public class InputBindablePropertyValue
    {
        public InputBindablePropertyValue(object value)
        {
            Value = value;
        }
        public object Value { get; }
    }

    public class PropertyValueConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return new InputBindablePropertyValue(value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return true;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            var bindableValue = ((InputBindablePropertyValue)value)?.Value;
            if (bindableValue == null)
                return null;

            if (bindableValue is string strValue)
                return strValue;

            //TODO: if the destiniation type is numeric, return the value casted. Probably should handle dates and whatnot too?
            return bindableValue?.ToString();
        }
    }
}
