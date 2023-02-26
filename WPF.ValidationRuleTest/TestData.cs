using System;

namespace WPF.ValidationRuleTest
{
    public class TestData
    {
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TestData()
        {
            StartDate = EndDate = DateTime.Today;
        }
    }
}
