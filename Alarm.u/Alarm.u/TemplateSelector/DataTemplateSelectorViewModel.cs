using System;
using System.Reflection;
using Xamarin.Forms;

namespace Alarm.u.TemplateSelector
{
    public class DataTemplateSelectorViewModel : DataTemplateSelector
    {
        private DataTemplate defaulttemplate;

        public DataTemplate DefaultTemplate
        {
            get { return defaulttemplate; }
            set { defaulttemplate = value; }
        }

        private DataTemplate specifictemplate;

        public DataTemplate SpecificTemplate
        {
            get { return specifictemplate; }
            set { specifictemplate = value; }
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return DefaultTemplate;
        }
    }
}

