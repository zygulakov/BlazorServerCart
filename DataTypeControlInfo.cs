namespace BlazorApp
{
	public class DataTypeControlInfo
	{

        InputBindablePropertyValue bindablePropertyValue;
        public InputBindablePropertyValue BindablePropertyValue
        {
            get => bindablePropertyValue;
            set
            {
                bindablePropertyValue = value;
            }
        }
    }
}
