import java.io.*;
import junit.framework.*;

public class CodeReplacerTest extends TestCase {
    CodeReplacer replacer;

    public CodeReplacerTest(String testName) {super(testName);}

    protected void setUp() {replacer = new CodeReplacer();}

    public void testTemplateLoadedProperly() {
        try {
            replacer.substitute("anything", new PrintWriter(new StringWriter()));
        } catch (Exception ex) {
            fail("No exception expected, but saw:" + ex);
        }

        assertEquals(
            "xxx%CODE%yyy%ALTCODE%zzz\n",
            replacer.sourceTemplate);
    }

    public void testSubstitution() {
        StringWriter stringOut = new StringWriter();
        PrintWriter testOut = new PrintWriter (stringOut);
        String trackingId = "01234567";
        
        try {
            replacer.substitute(trackingId, testOut);
        } catch (IOException ex) {
            fail ("testSubstitution exception - " + ex);
        }

        assertEquals("xxx01234567yyy01234-567zzz\n", stringOut.toString());
    }

}