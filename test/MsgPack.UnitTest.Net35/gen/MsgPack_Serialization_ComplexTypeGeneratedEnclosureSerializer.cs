﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8689
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeGeneratedEnclosureSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeGeneratedEnclosure> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeGenerated> _serializer1;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, string> this_SetUnpackedValueOfNameDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, MsgPack.Serialization.ComplexTypeGenerated> this_SetUnpackedValueOfNestedDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeGeneratedEnclosureSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<MsgPack.Serialization.ComplexTypeGenerated>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>[2];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>(this.PackValueOfName);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>(this.PackValueOfNested);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>>(2);
            packOperationTable["Name"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>(this.PackValueOfName);
            packOperationTable["Nested"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure>(this.PackValueOfNested);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, bool>>(2);
            nullCheckerTable["Name"] = new System.Func<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, bool>(this.IsNameNull);
            nullCheckerTable["Nested"] = new System.Func<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, bool>(this.IsNestedNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>[2];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>(this.UnpackValueOfName);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>(this.UnpackValueOfNested);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>>(2);
            unpackOperationTable["Name"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>(this.UnpackValueOfName);
            unpackOperationTable["Nested"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure, int, int>(this.UnpackValueOfNested);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Name",
                    "Nested"};
            this.this_SetUnpackedValueOfNameDelegate = new System.Action<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, string>(this.SetUnpackedValueOfName);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.this_SetUnpackedValueOfNestedDelegate = new System.Action<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, MsgPack.Serialization.ComplexTypeGenerated>(this.SetUnpackedValueOfNested);
        }
        
        private void PackValueOfName(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure objectTree) {
            this._serializer0.PackTo(packer, objectTree.Name);
        }
        
        private bool IsNameNull(MsgPack.Serialization.ComplexTypeGeneratedEnclosure objectTree) {
            return (objectTree.Name == null);
        }
        
        private void PackValueOfNested(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure objectTree) {
            this._serializer1.PackTo(packer, objectTree.Nested);
        }
        
        private bool IsNestedNull(MsgPack.Serialization.ComplexTypeGeneratedEnclosure objectTree) {
            return (objectTree.Nested == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfName(MsgPack.Serialization.ComplexTypeGeneratedEnclosure unpackingContext, string unpackedValue) {
            unpackingContext.Name = unpackedValue;
        }
        
        private void UnpackValueOfName(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, string> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, string>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(string);
            unpackHelperParameters.MemberName = "Name";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfNameDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfNested(MsgPack.Serialization.ComplexTypeGeneratedEnclosure unpackingContext, MsgPack.Serialization.ComplexTypeGenerated unpackedValue) {
            unpackingContext.Nested = unpackedValue;
        }
        
        private void UnpackValueOfNested(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeGeneratedEnclosure unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, MsgPack.Serialization.ComplexTypeGenerated> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeGeneratedEnclosure, MsgPack.Serialization.ComplexTypeGenerated>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(MsgPack.Serialization.ComplexTypeGenerated);
            unpackHelperParameters0.MemberName = "Nested";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfNestedDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeGeneratedEnclosure UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeGeneratedEnclosure result = default(MsgPack.Serialization.ComplexTypeGeneratedEnclosure);
            result = new MsgPack.Serialization.ComplexTypeGeneratedEnclosure();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeGeneratedEnclosure>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeGeneratedEnclosure>(), this._unpackOperationTable);
            }
        }
    }
}
