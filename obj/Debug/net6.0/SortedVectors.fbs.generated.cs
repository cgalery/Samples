
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the FlatSharp FBS to C# compiler (source hash: 6.2.1.sD8q9yzQc5T1cjTKTUzA/7H3emArIePbFxYqYvxVzDA=)
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
    internal static class CloneHelpers_1c0922197bc746b2b9f5cd1167ac21e9
    {
        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.SortedVectors.Fbs.User? Clone(global::Samples.SortedVectors.Fbs.User? item)
        {
            checked
            {
                return item is null ? null : new Samples.SortedVectors.Fbs.User(item);
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

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::Samples.SortedVectors.Fbs.UserList? Clone(global::Samples.SortedVectors.Fbs.UserList? item)
        {
            checked
            {
                return item is null ? null : new Samples.SortedVectors.Fbs.UserList(item);
            }
        }

        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNull("item")]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static global::System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User>? Clone(global::System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User>? item)
        {
            checked
            {
                return VectorCloneHelpers.Clone<Samples.SortedVectors.Fbs.User>(item, FlatSharp.Compiler.Generated.CloneHelpers_1c0922197bc746b2b9f5cd1167ac21e9.Clone);
            }
        }
    }

}

namespace Samples.SortedVectors.Fbs
{
    [FlatBufferTable()]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class User
        : object
    {
#pragma warning disable CS8618
        public User()
        {
            checked
            {
                this.FirstName = default!;
                this.LastName = default!;
                this.SSN = default!;
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected User(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public User(User source)
        {
            checked
            {
                this.FirstName = FlatSharp.Compiler.Generated.CloneHelpers_1c0922197bc746b2b9f5cd1167ac21e9.Clone(source.FirstName);
                this.LastName = FlatSharp.Compiler.Generated.CloneHelpers_1c0922197bc746b2b9f5cd1167ac21e9.Clone(source.LastName);
                this.SSN = FlatSharp.Compiler.Generated.CloneHelpers_1c0922197bc746b2b9f5cd1167ac21e9.Clone(source.SSN);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0)]
        public virtual string? FirstName { get; set; }

        [FlatBufferItemAttribute(1)]
        public virtual string? LastName { get; set; }

        [FlatBufferItemAttribute(2, Key = true, Required = true)]
        public virtual string SSN { get; set; }
    }

}

namespace Samples.SortedVectors.Fbs
{
    [FlatBufferTable()]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class UserList
        : object
        , IFlatBufferSerializable<Samples.SortedVectors.Fbs.UserList>
    {
#pragma warning disable CS8618
        public UserList()
        {
            checked
            {
                this.Users = default!;
                this.OnInitialized(null);
            }
        }

#pragma warning restore CS8618
#pragma warning disable CS8618
        protected UserList(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public UserList(UserList source)
        {
            checked
            {
                this.Users = FlatSharp.Compiler.Generated.CloneHelpers_1c0922197bc746b2b9f5cd1167ac21e9.Clone(source.Users);
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);
        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);


        [FlatBufferItemAttribute(0, SortedVector = true)]
        public virtual IList<Samples.SortedVectors.Fbs.User>? Users { get; set; }
        public static ISerializer<Samples.SortedVectors.Fbs.UserList> Serializer { get; } = new GeneratedSerializer().AsISerializer();

        ISerializer IFlatBufferSerializable.Serializer => Serializer;
        ISerializer<Samples.SortedVectors.Fbs.UserList> IFlatBufferSerializable<Samples.SortedVectors.Fbs.UserList>.Serializer => Serializer;

        #region Serializer for Samples.SortedVectors.Fbs.UserList

        [FlatSharpGeneratedSerializerAttribute(FlatBufferDeserializationOption.GreedyMutable)]
        private sealed class GeneratedSerializer : IGeneratedSerializer<global::Samples.SortedVectors.Fbs.UserList>
        {
            // Method generated to help AOT compilers make good decisions about generics.
            public void __AotHelper()
            {
                checked
                {
                    this.Write<ISpanWriter>(default!, new byte[10], default!, default!, default!);
                    this.Write<SpanWriter>(default!, new byte[10], default!, default!, default!);

                    this.Parse<IInputBuffer>(default!, 0);
                    this.Parse<MemoryInputBuffer>(default!, 0);
                    this.Parse<ReadOnlyMemoryInputBuffer>(default!, 0);
                    this.Parse<ArrayInputBuffer>(default!, 0);
                    this.Parse<ArraySegmentInputBuffer>(default!, 0);

                    throw new InvalidOperationException("__AotHelper is not intended to be invoked");
                }
            }

            public GeneratedSerializer()
            {
                checked
                {
                    string? runtimeVersion = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<System.Reflection.AssemblyFileVersionAttribute>(typeof(SpanWriter).Assembly)?.Version;
                    string compilerVersion = "6.2.1";

                    if (runtimeVersion != compilerVersion)
                    {
                        throw new InvalidOperationException($"FlatSharp runtime version didn't match compiler version. Ensure all FlatSharp NuGet packages use the same version. Runtime = '{runtimeVersion}', Compiler = '{compilerVersion}'.");
                    }

                    if (string.IsNullOrEmpty(runtimeVersion))
                    {
                        throw new InvalidOperationException($"Unable to find FlatSharp.Runtime version. Ensure all FlatSharp NuGet packages use the same version. Runtime = '{runtimeVersion}', Compiler = '{compilerVersion}'.");
                    }
                }
            }

            public FlatSharp.FlatBufferDeserializationOption DeserializationOption => FlatSharp.FlatBufferDeserializationOption.GreedyMutable;


            public void Write<TSpanWriter>(TSpanWriter writer, Span<byte> target, global::Samples.SortedVectors.Fbs.UserList root, int offset, SerializationContext context)
                where TSpanWriter : ISpanWriter
            {
                checked
                {
                    WriteInlineValueOf_90270c54198649b3b554692f140c78a3(writer, target, root, offset, context);
                }
            }

            public int GetMaxSize(global::Samples.SortedVectors.Fbs.UserList root)
            {
                checked
                {
                    return GetMaxSizeOf_90270c54198649b3b554692f140c78a3(root);
                }
            }

            public global::Samples.SortedVectors.Fbs.UserList Parse<TInputBuffer>(TInputBuffer buffer, int offset)
                where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return Read_90270c54198649b3b554692f140c78a3(buffer, offset);
                }
            }

            private static int GetMaxSizeOf_90270c54198649b3b554692f140c78a3(global::Samples.SortedVectors.Fbs.UserList value)
            {
                checked
                {

                    int runningSum = 14 + 7;
                    var index0Value = value.Users;

                    if (!(index0Value is null))
                    {
                        runningSum += GetMaxSizeOf_7384324332bc4eff87e2f15ca124b525(index0Value);
                    }
                    return runningSum;

                }
            }

            private static global::Samples.SortedVectors.Fbs.UserList Read_90270c54198649b3b554692f140c78a3<TInputBuffer>(
                TInputBuffer buffer,
                int offset
                ) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return tableReader_b042e1acc4854cb5a939ed2c2d53fbc7<TInputBuffer>.GetOrCreate(buffer, offset + buffer.ReadUOffset(offset));
                }
            }

            private sealed class tableReader_b042e1acc4854cb5a939ed2c2d53fbc7<TInputBuffer>
                : global::Samples.SortedVectors.Fbs.UserList
                , global::FlatSharp.IFlatBufferDeserializedObject
                where TInputBuffer : IInputBuffer
            {
                private static readonly global::FlatSharp.FlatBufferDeserializationContext __CtorContext
                    = new global::FlatSharp.FlatBufferDeserializationContext(global::FlatSharp.FlatBufferDeserializationOption.GreedyMutable);



                private System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User>? __index0Value;

                public static tableReader_b042e1acc4854cb5a939ed2c2d53fbc7<TInputBuffer> GetOrCreate(TInputBuffer buffer, int offset)
                {
                    checked
                    {

                        var item = new tableReader_b042e1acc4854cb5a939ed2c2d53fbc7<TInputBuffer>(buffer, offset);
                        return item;

                    }
                }

                private tableReader_b042e1acc4854cb5a939ed2c2d53fbc7(TInputBuffer buffer, int offset) : base(__CtorContext)
                {
                    checked
                    {
                        VTable4.Create<TInputBuffer>(buffer, offset, out var vtable);
                        this.__index0Value = ReadIndex0Value(buffer, offset, vtable);
                        base.OnFlatSharpDeserialized(__CtorContext);
                    }
                }

                global::System.Type global::FlatSharp.IFlatBufferDeserializedObject.TableOrStructType => typeof(Samples.SortedVectors.Fbs.UserList);
                global::FlatSharp.FlatBufferDeserializationContext global::FlatSharp.IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;
                global::FlatSharp.IInputBuffer? global::FlatSharp.IFlatBufferDeserializedObject.InputBuffer => null;
                bool global::FlatSharp.IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;


                public override System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User>? Users
                {
                    get
                    {
                        checked
                        {
                            return this.__index0Value;
                        }
                    }

                    set
                    {
                        checked
                        {
                            this.__index0Value = value;
                        }
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User>? ReadIndex0Value(
                    TInputBuffer buffer,
                    int offset,
                    VTable4 vtable)
                {
                    checked
                    {


                        int absoluteLocation;
                        {
                            int relativeOffset = vtable.OffsetOf(buffer, 0);
                            if (relativeOffset == 0)
                            {
                                return null;
                            }

                            absoluteLocation = offset + relativeOffset;
                        }

                        return Read_7384324332bc4eff87e2f15ca124b525(buffer, absoluteLocation, tableMetadata_9f1508c1ff99453280d52a18624ee1ae.Users);
                    }
                }
            }



            private static void WriteInlineValueOf_90270c54198649b3b554692f140c78a3<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                global::Samples.SortedVectors.Fbs.UserList value,
                int offset
                , SerializationContext context
                ) where TSpanWriter : ISpanWriter
            {
                checked
                {

                    int tableStart = context.AllocateSpace(11, sizeof(int));
                    spanWriter.WriteUOffset(span, offset, tableStart);
                    int currentOffset = tableStart + sizeof(int); // skip past vtable soffset_t.

                    int vtableLength = 4;
                    Span<byte> vtable = stackalloc byte[6];

                    var index0Value = value.Users;

                    var index0Offset = tableStart;
                    if (!(index0Value is null))
                    {

                        currentOffset += SerializationHelpers.GetAlignmentError(currentOffset, 4);
                        index0Offset = currentOffset;
                        currentOffset += 4;

                        vtableLength = 6;
                    }

                    spanWriter.WriteUShort(vtable, (ushort)(index0Offset - tableStart), 4);
                    int tableLength = currentOffset - tableStart;
                    context.Offset -= 11 - tableLength;
                    spanWriter.WriteUShort(vtable, (ushort)vtableLength, 0);
                    spanWriter.WriteUShort(vtable, (ushort)tableLength, sizeof(ushort));
                    int vtablePosition = context.FinishVTable(span, vtable.Slice(0, vtableLength));
                    spanWriter.WriteInt(span, tableStart - vtablePosition, tableStart);

                    if (index0Offset != tableStart)
                    {


                        WriteInlineValueOf_7384324332bc4eff87e2f15ca124b525(spanWriter, span, index0Value!, index0Offset, context);

                        context.AddPostSerializeAction(
                            (tempSpan, ctx) =>
                            SortedVectorHelpersInternal.SortVector(
                                tempSpan,
                                index0Offset,
                                2,
                                null,
                                new FlatSharp.Internal.StringSpanComparer(null)));
                    }

                }
            }

            private static class tableMetadata_9f1508c1ff99453280d52a18624ee1ae
            {

                public static readonly TableFieldContext Users = new TableFieldContext(
                    "Samples.SortedVectors.Fbs.UserList.Users",
                    false,
                    false);
            }



            private static int GetMaxSizeOf_7384324332bc4eff87e2f15ca124b525(global::System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User> value)
            {
                checked
                {

                    int count = value.Count;
                    int runningSum = 14;

                    if (value is Samples.SortedVectors.Fbs.User[] array)
                    {

                        for (int i = 0; i < array.Length; i = unchecked(i + 1))
                        {
                            var current = array[i];

                            SerializationHelpers.EnsureNonNull(current);
                            runningSum += GetMaxSizeOf_0c9a16e166f14721bbd6a4c4b646619b(current);
                        }
                    }
                    else if (value is List<Samples.SortedVectors.Fbs.User> realList)
                    {

                        int i;
                        for (i = 0; i < count; i = unchecked(i + 1))
                        {
                            var current = realList[i];

                            SerializationHelpers.EnsureNonNull(current);
                            runningSum += GetMaxSizeOf_0c9a16e166f14721bbd6a4c4b646619b(current);
                        }
                    }
                    else
                    {

                        int i;
                        for (i = 0; i < count; i = unchecked(i + 1))
                        {
                            var current = value[i];

                            SerializationHelpers.EnsureNonNull(current);
                            runningSum += GetMaxSizeOf_0c9a16e166f14721bbd6a4c4b646619b(current);
                        }
                    }

                    return runningSum;
                }
            }

            private static global::System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User> Read_7384324332bc4eff87e2f15ca124b525<TInputBuffer>(
                TInputBuffer buffer,
                int offset
                , TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return (new FlatBufferVector_4490b52f2c3242b19c8d5a928bdecb31<TInputBuffer>(
                    buffer,
                    offset + buffer.ReadUOffset(offset),
                    4,
                    fieldContext)).FlatBufferVectorToList();
                }
            }

            public sealed class FlatBufferVector_4490b52f2c3242b19c8d5a928bdecb31<TInputBuffer> : FlatBufferVector<global::Samples.SortedVectors.Fbs.User, TInputBuffer>
                where TInputBuffer : IInputBuffer
            {
                public FlatBufferVector_4490b52f2c3242b19c8d5a928bdecb31(
                    TInputBuffer memory,
                    int offset,
                    int itemSize,
                    TableFieldContext fieldContext) : base(memory, offset, itemSize, fieldContext)
                {
                    checked
                    {
                    }
                }

                protected override void ParseItem(
                    TInputBuffer memory,
                    int offset,
                    TableFieldContext fieldContext,
                    out global::Samples.SortedVectors.Fbs.User item)
                {
                    checked
                    {
                        item = Read_0c9a16e166f14721bbd6a4c4b646619b(memory, offset);
                    }
                }

                protected override void WriteThrough(global::Samples.SortedVectors.Fbs.User item, Span<byte> data)
                {
                    checked
                    {
                        throw new NotSupportedException("write through is not available for this type");
                    }
                }
            }



            private static void WriteInlineValueOf_7384324332bc4eff87e2f15ca124b525<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                global::System.Collections.Generic.IList<Samples.SortedVectors.Fbs.User> value,
                int offset
                , SerializationContext context
                ) where TSpanWriter : ISpanWriter
            {
                checked
                {

                    int count = value.Count;
                    int vectorOffset = context.AllocateVector(4, count, 4);
                    spanWriter.WriteUOffset(span, offset, vectorOffset);
                    spanWriter.WriteInt(span, count, vectorOffset);
                    vectorOffset += sizeof(int);


                    if (value is Samples.SortedVectors.Fbs.User[] array)
                    {

                        for (int i = 0; i < array.Length; i = unchecked(i + 1))
                        {
                            var current = array[i];

                            SerializationHelpers.EnsureNonNull(current);
                            WriteInlineValueOf_0c9a16e166f14721bbd6a4c4b646619b(spanWriter, span, current, vectorOffset, context);
                            vectorOffset += 4;
                        }
                    }
                    else if (value is List<Samples.SortedVectors.Fbs.User> realList)
                    {

                        int i;
                        for (i = 0; i < count; i = unchecked(i + 1))
                        {
                            var current = realList[i];

                            SerializationHelpers.EnsureNonNull(current);
                            WriteInlineValueOf_0c9a16e166f14721bbd6a4c4b646619b(spanWriter, span, current, vectorOffset, context);
                            vectorOffset += 4;
                        }
                    }
                    else
                    {

                        int i;
                        for (i = 0; i < count; i = unchecked(i + 1))
                        {
                            var current = value[i];

                            SerializationHelpers.EnsureNonNull(current);
                            WriteInlineValueOf_0c9a16e166f14721bbd6a4c4b646619b(spanWriter, span, current, vectorOffset, context);
                            vectorOffset += 4;
                        }
                    }
                }
            }

            private static int GetMaxSizeOf_0c9a16e166f14721bbd6a4c4b646619b(global::Samples.SortedVectors.Fbs.User value)
            {
                checked
                {

                    int runningSum = 28 + 11;
                    var index0Value = value.FirstName;

                    if (!(index0Value is null))
                    {
                        runningSum += GetMaxSizeOf_fda87ba852c8412fab19e1cd7390a4eb(index0Value);
                    }
                    var index1Value = value.LastName;

                    if (!(index1Value is null))
                    {
                        runningSum += GetMaxSizeOf_fda87ba852c8412fab19e1cd7390a4eb(index1Value);
                    }
                    var index2Value = value.SSN;

                    if (!(index2Value is null))
                    {
                        runningSum += GetMaxSizeOf_fda87ba852c8412fab19e1cd7390a4eb(index2Value);
                    }
                    return runningSum;

                }
            }

            private static global::Samples.SortedVectors.Fbs.User Read_0c9a16e166f14721bbd6a4c4b646619b<TInputBuffer>(
                TInputBuffer buffer,
                int offset
                ) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return tableReader_732139d29b784fe9bc796ab45f2410cf<TInputBuffer>.GetOrCreate(buffer, offset + buffer.ReadUOffset(offset));
                }
            }

            private sealed class tableReader_732139d29b784fe9bc796ab45f2410cf<TInputBuffer>
                : global::Samples.SortedVectors.Fbs.User
                , global::FlatSharp.IFlatBufferDeserializedObject
                where TInputBuffer : IInputBuffer
            {
                private static readonly global::FlatSharp.FlatBufferDeserializationContext __CtorContext
                    = new global::FlatSharp.FlatBufferDeserializationContext(global::FlatSharp.FlatBufferDeserializationOption.GreedyMutable);



                private System.String? __index0Value;
                private System.String? __index1Value;
                private System.String __index2Value;

                public static tableReader_732139d29b784fe9bc796ab45f2410cf<TInputBuffer> GetOrCreate(TInputBuffer buffer, int offset)
                {
                    checked
                    {

                        var item = new tableReader_732139d29b784fe9bc796ab45f2410cf<TInputBuffer>(buffer, offset);
                        return item;

                    }
                }

                private tableReader_732139d29b784fe9bc796ab45f2410cf(TInputBuffer buffer, int offset) : base(__CtorContext)
                {
                    checked
                    {
                        VTable4.Create<TInputBuffer>(buffer, offset, out var vtable);
                        this.__index0Value = ReadIndex0Value(buffer, offset, vtable);
                        this.__index1Value = ReadIndex1Value(buffer, offset, vtable);
                        this.__index2Value = ReadIndex2Value(buffer, offset, vtable);
                        base.OnFlatSharpDeserialized(__CtorContext);
                    }
                }

                global::System.Type global::FlatSharp.IFlatBufferDeserializedObject.TableOrStructType => typeof(Samples.SortedVectors.Fbs.User);
                global::FlatSharp.FlatBufferDeserializationContext global::FlatSharp.IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;
                global::FlatSharp.IInputBuffer? global::FlatSharp.IFlatBufferDeserializedObject.InputBuffer => null;
                bool global::FlatSharp.IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;


                public override System.String? FirstName
                {
                    get
                    {
                        checked
                        {
                            return this.__index0Value;
                        }
                    }

                    set
                    {
                        checked
                        {
                            this.__index0Value = value;
                        }
                    }
                }

                public override System.String? LastName
                {
                    get
                    {
                        checked
                        {
                            return this.__index1Value;
                        }
                    }

                    set
                    {
                        checked
                        {
                            this.__index1Value = value;
                        }
                    }
                }

                public override System.String SSN
                {
                    get
                    {
                        checked
                        {
                            return this.__index2Value;
                        }
                    }

                    set
                    {
                        checked
                        {
                            this.__index2Value = value;
                        }
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.String? ReadIndex0Value(
                    TInputBuffer buffer,
                    int offset,
                    VTable4 vtable)
                {
                    checked
                    {


                        int absoluteLocation;
                        {
                            int relativeOffset = vtable.OffsetOf(buffer, 0);
                            if (relativeOffset == 0)
                            {
                                return null;
                            }

                            absoluteLocation = offset + relativeOffset;
                        }

                        return Read_fda87ba852c8412fab19e1cd7390a4eb(buffer, absoluteLocation);
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.String? ReadIndex1Value(
                    TInputBuffer buffer,
                    int offset,
                    VTable4 vtable)
                {
                    checked
                    {


                        int absoluteLocation;
                        {
                            int relativeOffset = vtable.OffsetOf(buffer, 1);
                            if (relativeOffset == 0)
                            {
                                return null;
                            }

                            absoluteLocation = offset + relativeOffset;
                        }

                        return Read_fda87ba852c8412fab19e1cd7390a4eb(buffer, absoluteLocation);
                    }
                }

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                private static System.String ReadIndex2Value(
                    TInputBuffer buffer,
                    int offset,
                    VTable4 vtable)
                {
                    checked
                    {


                        int absoluteLocation;
                        {
                            int relativeOffset = vtable.OffsetOf(buffer, 2);
                            if (relativeOffset == 0)
                            {
                                throw new global::System.IO.InvalidDataException("Table property 'Samples.SortedVectors.Fbs.User.SSN' is marked as required, but was missing from the buffer.");
                            }

                            absoluteLocation = offset + relativeOffset;
                        }

                        return Read_fda87ba852c8412fab19e1cd7390a4eb(buffer, absoluteLocation);
                    }
                }
            }



            private static void WriteInlineValueOf_0c9a16e166f14721bbd6a4c4b646619b<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                global::Samples.SortedVectors.Fbs.User value,
                int offset
                , SerializationContext context
                ) where TSpanWriter : ISpanWriter
            {
                checked
                {

                    int tableStart = context.AllocateSpace(25, sizeof(int));
                    spanWriter.WriteUOffset(span, offset, tableStart);
                    int currentOffset = tableStart + sizeof(int); // skip past vtable soffset_t.

                    int vtableLength = 10;
                    Span<byte> vtable = stackalloc byte[10];

                    var index0Value = value.FirstName;
                    var index1Value = value.LastName;
                    var index2Value = value.SSN;

                    var index2Offset = tableStart;
                    if (!(index2Value is null))
                    {

                        currentOffset += SerializationHelpers.GetAlignmentError(currentOffset, 4);
                        index2Offset = currentOffset;
                        currentOffset += 4;


                    }
                    else
                    {
                        throw new System.InvalidOperationException("Table property 'Samples.SortedVectors.Fbs.User.SSN' is marked as required, but was not set.");
                    }

                    spanWriter.WriteUShort(vtable, (ushort)(index2Offset - tableStart), 8);

                    var index1Offset = tableStart;
                    if (!(index1Value is null))
                    {

                        currentOffset += SerializationHelpers.GetAlignmentError(currentOffset, 4);
                        index1Offset = currentOffset;
                        currentOffset += 4;


                    }

                    spanWriter.WriteUShort(vtable, (ushort)(index1Offset - tableStart), 6);

                    var index0Offset = tableStart;
                    if (!(index0Value is null))
                    {

                        currentOffset += SerializationHelpers.GetAlignmentError(currentOffset, 4);
                        index0Offset = currentOffset;
                        currentOffset += 4;


                    }

                    spanWriter.WriteUShort(vtable, (ushort)(index0Offset - tableStart), 4);
                    int tableLength = currentOffset - tableStart;
                    context.Offset -= 25 - tableLength;
                    spanWriter.WriteUShort(vtable, (ushort)vtableLength, 0);
                    spanWriter.WriteUShort(vtable, (ushort)tableLength, sizeof(ushort));
                    int vtablePosition = context.FinishVTable(span, vtable.Slice(0, vtableLength));
                    spanWriter.WriteInt(span, tableStart - vtablePosition, tableStart);

                    if (index2Offset != tableStart)
                    {


                        WriteInlineValueOf_fda87ba852c8412fab19e1cd7390a4eb(spanWriter, span, index2Value!, index2Offset, context, tableMetadata_3f0452532c024f7ca9b53c1ab8e44855.SSN);

                    }


                    if (index1Offset != tableStart)
                    {


                        WriteInlineValueOf_fda87ba852c8412fab19e1cd7390a4eb(spanWriter, span, index1Value!, index1Offset, context, tableMetadata_3f0452532c024f7ca9b53c1ab8e44855.LastName);

                    }


                    if (index0Offset != tableStart)
                    {


                        WriteInlineValueOf_fda87ba852c8412fab19e1cd7390a4eb(spanWriter, span, index0Value!, index0Offset, context, tableMetadata_3f0452532c024f7ca9b53c1ab8e44855.FirstName);

                    }

                }
            }

            private static class tableMetadata_3f0452532c024f7ca9b53c1ab8e44855
            {

                public static readonly TableFieldContext FirstName = new TableFieldContext(
                    "Samples.SortedVectors.Fbs.User.FirstName",
                    false,
                    false);

                public static readonly TableFieldContext LastName = new TableFieldContext(
                    "Samples.SortedVectors.Fbs.User.LastName",
                    false,
                    false);

                public static readonly TableFieldContext SSN = new TableFieldContext(
                    "Samples.SortedVectors.Fbs.User.SSN",
                    false,
                    false);
            }



            private static int GetMaxSizeOf_fda87ba852c8412fab19e1cd7390a4eb(global::System.String value)
            {
                checked
                {
                    return SerializationHelpers.GetMaxSize(value);
                }
            }

            private static global::System.String Read_fda87ba852c8412fab19e1cd7390a4eb<TInputBuffer>(
                TInputBuffer buffer,
                int offset
                ) where TInputBuffer : IInputBuffer
            {
                checked
                {
                    return buffer.ReadString(offset);
                }
            }

            private static void WriteInlineValueOf_fda87ba852c8412fab19e1cd7390a4eb<TSpanWriter>(
                TSpanWriter spanWriter,
                Span<byte> span,
                global::System.String value,
                int offset
                , SerializationContext context
                , TableFieldContext fieldContext) where TSpanWriter : ISpanWriter
            {
                checked
                {

                    spanWriter.WriteString(
                        span,
                        value,
                        offset,
                        context);

                }
            }
        }

        #endregion
    }

}

