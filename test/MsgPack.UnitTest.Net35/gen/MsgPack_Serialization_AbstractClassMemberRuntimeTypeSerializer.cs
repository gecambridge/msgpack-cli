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
    public class MsgPack_Serialization_AbstractClassMemberRuntimeTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AbstractClassMemberRuntimeType> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AbstractFileSystemEntry> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.AbstractClassMemberRuntimeType, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.AbstractClassMemberRuntimeType, MsgPack.Serialization.AbstractFileSystemEntry> this_SetUnpackedValueOfValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_AbstractClassMemberRuntimeTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.AbstractFileSystemEntry));
            this._serializer0 = context.GetSerializer<MsgPack.Serialization.AbstractFileSystemEntry>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassMemberRuntimeType>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.AbstractClassMemberRuntimeType, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.AbstractClassMemberRuntimeType, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.AbstractClassMemberRuntimeType, bool>>(1);
            nullCheckerTable["Value"] = new System.Func<MsgPack.Serialization.AbstractClassMemberRuntimeType, bool>(this.IsValueNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
            this.this_SetUnpackedValueOfValueDelegate = new System.Action<MsgPack.Serialization.AbstractClassMemberRuntimeType, MsgPack.Serialization.AbstractFileSystemEntry>(this.SetUnpackedValueOfValue);
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.AbstractClassMemberRuntimeType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        private bool IsValueNull(MsgPack.Serialization.AbstractClassMemberRuntimeType objectTree) {
            return (objectTree.Value == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.AbstractClassMemberRuntimeType objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.AbstractClassMemberRuntimeType> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.AbstractClassMemberRuntimeType>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.AbstractClassMemberRuntimeType> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.AbstractClassMemberRuntimeType>);
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
        
        private void SetUnpackedValueOfValue(MsgPack.Serialization.AbstractClassMemberRuntimeType unpackingContext, MsgPack.Serialization.AbstractFileSystemEntry unpackedValue) {
            unpackingContext.Value = unpackedValue;
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.AbstractClassMemberRuntimeType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.AbstractClassMemberRuntimeType, MsgPack.Serialization.AbstractFileSystemEntry> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.AbstractClassMemberRuntimeType, MsgPack.Serialization.AbstractFileSystemEntry>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(MsgPack.Serialization.AbstractFileSystemEntry);
            unpackHelperParameters.MemberName = "Value";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfValueDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.AbstractClassMemberRuntimeType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.AbstractClassMemberRuntimeType result = default(MsgPack.Serialization.AbstractClassMemberRuntimeType);
            result = new MsgPack.Serialization.AbstractClassMemberRuntimeType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.AbstractClassMemberRuntimeType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.AbstractClassMemberRuntimeType>(), this._unpackOperationTable);
            }
        }
    }
}
