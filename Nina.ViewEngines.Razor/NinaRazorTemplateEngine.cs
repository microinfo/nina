﻿using System;
using System.IO;
using System.Text;
using System.Web;
using RazorEngine.Compilation;
using RazorEngine.Templating;

namespace Nina.ViewEngines.Razor
{
    internal class NinaRazorTemplateEngine : ITemplateEngine
    {
        public const string EXT = "cshtml";
        private readonly RazorCompiler _compiler = new RazorCompiler(new CSharpLanguageProvider(), null, null);

        public ITemplate Compile<T>(string template)
        {
            var combine = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, template + "." + EXT);
            try
            {
                var t = _compiler.CreateTemplate(File.ReadAllText(combine), typeof(T));
                return new RazorTemplate(t);
            }
            catch (TemplateCompilationException e)
            {
                var sb =new StringBuilder();
                foreach (var compilerError in e.Errors)
                {
                    sb.AppendLine(compilerError.ToString());
                }
                
                throw new Exception(e.Message + sb.ToString(), e);
            }
        }
    }
}
    