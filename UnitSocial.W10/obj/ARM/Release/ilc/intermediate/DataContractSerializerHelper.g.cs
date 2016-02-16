using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 193
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                13, // array length: 13
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                13, // array length: 13
                690, // index: 690, string: "AppVersion"
                280, // index: 280, string: "BaseConfiguration"
                701, // index: 701, string: "CdnUriFormat"
                714, // index: 714, string: "ConfigId"
                723, // index: 723, string: "FileVersion"
                735, // index: 735, string: "LegacyConfigId"
                750, // index: 750, string: "MarketOverrides"
                766, // index: 766, string: "RefreshRate"
                778, // index: 778, string: "SchemaVersion"
                792, // index: 792, string: "TestConfiguration"
                810, // index: 810, string: "UpdatedDateTime"
                826, // index: 826, string: "UseRoundRobin"
                840, // index: 840, string: "Version"
                13, // array length: 13
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                6, // array length: 6
                848, // index: 848, string: "AdAdapters"
                859, // index: 859, string: "AdControlConfigurations"
                883, // index: 883, string: "ConfigurationUri"
                900, // index: 900, string: "RotationAlgorithm"
                918, // index: 918, string: "UnusedAdAdapters"
                840, // index: 840, string: "Version"
                6, // array length: 6
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                5, // array length: 5
                935, // index: 935, string: "Metadata"
                944, // index: 944, string: "Name"
                949, // index: 949, string: "Rank"
                954, // index: 954, string: "Timeout"
                962, // index: 962, string: "Weight"
                5, // array length: 5
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                2, // array length: 2
                969, // index: 969, string: "Key"
                973, // index: 973, string: "Value"
                2, // array length: 2
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                3, // array length: 3
                848, // index: 848, string: "AdAdapters"
                979, // index: 979, string: "Id"
                944, // index: 944, string: "Name"
                3, // array length: 3
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                7, // array length: 7
                848, // index: 848, string: "AdAdapters"
                859, // index: 859, string: "AdControlConfigurations"
                883, // index: 883, string: "ConfigurationUri"
                900, // index: 900, string: "RotationAlgorithm"
                918, // index: 918, string: "UnusedAdAdapters"
                840, // index: 840, string: "Version"
                982, // index: 982, string: "Region"
                7, // array length: 7
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                2, // array length: 2
                989, // index: 989, string: "AdMediatorDeviceId"
                555, // index: 555, string: "ConfigFileState"
                2, // array length: 2
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                1008, // index: 1008, string: "ActiveConfigStorageFolder"
                571, // index: 571, string: "FileFetchInformation"
                1034, // index: 1034, string: "LastKnownGoodConfigStorageFolder"
                3, // array length: 3
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                1067, // index: 1067, string: "LastAttemptedFetch"
                1086, // index: 1086, string: "LastSuccessfulFetch"
                1106, // index: 1106, string: "WasLastAttemptSuccessful"
                3, // array length: 3
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                3, // array length: 3
                1131, // index: 1131, string: "ErrorCode"
                1141, // index: 1141, string: "ErrorText"
                944, // index: 944, string: "Name"
                3, // array length: 3
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279  // index: 279, string: ""
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContractMap_Hashtable = new byte[0];
        // Count=53
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdMediatorConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.BaseConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                " PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                "licKeyToken=31bf3856ad364e35")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                " PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                "tral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                "l, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.PersistentParameters, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.ConfigFileState, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral" +
                                ", PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.FileFetchInformation, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                "yToken=31bf3856ad364e35")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContracts_Hashtable = new byte[0];
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_classDataContracts_Hashtable = new byte[0];
        // Count=10
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // AdMediatorConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 255, // AdMediatorConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 255, // AdMediatorConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdMediatorConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdMediatorConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadAdMediatorConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteAdMediatorConfigurationToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 15,
                    MemberNamesListIndex = 17,
                    MemberNamespacesListIndex = 31,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 280, // BaseConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 280, // BaseConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 280, // BaseConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.BaseConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.BaseConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type2.ReadBaseConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type3.WriteBaseConfigurationToXml),
                    ChildElementNamespacesListIndex = 45,
                    ContractNamespacesListIndex = 52,
                    MemberNamesListIndex = 54,
                    MemberNamespacesListIndex = 61,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 319, // AdAdapterInfo
                        NamespaceIndex = 279, // 
                        StableNameIndex = 319, // AdAdapterInfo
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 319, // AdAdapterInfo
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type7.ReadAdAdapterInfoFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type8.WriteAdAdapterInfoToXml),
                    ChildElementNamespacesListIndex = 68,
                    ContractNamespacesListIndex = 74,
                    MemberNamesListIndex = 76,
                    MemberNamespacesListIndex = 82,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 349, // Property
                        NamespaceIndex = 279, // 
                        StableNameIndex = 349, // Property
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 349, // Property
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WritePropertyToXml),
                    ChildElementNamespacesListIndex = 88,
                    ContractNamespacesListIndex = 91,
                    MemberNamesListIndex = 93,
                    MemberNamespacesListIndex = 96,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 388, // AdControlConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 388, // AdControlConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 388, // AdControlConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                    "tral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                    "tral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type17.ReadAdControlConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type18.WriteAdControlConfigurationToXml),
                    ChildElementNamespacesListIndex = 99,
                    ContractNamespacesListIndex = 103,
                    MemberNamesListIndex = 105,
                    MemberNamespacesListIndex = 109,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // MarketConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 438, // MarketConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 438, // MarketConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                    "l, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                    "l, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type22.ReadMarketConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type23.WriteMarketConfigurationToXml),
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 121,
                    MemberNamesListIndex = 124,
                    MemberNamespacesListIndex = 132,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 458, // PersistentParameters
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        StableNameIndex = 458, // PersistentParameters
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        TopLevelElementNameIndex = 458, // PersistentParameters
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.PersistentParameters, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.PersistentParameters, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type24.ReadPersistentParametersFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type25.WritePersistentParametersToXml),
                    ChildElementNamespacesListIndex = 140,
                    ContractNamespacesListIndex = 143,
                    MemberNamesListIndex = 145,
                    MemberNamespacesListIndex = 148,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 555, // ConfigFileState
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        StableNameIndex = 555, // ConfigFileState
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        TopLevelElementNameIndex = 555, // ConfigFileState
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.ConfigFileState, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral" +
                                    ", PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.ConfigFileState, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral" +
                                    ", PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type26.ReadConfigFileStateFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type27.WriteConfigFileStateToXml),
                    ChildElementNamespacesListIndex = 151,
                    ContractNamespacesListIndex = 155,
                    MemberNamesListIndex = 157,
                    MemberNamespacesListIndex = 161,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 571, // FileFetchInformation
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        StableNameIndex = 571, // FileFetchInformation
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        TopLevelElementNameIndex = 571, // FileFetchInformation
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.FileFetchInformation, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.FileFetchInformation, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type28.ReadFileFetchInformationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type29.WriteFileFetchInformationToXml),
                    ChildElementNamespacesListIndex = 165,
                    ContractNamespacesListIndex = 169,
                    MemberNamesListIndex = 171,
                    MemberNamespacesListIndex = 175,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 608, // SdkError
                        NamespaceIndex = 279, // 
                        StableNameIndex = 608, // SdkError
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 608, // SdkError
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                    "yToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                    "yToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 179,
                    ContractNamespacesListIndex = 183,
                    MemberNamesListIndex = 185,
                    MemberNamespacesListIndex = 189,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_collectionDataContracts_Hashtable = new byte[0];
        // Count=6
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 298, // ArrayOfAdAdapterInfo
                        NamespaceIndex = 279, // 
                        StableNameIndex = 298, // ArrayOfAdAdapterInfo
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 298, // ArrayOfAdAdapterInfo
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type4.ReadArrayOfAdAdapterInfoFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type5.WriteArrayOfAdAdapterInfoToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type6.ReadArrayOfAdAdapterInfoFromXmlIsGetOnly),
                    CollectionItemNameIndex = 319, // AdAdapterInfo
                    KeyNameIndex = -1,
                    ItemNameIndex = 319, // AdAdapterInfo
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                "licKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 333, // ArrayOfProperty
                        NamespaceIndex = 279, // 
                        StableNameIndex = 333, // ArrayOfProperty
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 333, // ArrayOfProperty
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type9.ReadArrayOfPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type10.WriteArrayOfPropertyToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type11.ReadArrayOfPropertyFromXmlIsGetOnly),
                    CollectionItemNameIndex = 349, // Property
                    KeyNameIndex = -1,
                    ItemNameIndex = 349, // Property
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                " PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 358, // ArrayOfAdControlConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 358, // ArrayOfAdControlConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 358, // ArrayOfAdControlConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type14.ReadArrayOfAdControlConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type15.WriteArrayOfAdControlConfigurationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type16.ReadArrayOfAdControlConfigurationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 388, // AdControlConfiguration
                    KeyNameIndex = -1,
                    ItemNameIndex = 388, // AdControlConfiguration
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                "tral, PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 411, // ArrayOfMarketConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 411, // ArrayOfMarketConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 411, // ArrayOfMarketConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type19.ReadArrayOfMarketConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type20.WriteArrayOfMarketConfigurationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type21.ReadArrayOfMarketConfigurationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 438, // MarketConfiguration
                    KeyNameIndex = -1,
                    ItemNameIndex = 438, // MarketConfiguration
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                "l, PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 592, // ArrayOfSdkError
                        NamespaceIndex = 279, // 
                        StableNameIndex = 592, // ArrayOfSdkError
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 592, // ArrayOfSdkError
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 608, // SdkError
                    KeyNameIndex = -1,
                    ItemNameIndex = 608, // SdkError
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                "yToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 617, // ArrayOfanyType
                        NamespaceIndex = 632, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 617, // ArrayOfanyType
                        StableNameNamespaceIndex = 632, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 617, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 632, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_enumDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_xmlDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_jsonDelegatesList_Hashtable = new byte[0];
        // Count=3
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type33.WriteArrayOfSdkErrorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type32.ReadArrayOfSdkErrorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type37.WriteSdkErrorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type36.ReadSdkErrorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type42.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type41.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type43.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','d','M','e','d','i','a','t','o','r','C','o','n','f','i',
            'g','u','r','a','t','i','o','n','\0','\0','B','a','s','e','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','A','r',
            'r','a','y','O','f','A','d','A','d','a','p','t','e','r','I','n','f','o','\0','A','d','A','d','a','p','t','e','r','I','n',
            'f','o','\0','A','r','r','a','y','O','f','P','r','o','p','e','r','t','y','\0','P','r','o','p','e','r','t','y','\0','A','r',
            'r','a','y','O','f','A','d','C','o','n','t','r','o','l','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','A','d',
            'C','o','n','t','r','o','l','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','A','r','r','a','y','O','f','M','a',
            'r','k','e','t','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','M','a','r','k','e','t','C','o','n','f','i','g',
            'u','r','a','t','i','o','n','\0','P','e','r','s','i','s','t','e','n','t','P','a','r','a','m','e','t','e','r','s','\0','h',
            't','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g',
            '/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','A','d','M','e','d','i','a','t','o','r','.',
            'C','o','r','e','.','U','t','i','l','i','t','i','e','s','\0','C','o','n','f','i','g','F','i','l','e','S','t','a','t','e',
            '\0','F','i','l','e','F','e','t','c','h','I','n','f','o','r','m','a','t','i','o','n','\0','A','r','r','a','y','O','f','S',
            'd','k','E','r','r','o','r','\0','S','d','k','E','r','r','o','r','\0','A','r','r','a','y','O','f','a','n','y','T','y','p',
            'e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m',
            '/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0',
            'A','p','p','V','e','r','s','i','o','n','\0','C','d','n','U','r','i','F','o','r','m','a','t','\0','C','o','n','f','i','g',
            'I','d','\0','F','i','l','e','V','e','r','s','i','o','n','\0','L','e','g','a','c','y','C','o','n','f','i','g','I','d','\0',
            'M','a','r','k','e','t','O','v','e','r','r','i','d','e','s','\0','R','e','f','r','e','s','h','R','a','t','e','\0','S','c',
            'h','e','m','a','V','e','r','s','i','o','n','\0','T','e','s','t','C','o','n','f','i','g','u','r','a','t','i','o','n','\0',
            'U','p','d','a','t','e','d','D','a','t','e','T','i','m','e','\0','U','s','e','R','o','u','n','d','R','o','b','i','n','\0',
            'V','e','r','s','i','o','n','\0','A','d','A','d','a','p','t','e','r','s','\0','A','d','C','o','n','t','r','o','l','C','o',
            'n','f','i','g','u','r','a','t','i','o','n','s','\0','C','o','n','f','i','g','u','r','a','t','i','o','n','U','r','i','\0',
            'R','o','t','a','t','i','o','n','A','l','g','o','r','i','t','h','m','\0','U','n','u','s','e','d','A','d','A','d','a','p',
            't','e','r','s','\0','M','e','t','a','d','a','t','a','\0','N','a','m','e','\0','R','a','n','k','\0','T','i','m','e','o','u',
            't','\0','W','e','i','g','h','t','\0','K','e','y','\0','V','a','l','u','e','\0','I','d','\0','R','e','g','i','o','n','\0','A',
            'd','M','e','d','i','a','t','o','r','D','e','v','i','c','e','I','d','\0','A','c','t','i','v','e','C','o','n','f','i','g',
            'S','t','o','r','a','g','e','F','o','l','d','e','r','\0','L','a','s','t','K','n','o','w','n','G','o','o','d','C','o','n',
            'f','i','g','S','t','o','r','a','g','e','F','o','l','d','e','r','\0','L','a','s','t','A','t','t','e','m','p','t','e','d',
            'F','e','t','c','h','\0','L','a','s','t','S','u','c','c','e','s','s','f','u','l','F','e','t','c','h','\0','W','a','s','L',
            'a','s','t','A','t','t','e','m','p','t','S','u','c','c','e','s','s','f','u','l','\0','E','r','r','o','r','C','o','d','e',
            '\0','E','r','r','o','r','T','e','x','t','\0'};
    }
}
