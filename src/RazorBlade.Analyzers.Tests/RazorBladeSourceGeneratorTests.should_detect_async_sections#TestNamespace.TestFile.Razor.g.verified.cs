﻿//HintName: TestNamespace.TestFile.Razor.g.cs
#pragma checksum "./TestFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dfde4afe6bc3a38a99983a56c31051d8674231"
// <auto-generated/>
#pragma warning disable 1591
namespace TestNamespace
{
    #line hidden
#nullable restore
#line 1 "./TestFile.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    #nullable restore
    internal partial class TestFile : global::RazorBlade.HtmlTemplate
    #nullable disable
    {
        #pragma warning disable 1998
        protected async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "./TestFile.cshtml"
 if (42.ToString() == "42") {
    

#line default
#line hidden
#nullable disable
            DefineSection("SectionName", async() => {
                WriteLiteral(" ");
#nullable restore
#line (3,29)-(3,54) 6 "./TestFile.cshtml"
Write(await Task.FromResult(42));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
#nullable restore
#line 3 "./TestFile.cshtml"
                                                       
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
