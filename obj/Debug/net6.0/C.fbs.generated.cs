
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the FlatSharp FBS to C# compiler (source hash: 6.2.1.bXSi7plOzrYx7Gi2aD1ezeAigmFtGXQMI5qo3woDX3E=)
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Internal;
#pragma warning disable 0618
#nullable enable
namespace FlatSharp.Compiler.Generated
{
    internal static class CloneHelpers_00c9d3a3069f40e4bc60e136644dd04e
    {
        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.IncludesExample.TableFromC? Clone(global::Samples.IncludesExample.TableFromC? item)
        {
            checked
            {
                return item is null ? null : new Samples.IncludesExample.TableFromC(item);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.String? Clone(global::System.String? item)
        {
            checked
            {
                return item;
            }
        }
    }

}

namespace Samples.IncludesExample
{
    [FlatBufferTable()]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class TableFromC
        : object
    {
#pragma warning disable CS8618
        public TableFromC()
        {
            checked
            {
                this.String = default!;
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected TableFromC(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public TableFromC(TableFromC source)
        {
            checked
            {
                this.String = FlatSharp.Compiler.Generated.CloneHelpers_00c9d3a3069f40e4bc60e136644dd04e.Clone(source.String);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0)]
        public virtual string? String { get; set; }
    }

}

