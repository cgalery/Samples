
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the FlatSharp FBS to C# compiler (source hash: 6.2.1.QZL4f+XHseeRsbolMrboqIn2tkssRLv/LZPVY1HrUH0=)
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
    internal static class CloneHelpers_473b05a39d21486ead7a5372d54bd045
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.CopyConstructorsExample.Fruit Clone(global::Samples.CopyConstructorsExample.Fruit item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.SByte Clone(global::System.SByte item)
        {
            checked
            {
                return item;
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.CopyConstructorsExample.Bar? Clone(global::Samples.CopyConstructorsExample.Bar? item)
        {
            checked
            {
                return item is null ? null : new Samples.CopyConstructorsExample.Bar(item);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.CopyConstructorsExample.Foo? Clone(global::Samples.CopyConstructorsExample.Foo? item)
        {
            checked
            {
                return item is null ? null : new Samples.CopyConstructorsExample.Foo(item);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.UInt64 Clone(global::System.UInt64 item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Int16 Clone(global::System.Int16 item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.UInt32 Clone(global::System.UInt32 item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Int32 Clone(global::System.Int32 item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Single Clone(global::System.Single item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.UInt16 Clone(global::System.UInt16 item)
        {
            checked
            {
                return item;
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.CopyConstructorsExample.FooBar? Clone(global::Samples.CopyConstructorsExample.FooBar? item)
        {
            checked
            {
                return item is null ? null : new Samples.CopyConstructorsExample.FooBar(item);
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

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Double Clone(global::System.Double item)
        {
            checked
            {
                return item;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Byte Clone(global::System.Byte item)
        {
            checked
            {
                return item;
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.CopyConstructorsExample.FooBarContainer? Clone(global::Samples.CopyConstructorsExample.FooBarContainer? item)
        {
            checked
            {
                return item is null ? null : new Samples.CopyConstructorsExample.FooBarContainer(item);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Collections.Generic.IList<Samples.CopyConstructorsExample.FooBar>? Clone(global::System.Collections.Generic.IList<Samples.CopyConstructorsExample.FooBar>? item)
        {
            checked
            {
                return VectorCloneHelpers.Clone<Samples.CopyConstructorsExample.FooBar>(item, FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Boolean Clone(global::System.Boolean item)
        {
            checked
            {
                return item;
            }
        }
    }

}

namespace Samples.CopyConstructorsExample
{
    [FlatBufferEnum(typeof(sbyte))]
    public enum Fruit : sbyte
    {
        Apples = 0,
        Pears = 1,
        Bananas = 2,
    }

}

namespace Samples.CopyConstructorsExample
{
    [FlatBufferStruct]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class Bar
    {
#pragma warning disable CS8618
        public Bar()
        {
            checked
            {
                this.parent = new Samples.CopyConstructorsExample.Foo();
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected Bar(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Bar(Bar source)
        {
            checked
            {
                this.parent = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.parent);
                this.time = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.time);
                this.ratio = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.ratio);
                this.size = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.size);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0)]
        public virtual Samples.CopyConstructorsExample.Foo parent { get; set; }

        [FlatBufferItemAttribute(1)]
        public virtual int time { get; set; }

        [FlatBufferItemAttribute(2)]
        public virtual float ratio { get; set; }

        [FlatBufferItemAttribute(3)]
        public virtual ushort size { get; set; }
    }

}

namespace Samples.CopyConstructorsExample
{
    [FlatBufferStruct]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class Foo
    {
#pragma warning disable CS8618
        public Foo()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected Foo(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Foo(Foo source)
        {
            checked
            {
                this.id = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.id);
                this.count = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.count);
                this.prefix = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.prefix);
                this.length = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.length);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0)]
        public virtual ulong id { get; set; }

        [FlatBufferItemAttribute(1)]
        public virtual short count { get; set; }

        [FlatBufferItemAttribute(2)]
        public virtual sbyte prefix { get; set; }

        [FlatBufferItemAttribute(3)]
        public virtual uint length { get; set; }
    }

}

namespace Samples.CopyConstructorsExample
{
    [FlatBufferTable()]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class FooBar
        : object
    {
#pragma warning disable CS8618
        public FooBar()
        {
            checked
            {
                this.sibling = default!;
                this.name = default!;
                this.rating = default!;
                this.postfix = default!;
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected FooBar(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public FooBar(FooBar source)
        {
            checked
            {
                this.sibling = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.sibling);
                this.name = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.name);
                this.rating = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.rating);
                this.postfix = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.postfix);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0)]
        public virtual Samples.CopyConstructorsExample.Bar? sibling { get; set; }

        [FlatBufferItemAttribute(1)]
        public virtual string? name { get; set; }

        [FlatBufferItemAttribute(2)]
        public virtual double rating { get; set; }

        [FlatBufferItemAttribute(3)]
        public virtual byte postfix { get; set; }
    }

}

namespace Samples.CopyConstructorsExample
{
    [FlatBufferTable()]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class FooBarContainer
        : object
    {
#pragma warning disable CS8618
        public FooBarContainer()
        {
            checked
            {
                this.list = default!;
                this.initialized = default!;
                this.fruit = default!;
                this.location = default!;
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected FooBarContainer(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public FooBarContainer(FooBarContainer source)
        {
            checked
            {
                this.list = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.list);
                this.initialized = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.initialized);
                this.fruit = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.fruit);
                this.location = FlatSharp.Compiler.Generated.CloneHelpers_473b05a39d21486ead7a5372d54bd045.Clone(source.location);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0)]
        public virtual IList<Samples.CopyConstructorsExample.FooBar>? list { get; set; }

        [FlatBufferItemAttribute(1)]
        public virtual bool initialized { get; set; }

        [FlatBufferItemAttribute(2)]
        public virtual Samples.CopyConstructorsExample.Fruit fruit { get; set; }

        [FlatBufferItemAttribute(3)]
        public virtual string? location { get; set; }
    }

}
