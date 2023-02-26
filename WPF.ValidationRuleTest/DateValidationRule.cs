using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPF.ValidationRuleTest
{
    public class DateValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            TestData course = (value as BindingGroup).Items[0] as TestData;

            if (course.StartDate > course.EndDate)
            {
                return new ValidationResult(false, "시작일은 종료일보다 앞서야 합니다.");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
