using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Orka.SourceGeneration;

namespace Orka.SourceGenerators;

[Generator]
public sealed partial class JceSourceGenerator : IIncrementalGenerator
{
    private const string JceMemberAttributeFullName = "Orka.Core.Serialization.Jce.JceMemberAttribute";
    private const string JceMemberAttributeText = @"
using System;

namespace Orka.Core.Serialization.Jce;

[AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
internal class JceMemberAttribute:Attribute
{
    public JceMemberAttribute(byte tag)
    {
        Tag = tag;
    }

    public byte Tag { get; set; }
}

";
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<ClassDeclarationSyntax> classDeclarations = context.SyntaxProvider.CreateSyntaxProvider(
            static (node, _) => Parser.IsSyntaxTargetForGeneration(node),
            Parser.GetSemanticTargetForGeneration)
            .Where(static _ => _ is not null);

        IncrementalValueProvider<(Compilation, ImmutableArray<ClassDeclarationSyntax>)> compilationAndClasses =
            context.CompilationProvider.Combine(classDeclarations.Collect());

        context.RegisterSourceOutput(compilationAndClasses, (spc, source) => Execute(source.Item1, source.Item2, spc));
    }

    private void Execute(Compilation compilation, ImmutableArray<ClassDeclarationSyntax> contextClasses,
        SourceProductionContext sourceProductionContext)
    {
#if LAUNCH_DEBUGGER
        if (!Diagnostics.Debugger.IsAttached)
        {
            Diagnostics.Debugger.Launch();
        }
#endif
        if (contextClasses.IsDefaultOrEmpty)
        {
            return;
        }

        JceSourceGenerationContext context = new JceSourceGenerationContext(sourceProductionContext);
        Parser parser = new(compilation, context);
    }
}

internal readonly struct JceSourceGenerationContext
{
    private readonly SourceProductionContext _context;

    public JceSourceGenerationContext(SourceProductionContext context)
    {
        _context = context;
    }

    public void ReportDiagnostic(Diagnostic diagnostic)
    {
        _context.ReportDiagnostic(diagnostic);
    }

    public void AddSource(string hintName, SourceText sourceText)
    {
        _context.AddSource(hintName, sourceText);
    }
}
