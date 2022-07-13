using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace CommentRemover;

public static class Utilities
{
    public static bool IsLineEmpty(ITextSnapshotLine line)
    {
        var text = line.GetText().Trim();

        return (string.IsNullOrWhiteSpace(text)
               || text == "<!--"
               || text == "-->"
               || text == "<%%>"
               || text == "<%"
               || text == "%>"
               || Regex.IsMatch(text, @"<!--(\s+)?-->"));
    }

    public static bool IsXmlDocComment(ITextSnapshotLine line)
    {
        var text = line.GetText().Trim();
        Microsoft.VisualStudio.Utilities.IContentType contentType = line.Snapshot.TextBuffer.ContentType;

        if (contentType.IsOfType("CSharp") && text.StartsWith("///"))
        {
            return true;
        }

        if (contentType.IsOfType("FSharp") && text.StartsWith("///"))
        {
            return true;
        }

        if (contentType.IsOfType("Basic") && text.StartsWith("'''"))
        {
            return true;
        }

        return false;
    }
}
