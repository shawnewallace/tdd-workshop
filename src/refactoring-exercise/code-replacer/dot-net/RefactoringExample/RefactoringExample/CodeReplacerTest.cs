
using System;
using System.IO;
using NUnit.Framework;

namespace RefactoringExample
{
    [TestFixture]
    public class CodeReplacerTest
    {
        CodeReplacer replacer;

        [SetUp]
        public void SetUp()
        {
            replacer = new CodeReplacer();
        }

        [Test]
        public void TestTemplateLoadedProperly()
        {
            try
            {
                replacer.Substitute("anything", new StreamWriter(Stream.Null));
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, but saw:" + e);
            }
            Assert.AreEqual("xxx%CODE%yyy%ALTCODE%zzz\n", replacer.SourceTemplate);
        }

        [Test]
        public void TestSubstitution()
        {
            StringWriter stringOut = new StringWriter();
            String trackingId = "01234567";

            try
            {
                replacer.Substitute(trackingId, stringOut);
            }
            catch (IOException ex)
            {
                Assert.Fail("testSubstitution exception - " + ex);
            }
            catch (Exception e)
            {
            }

            Assert.AreEqual("xxx01234567yyy0123-4567zzz\n", stringOut.ToString());
        }
    }
}
