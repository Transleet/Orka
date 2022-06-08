using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Orka.SourceGeneration;

namespace Orka.SourceGenerators
{
    public sealed partial class JceSourceGenerator
    {
        private sealed class Parser
        {
            private readonly Compilation _compilation;
            private readonly JceSourceGenerationContext _sourceGenerationContext;
            private readonly MetadataLoadContext _metadataLoadContext;

            internal static bool IsSyntaxTargetForGeneration(SyntaxNode node) => node is ClassDeclarationSyntax;

            internal static ClassDeclarationSyntax? GetSemanticTargetForGeneration(GeneratorSyntaxContext context, CancellationToken cancellationToken)
            {
                var classDeclarationSyntax = (ClassDeclarationSyntax)context.Node;
                var properties = classDeclarationSyntax.Members.OfType<PropertyDeclarationSyntax>().ToList();
                foreach (PropertyDeclarationSyntax propertyDeclarationSyntax in properties)
                {
                    foreach (AttributeListSyntax attributeListSyntax in propertyDeclarationSyntax.AttributeLists)
                    {
                        foreach (AttributeSyntax attributeSyntax in attributeListSyntax.Attributes)
                        {
                            cancellationToken.ThrowIfCancellationRequested();

                            IMethodSymbol attributeSymbol = context.SemanticModel.GetSymbolInfo(attributeSyntax, cancellationToken).Symbol as IMethodSymbol;
                            if (attributeSymbol == null)
                            {
                                continue;
                            }

                            INamedTypeSymbol attributeContainingTypeSymbol = attributeSymbol.ContainingType;
                            string fullName = attributeContainingTypeSymbol.ToDisplayString();

                            if (fullName == JsonSerializableAttributeFullName)
                            {
                                return classDeclarationSyntax;
                            }
                        }
                    }

                }

                return null;
            }
        }
    }
}
