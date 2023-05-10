using Typograth_Application;

namespace TypgrathTest
{
    [TestClass]
    public class TypograthUniTests
    {
        [TestMethod]
        public void RuleDefisTest()
        {
            string in_str = "Москва — столица России";
            string out_str = "Москва—столица России";

            mainForm main = new mainForm();

            string temp = main.rule_defis(in_str);
        }
    }
}