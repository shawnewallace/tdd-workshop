import java.io.*;
import java.util.*;

// Replace %CODE% with requested id, and %ALTCODE% with "dashed" version of id.
// Run with -Dtemplatedir=src/resources/

public class CodeReplacer {
    public final String TEMPLATE_DIR = "templatedir";
    String sourceTemplate;
    String code;
    String altcode;

    public void substitute(String reqId, PrintWriter out) throws IOException 
    {
                // Read in the template file
        String templateDir = System.getProperty(TEMPLATE_DIR, "");
        StringBuffer sb = new StringBuffer("");
        try {
            FileReader fr = new FileReader(templateDir + "template.html");
            BufferedReader br = new BufferedReader(fr);
            String line;
            while(((line=br.readLine())!="")&&line!=null) sb = new StringBuffer(sb + line + "\n");
            br.close();
            fr.close();
        } catch (Exception e) {
        	e.printStackTrace();
        }
        sourceTemplate = new String(sb);

        try {
            String template = new String(sourceTemplate);    
                // Substitute for %CODE%
            int templateSplitBegin = template.indexOf("%CODE%");
            int templateSplitEnd = templateSplitBegin + 6;
            String templatePartOne = new String(template.substring(0, templateSplitBegin));
            String templatePartTwo = new String(template.substring(templateSplitEnd, template.length()));
            code = new String(reqId);
            template = new String(templatePartOne + code + templatePartTwo);

                // Substitute for %ALTCODE%
            templateSplitBegin = template.indexOf("%ALTCODE%");
            templateSplitEnd = templateSplitBegin + 9;
            templatePartOne = new String(template.substring(0, templateSplitBegin));
            templatePartTwo = new String(template.substring(templateSplitEnd, template.length()));
            altcode = code.substring(0,5) + "-" + code.substring(5,8);
            out.print(templatePartOne + altcode + templatePartTwo);
        } catch (Exception e) {
            System.out.println("Error in substitute()");
        }
        out.flush();
        out.close();
    }
}