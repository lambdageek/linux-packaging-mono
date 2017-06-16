// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Xml.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Xml.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Xml.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Data.SqlXml, PublicKey=00000000000000000400000000000000")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.ServiceModel.Friend, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Xml.Linq, PublicKey=00000000000000000400000000000000")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Xml.Linq, PublicKey=00000000000000000400000000000000", AllInternalsVisible=false)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.Xml
{
    public enum ConformanceLevel
    {
        Auto = 0,
        Document = 2,
        Fragment = 1,
    }
    public enum DtdProcessing
    {
        Ignore = 1,
        Parse = 2,
        Prohibit = 0,
    }
    public enum EntityHandling
    {
        ExpandCharEntities = 2,
        ExpandEntities = 1,
    }
    public enum Formatting
    {
        Indented = 1,
        None = 0,
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial interface IApplicationResourceStreamResolver
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        System.IO.Stream GetApplicationResourceStream(System.Uri relativeUri);
    }
    public partial interface IHasXmlNode
    {
        System.Xml.XmlNode GetNode();
    }
    public partial interface IXmlLineInfo
    {
        int LineNumber { get; }
        int LinePosition { get; }
        bool HasLineInfo();
    }
    public partial interface IXmlNamespaceResolver
    {
        System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
        string LookupNamespace(string prefix);
        string LookupPrefix(string namespaceName);
    }
    [System.FlagsAttribute]
    public enum NamespaceHandling
    {
        Default = 0,
        OmitDuplicates = 1,
    }
    public partial class NameTable : System.Xml.XmlNameTable
    {
        public NameTable() { }
        public override string Add(char[] key, int start, int len) { throw null; }
        public override string Add(string key) { throw null; }
        public override string Get(char[] key, int start, int len) { throw null; }
        public override string Get(string value) { throw null; }
    }
    public enum NewLineHandling
    {
        Entitize = 1,
        None = 2,
        Replace = 0,
    }
    public enum ReadState
    {
        Closed = 4,
        EndOfFile = 3,
        Error = 2,
        Initial = 0,
        Interactive = 1,
    }
    public enum ValidationType
    {
        [System.ObsoleteAttribute("Validation type should be specified as DTD or Schema.")]
        Auto = 1,
        DTD = 2,
        None = 0,
        Schema = 4,
        [System.ObsoleteAttribute("XDR Validation through XmlValidatingReader is obsoleted")]
        XDR = 3,
    }
    public enum WhitespaceHandling
    {
        All = 0,
        None = 2,
        Significant = 1,
    }
    public enum WriteState
    {
        Attribute = 3,
        Closed = 5,
        Content = 4,
        Element = 2,
        Error = 6,
        Prolog = 1,
        Start = 0,
    }
    public partial class XmlAttribute : System.Xml.XmlNode
    {
        protected internal XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc) { }
        public override string BaseURI { get { throw null; } }
        public override string InnerText { set { } }
        public override string InnerXml { set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public virtual System.Xml.XmlElement OwnerElement { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override string Prefix { get { throw null; } set { } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public virtual bool Specified { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { throw null; }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public override System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public override System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { throw null; }
        public override System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { throw null; }
        public override System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public sealed partial class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal XmlAttributeCollection() { }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Xml.XmlAttribute this[int i] { get { throw null; } }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Xml.XmlAttribute this[string name] { get { throw null; } }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Xml.XmlAttribute this[string localName, string namespaceURI] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node) { throw null; }
        public void CopyTo(System.Xml.XmlAttribute[] array, int index) { }
        public System.Xml.XmlAttribute InsertAfter(System.Xml.XmlAttribute newNode, System.Xml.XmlAttribute refNode) { throw null; }
        public System.Xml.XmlAttribute InsertBefore(System.Xml.XmlAttribute newNode, System.Xml.XmlAttribute refNode) { throw null; }
        public System.Xml.XmlAttribute Prepend(System.Xml.XmlAttribute node) { throw null; }
        public System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node) { throw null; }
        public void RemoveAll() { }
        public System.Xml.XmlAttribute RemoveAt(int i) { throw null; }
        public override System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    public partial class XmlCDataSection : System.Xml.XmlCharacterData
    {
        protected internal XmlCDataSection(string data, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public abstract partial class XmlCharacterData : System.Xml.XmlLinkedNode
    {
        protected internal XmlCharacterData(string data, System.Xml.XmlDocument doc) { }
        public virtual string Data { get { throw null; } set { } }
        public override string InnerText { get { throw null; } set { } }
        public virtual int Length { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public virtual void AppendData(string strData) { }
        public virtual void DeleteData(int offset, int count) { }
        public virtual void InsertData(int offset, string strData) { }
        public virtual void ReplaceData(int offset, int count, string strData) { }
        public virtual string Substring(int offset, int count) { throw null; }
    }
    public partial class XmlComment : System.Xml.XmlCharacterData
    {
        protected internal XmlComment(string comment, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlConvert
    {
        public XmlConvert() { }
        public static string DecodeName(string name) { throw null; }
        public static string EncodeLocalName(string name) { throw null; }
        public static string EncodeName(string name) { throw null; }
        public static string EncodeNmToken(string name) { throw null; }
        public static bool IsNCNameChar(char ch) { throw null; }
        public static bool IsPublicIdChar(char ch) { throw null; }
        public static bool IsStartNCNameChar(char ch) { throw null; }
        public static bool IsWhitespaceChar(char ch) { throw null; }
        public static bool IsXmlChar(char ch) { throw null; }
        public static bool IsXmlSurrogatePair(char lowChar, char highChar) { throw null; }
        public static bool ToBoolean(string s) { throw null; }
        public static byte ToByte(string s) { throw null; }
        public static char ToChar(string s) { throw null; }
        [System.ObsoleteAttribute("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
        public static System.DateTime ToDateTime(string s) { throw null; }
        public static System.DateTime ToDateTime(string s, string format) { throw null; }
        public static System.DateTime ToDateTime(string s, string[] formats) { throw null; }
        public static System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { throw null; }
        public static System.DateTimeOffset ToDateTimeOffset(string s) { throw null; }
        public static System.DateTimeOffset ToDateTimeOffset(string s, string format) { throw null; }
        public static System.DateTimeOffset ToDateTimeOffset(string s, string[] formats) { throw null; }
        public static decimal ToDecimal(string s) { throw null; }
        public static double ToDouble(string s) { throw null; }
        public static System.Guid ToGuid(string s) { throw null; }
        public static short ToInt16(string s) { throw null; }
        public static int ToInt32(string s) { throw null; }
        public static long ToInt64(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string s) { throw null; }
        public static float ToSingle(string s) { throw null; }
        public static string ToString(bool value) { throw null; }
        public static string ToString(byte value) { throw null; }
        public static string ToString(char value) { throw null; }
        [System.ObsoleteAttribute("Use XmlConvert.ToString() that takes in XmlDateTimeSerializationMode")]
        public static string ToString(System.DateTime value) { throw null; }
        public static string ToString(System.DateTime value, string format) { throw null; }
        public static string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { throw null; }
        public static string ToString(System.DateTimeOffset value) { throw null; }
        public static string ToString(System.DateTimeOffset value, string format) { throw null; }
        public static string ToString(decimal value) { throw null; }
        public static string ToString(double value) { throw null; }
        public static string ToString(System.Guid value) { throw null; }
        public static string ToString(short value) { throw null; }
        public static string ToString(int value) { throw null; }
        public static string ToString(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value) { throw null; }
        public static string ToString(float value) { throw null; }
        public static string ToString(System.TimeSpan value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value) { throw null; }
        public static System.TimeSpan ToTimeSpan(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string s) { throw null; }
        public static string VerifyName(string name) { throw null; }
        public static string VerifyNCName(string name) { throw null; }
        public static string VerifyNMTOKEN(string name) { throw null; }
        public static string VerifyPublicId(string publicId) { throw null; }
        public static string VerifyTOKEN(string token) { throw null; }
        public static string VerifyWhitespace(string content) { throw null; }
        public static string VerifyXmlChars(string content) { throw null; }
    }
    public enum XmlDateTimeSerializationMode
    {
        Local = 0,
        RoundtripKind = 3,
        Unspecified = 2,
        Utc = 1,
    }
    public partial class XmlDeclaration : System.Xml.XmlLinkedNode
    {
        protected internal XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc) { }
        public string Encoding { get { throw null; } set { } }
        public override string InnerText { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public string Standalone { get { throw null; } set { } }
        public override string Value { get { throw null; } set { } }
        public string Version { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlDocument : System.Xml.XmlNode
    {
        public XmlDocument() { }
        protected internal XmlDocument(System.Xml.XmlImplementation imp) { }
        public XmlDocument(System.Xml.XmlNameTable nt) { }
        public override string BaseURI { get { throw null; } }
        public System.Xml.XmlElement DocumentElement { get { throw null; } }
        public virtual System.Xml.XmlDocumentType DocumentType { get { throw null; } }
        public System.Xml.XmlImplementation Implementation { get { throw null; } }
        public override string InnerText { set { } }
        public override string InnerXml { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public bool PreserveWhitespace { get { throw null; } set { } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public System.Xml.Schema.XmlSchemaSet Schemas { get { throw null; } set { } }
        public virtual System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeChanged { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeChanging { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeInserted { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeInserting { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeRemoved { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeRemoving { add { } remove { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public System.Xml.XmlAttribute CreateAttribute(string name) { throw null; }
        public System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlCDataSection CreateCDataSection(string data) { throw null; }
        public virtual System.Xml.XmlComment CreateComment(string data) { throw null; }
        protected internal virtual System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlDocumentFragment CreateDocumentFragment() { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        public virtual System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { throw null; }
        public System.Xml.XmlElement CreateElement(string name) { throw null; }
        public System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlEntityReference CreateEntityReference(string name) { throw null; }
        public override System.Xml.XPath.XPathNavigator CreateNavigator() { throw null; }
        protected internal virtual System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node) { throw null; }
        public virtual System.Xml.XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string prefix, string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { throw null; }
        public virtual System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text) { throw null; }
        public virtual System.Xml.XmlText CreateTextNode(string text) { throw null; }
        public virtual System.Xml.XmlWhitespace CreateWhitespace(string text) { throw null; }
        public virtual System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { throw null; }
        public virtual System.Xml.XmlElement GetElementById(string elementId) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode ImportNode(System.Xml.XmlNode node, bool deep) { throw null; }
        public virtual void Load(System.IO.Stream inStream) { }
        public virtual void Load(System.IO.TextReader txtReader) { }
        public virtual void Load(string filename) { }
        public virtual void Load(System.Xml.XmlReader reader) { }
        public virtual void LoadXml(string xml) { }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        public virtual System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader) { throw null; }
        public virtual void Save(System.IO.Stream outStream) { }
        public virtual void Save(System.IO.TextWriter writer) { }
        public virtual void Save(string filename) { }
        public virtual void Save(System.Xml.XmlWriter w) { }
        public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNode nodeToValidate) { }
        public override void WriteContentTo(System.Xml.XmlWriter xw) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlDocumentFragment : System.Xml.XmlNode
    {
        protected internal XmlDocumentFragment(System.Xml.XmlDocument ownerDocument) { }
        public override string InnerXml { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlDocumentType : System.Xml.XmlLinkedNode
    {
        protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc) { }
        public System.Xml.XmlNamedNodeMap Entities { get { throw null; } }
        public string InternalSubset { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public System.Xml.XmlNamedNodeMap Notations { get { throw null; } }
        public string PublicId { get { throw null; } }
        public string SystemId { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlElement : System.Xml.XmlLinkedNode
    {
        protected internal XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc) { }
        public override System.Xml.XmlAttributeCollection Attributes { get { throw null; } }
        public virtual bool HasAttributes { get { throw null; } }
        public override string InnerText { get { throw null; } set { } }
        public override string InnerXml { get { throw null; } set { } }
        public bool IsEmpty { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNode NextSibling { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override string Prefix { get { throw null; } set { } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public virtual string GetAttribute(string name) { throw null; }
        public virtual string GetAttribute(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute GetAttributeNode(string name) { throw null; }
        public virtual System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) { throw null; }
        public virtual bool HasAttribute(string name) { throw null; }
        public virtual bool HasAttribute(string localName, string namespaceURI) { throw null; }
        public override void RemoveAll() { }
        public virtual void RemoveAllAttributes() { }
        public virtual void RemoveAttribute(string name) { }
        public virtual void RemoveAttribute(string localName, string namespaceURI) { }
        public virtual System.Xml.XmlNode RemoveAttributeAt(int i) { throw null; }
        public virtual System.Xml.XmlAttribute RemoveAttributeNode(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute RemoveAttributeNode(System.Xml.XmlAttribute oldAttr) { throw null; }
        public virtual void SetAttribute(string name, string value) { }
        public virtual string SetAttribute(string localName, string namespaceURI, string value) { throw null; }
        public virtual System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlEntity : System.Xml.XmlNode
    {
        internal XmlEntity() { }
        public override string BaseURI { get { throw null; } }
        public override string InnerText { get { throw null; } set { } }
        public override string InnerXml { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public string NotationName { get { throw null; } }
        public override string OuterXml { get { throw null; } }
        public string PublicId { get { throw null; } }
        public string SystemId { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlEntityReference : System.Xml.XmlLinkedNode
    {
        protected internal XmlEntityReference(string name, System.Xml.XmlDocument doc) { }
        public override string BaseURI { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    [System.SerializableAttribute]
    public partial class XmlException : System.SystemException
    {
        public XmlException() { }
        protected XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlException(string message) { }
        public XmlException(string message, System.Exception innerException) { }
        public XmlException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string Message { get { throw null; } }
        public string SourceUri { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class XmlImplementation
    {
        public XmlImplementation() { }
        public XmlImplementation(System.Xml.XmlNameTable nt) { }
        public virtual System.Xml.XmlDocument CreateDocument() { throw null; }
        public bool HasFeature(string strFeature, string strVersion) { throw null; }
    }
    public abstract partial class XmlLinkedNode : System.Xml.XmlNode
    {
        internal XmlLinkedNode() { }
        public override System.Xml.XmlNode NextSibling { get { throw null; } }
        public override System.Xml.XmlNode PreviousSibling { get { throw null; } }
    }
    public partial class XmlNamedNodeMap : System.Collections.IEnumerable
    {
        internal XmlNamedNodeMap() { }
        public virtual int Count { get { throw null; } }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual System.Xml.XmlNode GetNamedItem(string name) { throw null; }
        public virtual System.Xml.XmlNode GetNamedItem(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode Item(int index) { throw null; }
        public virtual System.Xml.XmlNode RemoveNamedItem(string name) { throw null; }
        public virtual System.Xml.XmlNode RemoveNamedItem(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { throw null; }
    }
    public partial class XmlNamespaceManager : System.Collections.IEnumerable, System.Xml.IXmlNamespaceResolver
    {
        public XmlNamespaceManager(System.Xml.XmlNameTable nameTable) { }
        public virtual string DefaultNamespace { get { throw null; } }
        public virtual System.Xml.XmlNameTable NameTable { get { throw null; } }
        public virtual void AddNamespace(string prefix, string uri) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        public virtual bool HasNamespace(string prefix) { throw null; }
        public virtual string LookupNamespace(string prefix) { throw null; }
        public virtual string LookupPrefix(string uri) { throw null; }
        public virtual bool PopScope() { throw null; }
        public virtual void PushScope() { }
        public virtual void RemoveNamespace(string prefix, string uri) { }
    }
    public enum XmlNamespaceScope
    {
        All = 0,
        ExcludeXml = 1,
        Local = 2,
    }
    public abstract partial class XmlNameTable
    {
        protected XmlNameTable() { }
        public abstract string Add(char[] array, int offset, int length);
        public abstract string Add(string array);
        public abstract string Get(char[] array, int offset, int length);
        public abstract string Get(string array);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{debuggerDisplayProxy}")]
    public abstract partial class XmlNode : System.Collections.IEnumerable, System.ICloneable, System.Xml.XPath.IXPathNavigable
    {
        internal XmlNode() { }
        public virtual System.Xml.XmlAttributeCollection Attributes { get { throw null; } }
        public virtual string BaseURI { get { throw null; } }
        public virtual System.Xml.XmlNodeList ChildNodes { get { throw null; } }
        public virtual System.Xml.XmlNode FirstChild { get { throw null; } }
        public virtual bool HasChildNodes { get { throw null; } }
        public virtual string InnerText { get { throw null; } set { } }
        public virtual string InnerXml { get { throw null; } set { } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Xml.XmlElement this[string name] { get { throw null; } }
        public virtual System.Xml.XmlElement this[string localname, string ns] { get { throw null; } }
        public virtual System.Xml.XmlNode LastChild { get { throw null; } }
        public abstract string LocalName { get; }
        public abstract string Name { get; }
        public virtual string NamespaceURI { get { throw null; } }
        public virtual System.Xml.XmlNode NextSibling { get { throw null; } }
        public abstract System.Xml.XmlNodeType NodeType { get; }
        public virtual string OuterXml { get { throw null; } }
        public virtual System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public virtual System.Xml.XmlNode ParentNode { get { throw null; } }
        public virtual string Prefix { get { throw null; } set { } }
        public virtual System.Xml.XmlNode PreviousSibling { get { throw null; } }
        public virtual System.Xml.XmlNode PreviousText { get { throw null; } }
        public virtual System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public virtual string Value { get { throw null; } set { } }
        public virtual System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { throw null; }
        public virtual System.Xml.XmlNode Clone() { throw null; }
        public abstract System.Xml.XmlNode CloneNode(bool deep);
        public virtual System.Xml.XPath.XPathNavigator CreateNavigator() { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual string GetNamespaceOfPrefix(string prefix) { throw null; }
        public virtual string GetPrefixOfNamespace(string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public virtual System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public virtual void Normalize() { }
        public virtual System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { throw null; }
        public virtual void RemoveAll() { }
        public virtual System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { throw null; }
        public virtual System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) { throw null; }
        public System.Xml.XmlNodeList SelectNodes(string xpath) { throw null; }
        public System.Xml.XmlNodeList SelectNodes(string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        public System.Xml.XmlNode SelectSingleNode(string xpath) { throw null; }
        public System.Xml.XmlNode SelectSingleNode(string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        public virtual bool Supports(string feature, string version) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public abstract void WriteContentTo(System.Xml.XmlWriter w);
        public abstract void WriteTo(System.Xml.XmlWriter w);
    }
    public enum XmlNodeChangedAction
    {
        Change = 2,
        Insert = 0,
        Remove = 1,
    }
    public partial class XmlNodeChangedEventArgs : System.EventArgs
    {
        public XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action) { }
        public System.Xml.XmlNodeChangedAction Action { get { throw null; } }
        public System.Xml.XmlNode NewParent { get { throw null; } }
        public string NewValue { get { throw null; } }
        public System.Xml.XmlNode Node { get { throw null; } }
        public System.Xml.XmlNode OldParent { get { throw null; } }
        public string OldValue { get { throw null; } }
    }
    public delegate void XmlNodeChangedEventHandler(object sender, System.Xml.XmlNodeChangedEventArgs e);
    public abstract partial class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
    {
        protected XmlNodeList() { }
        public abstract int Count { get; }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public virtual System.Xml.XmlNode this[int i] { get { throw null; } }
        public abstract System.Collections.IEnumerator GetEnumerator();
        public abstract System.Xml.XmlNode Item(int index);
        protected virtual void PrivateDisposeNodeList() { }
        void System.IDisposable.Dispose() { }
    }
    public enum XmlNodeOrder
    {
        After = 1,
        Before = 0,
        Same = 2,
        Unknown = 3,
    }
    public partial class XmlNodeReader : System.Xml.XmlReader, System.Xml.IXmlNamespaceResolver
    {
        public XmlNodeReader(System.Xml.XmlNode node) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override bool CanReadBinaryContent { get { throw null; } }
        public override bool CanResolveEntity { get { throw null; } }
        public override int Depth { get { throw null; } }
        public override bool EOF { get { throw null; } }
        public override bool HasAttributes { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Prefix { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public override string Value { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override string GetAttribute(int attributeIndex) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string name, string namespaceURI) { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int attributeIndex) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string name, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override string ReadString() { throw null; }
        public override void ResolveEntity() { }
        public override void Skip() { }
        System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { throw null; }
    }
    public enum XmlNodeType
    {
        Attribute = 2,
        CDATA = 4,
        Comment = 8,
        Document = 9,
        DocumentFragment = 11,
        DocumentType = 10,
        Element = 1,
        EndElement = 15,
        EndEntity = 16,
        Entity = 6,
        EntityReference = 5,
        None = 0,
        Notation = 12,
        ProcessingInstruction = 7,
        SignificantWhitespace = 14,
        Text = 3,
        Whitespace = 13,
        XmlDeclaration = 17,
    }
    public partial class XmlNotation : System.Xml.XmlNode
    {
        internal XmlNotation() { }
        public override string InnerXml { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string OuterXml { get { throw null; } }
        public string PublicId { get { throw null; } }
        public string SystemId { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public enum XmlOutputMethod
    {
        AutoDetect = 3,
        Html = 1,
        Text = 2,
        Xml = 0,
    }
    public partial class XmlParserContext
    {
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace) { }
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace) { }
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
        public string BaseURI { get { throw null; } set { } }
        public string DocTypeName { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public string InternalSubset { get { throw null; } set { } }
        public System.Xml.XmlNamespaceManager NamespaceManager { get { throw null; } set { } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } set { } }
        public string PublicId { get { throw null; } set { } }
        public string SystemId { get { throw null; } set { } }
        public string XmlLang { get { throw null; } set { } }
        public System.Xml.XmlSpace XmlSpace { get { throw null; } set { } }
    }
    public partial class XmlProcessingInstruction : System.Xml.XmlLinkedNode
    {
        protected internal XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc) { }
        public string Data { get { throw null; } set { } }
        public override string InnerText { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public string Target { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    [System.SerializableAttribute]
    public partial class XmlQualifiedName
    {
        public static readonly System.Xml.XmlQualifiedName Empty;
        public XmlQualifiedName() { }
        public XmlQualifiedName(string name) { }
        public XmlQualifiedName(string name, string ns) { }
        public bool IsEmpty { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { throw null; }
        public static bool operator !=(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { throw null; }
        public override string ToString() { throw null; }
        public static string ToString(string name, string ns) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{debuggerDisplayProxy}")]
    [System.Diagnostics.DebuggerDisplayAttribute("{debuggerDisplayProxy}")]
    public abstract partial class XmlReader : System.IDisposable
    {
        protected XmlReader() { }
        public abstract int AttributeCount { get; }
        public abstract string BaseURI { get; }
        public virtual bool CanReadBinaryContent { get { throw null; } }
        public virtual bool CanReadValueChunk { get { throw null; } }
        public virtual bool CanResolveEntity { get { throw null; } }
        public abstract int Depth { get; }
        public abstract bool EOF { get; }
        public virtual bool HasAttributes { get { throw null; } }
        public virtual bool HasValue { get { throw null; } }
        public virtual bool IsDefault { get { throw null; } }
        public abstract bool IsEmptyElement { get; }
        public virtual string this[int i] { get { throw null; } }
        public virtual string this[string name] { get { throw null; } }
        public virtual string this[string name, string namespaceURI] { get { throw null; } }
        public abstract string LocalName { get; }
        public virtual string Name { get { throw null; } }
        public abstract string NamespaceURI { get; }
        public abstract System.Xml.XmlNameTable NameTable { get; }
        public abstract System.Xml.XmlNodeType NodeType { get; }
        public abstract string Prefix { get; }
        public virtual char QuoteChar { get { throw null; } }
        public abstract System.Xml.ReadState ReadState { get; }
        public virtual System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public virtual System.Xml.XmlReaderSettings Settings { get { throw null; } }
        public abstract string Value { get; }
        public virtual System.Type ValueType { get { throw null; } }
        public virtual string XmlLang { get { throw null; } }
        public virtual System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public virtual void Close() { }
        public static System.Xml.XmlReader Create(System.IO.Stream input) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { throw null; }
        public static System.Xml.XmlReader Create(string inputUri) { throw null; }
        public static System.Xml.XmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings) { throw null; }
        public static System.Xml.XmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { throw null; }
        public static System.Xml.XmlReader Create(System.Xml.XmlReader reader, System.Xml.XmlReaderSettings settings) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract string GetAttribute(int i);
        public abstract string GetAttribute(string name);
        public abstract string GetAttribute(string name, string namespaceURI);
        public virtual System.Threading.Tasks.Task<string> GetValueAsync() { throw null; }
        public static bool IsName(string str) { throw null; }
        public static bool IsNameToken(string str) { throw null; }
        public virtual bool IsStartElement() { throw null; }
        public virtual bool IsStartElement(string name) { throw null; }
        public virtual bool IsStartElement(string localname, string ns) { throw null; }
        public abstract string LookupNamespace(string prefix);
        public virtual void MoveToAttribute(int i) { }
        public abstract bool MoveToAttribute(string name);
        public abstract bool MoveToAttribute(string name, string ns);
        public virtual System.Xml.XmlNodeType MoveToContent() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Xml.XmlNodeType> MoveToContentAsync() { throw null; }
        public abstract bool MoveToElement();
        public abstract bool MoveToFirstAttribute();
        public abstract bool MoveToNextAttribute();
        public abstract bool Read();
        public virtual System.Threading.Tasks.Task<bool> ReadAsync() { throw null; }
        public abstract bool ReadAttributeValue();
        public virtual object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadContentAsAsync(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadContentAsBase64Async(byte[] buffer, int index, int count) { throw null; }
        public virtual int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadContentAsBinHexAsync(byte[] buffer, int index, int count) { throw null; }
        public virtual bool ReadContentAsBoolean() { throw null; }
        public virtual System.DateTime ReadContentAsDateTime() { throw null; }
        public virtual System.DateTimeOffset ReadContentAsDateTimeOffset() { throw null; }
        public virtual decimal ReadContentAsDecimal() { throw null; }
        public virtual double ReadContentAsDouble() { throw null; }
        public virtual float ReadContentAsFloat() { throw null; }
        public virtual int ReadContentAsInt() { throw null; }
        public virtual long ReadContentAsLong() { throw null; }
        public virtual object ReadContentAsObject() { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadContentAsObjectAsync() { throw null; }
        public virtual string ReadContentAsString() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadContentAsStringAsync() { throw null; }
        public virtual object ReadElementContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual object ReadElementContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadElementContentAsAsync(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadElementContentAsBase64Async(byte[] buffer, int index, int count) { throw null; }
        public virtual int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadElementContentAsBinHexAsync(byte[] buffer, int index, int count) { throw null; }
        public virtual bool ReadElementContentAsBoolean() { throw null; }
        public virtual bool ReadElementContentAsBoolean(string localName, string namespaceURI) { throw null; }
        public virtual System.DateTime ReadElementContentAsDateTime() { throw null; }
        public virtual System.DateTime ReadElementContentAsDateTime(string localName, string namespaceURI) { throw null; }
        public virtual decimal ReadElementContentAsDecimal() { throw null; }
        public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceURI) { throw null; }
        public virtual double ReadElementContentAsDouble() { throw null; }
        public virtual double ReadElementContentAsDouble(string localName, string namespaceURI) { throw null; }
        public virtual float ReadElementContentAsFloat() { throw null; }
        public virtual float ReadElementContentAsFloat(string localName, string namespaceURI) { throw null; }
        public virtual int ReadElementContentAsInt() { throw null; }
        public virtual int ReadElementContentAsInt(string localName, string namespaceURI) { throw null; }
        public virtual long ReadElementContentAsLong() { throw null; }
        public virtual long ReadElementContentAsLong(string localName, string namespaceURI) { throw null; }
        public virtual object ReadElementContentAsObject() { throw null; }
        public virtual object ReadElementContentAsObject(string localName, string namespaceURI) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadElementContentAsObjectAsync() { throw null; }
        public virtual string ReadElementContentAsString() { throw null; }
        public virtual string ReadElementContentAsString(string localName, string namespaceURI) { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadElementContentAsStringAsync() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual string ReadElementString() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual string ReadElementString(string name) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual string ReadElementString(string localname, string ns) { throw null; }
        public virtual void ReadEndElement() { }
        public virtual string ReadInnerXml() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadInnerXmlAsync() { throw null; }
        public virtual string ReadOuterXml() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadOuterXmlAsync() { throw null; }
        public virtual void ReadStartElement() { }
        public virtual void ReadStartElement(string name) { }
        public virtual void ReadStartElement(string localname, string ns) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual string ReadString() { throw null; }
        public virtual System.Xml.XmlReader ReadSubtree() { throw null; }
        public virtual bool ReadToDescendant(string name) { throw null; }
        public virtual bool ReadToDescendant(string localName, string namespaceURI) { throw null; }
        public virtual bool ReadToFollowing(string name) { throw null; }
        public virtual bool ReadToFollowing(string localName, string namespaceURI) { throw null; }
        public virtual bool ReadToNextSibling(string name) { throw null; }
        public virtual bool ReadToNextSibling(string localName, string namespaceURI) { throw null; }
        public virtual int ReadValueChunk(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadValueChunkAsync(char[] buffer, int index, int count) { throw null; }
        public abstract void ResolveEntity();
        public virtual void Skip() { }
        public virtual System.Threading.Tasks.Task SkipAsync() { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public sealed partial class XmlReaderSettings
    {
        public XmlReaderSettings() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public XmlReaderSettings(System.Xml.XmlResolver resolver) { }
        public bool Async { get { throw null; } set { } }
        public bool CheckCharacters { get { throw null; } set { } }
        public bool CloseInput { get { throw null; } set { } }
        public System.Xml.ConformanceLevel ConformanceLevel { get { throw null; } set { } }
        public System.Xml.DtdProcessing DtdProcessing { get { throw null; } set { } }
        public bool IgnoreComments { get { throw null; } set { } }
        public bool IgnoreProcessingInstructions { get { throw null; } set { } }
        public bool IgnoreWhitespace { get { throw null; } set { } }
        public int LineNumberOffset { get { throw null; } set { } }
        public int LinePositionOffset { get { throw null; } set { } }
        public long MaxCharactersFromEntities { get { throw null; } set { } }
        public long MaxCharactersInDocument { get { throw null; } set { } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } set { } }
        [System.ObsoleteAttribute("Use XmlReaderSettings.DtdProcessing property instead.")]
        public bool ProhibitDtd { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSet Schemas { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaValidationFlags ValidationFlags { get { throw null; } set { } }
        public System.Xml.ValidationType ValidationType { get { throw null; } set { } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public System.Xml.XmlReaderSettings Clone() { throw null; }
        public void Reset() { }
    }
    public abstract partial class XmlResolver
    {
        protected XmlResolver() { }
        public virtual System.Net.ICredentials Credentials { set { } }
        public abstract object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        public virtual System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public virtual System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
        public virtual bool SupportsType(System.Uri absoluteUri, System.Type type) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class XmlSecureResolver : System.Xml.XmlResolver
    {
        public XmlSecureResolver(System.Xml.XmlResolver resolver, System.Security.PermissionSet permissionSet) { }
        public XmlSecureResolver(System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public XmlSecureResolver(System.Xml.XmlResolver resolver, string securityUrl) { }
        public override System.Net.ICredentials Credentials { set { } }
        public static System.Security.Policy.Evidence CreateEvidenceForUrl(string securityUrl) { throw null; }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
    }
    public partial class XmlSignificantWhitespace : System.Xml.XmlCharacterData
    {
        protected internal XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public enum XmlSpace
    {
        Default = 1,
        None = 0,
        Preserve = 2,
    }
    public partial class XmlText : System.Xml.XmlCharacterData
    {
        protected internal XmlText(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public virtual System.Xml.XmlText SplitText(int offset) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
    {
        protected XmlTextReader() { }
        public XmlTextReader(System.IO.Stream input) { }
        public XmlTextReader(System.IO.Stream input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(System.IO.Stream xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        public XmlTextReader(System.IO.TextReader input) { }
        public XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string url) { }
        public XmlTextReader(string url, System.IO.Stream input) { }
        public XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string url, System.IO.TextReader input) { }
        public XmlTextReader(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string url, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        protected XmlTextReader(System.Xml.XmlNameTable nt) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override bool CanReadBinaryContent { get { throw null; } }
        public override bool CanReadValueChunk { get { throw null; } }
        public override bool CanResolveEntity { get { throw null; } }
        public override int Depth { get { throw null; } }
        public System.Xml.DtdProcessing DtdProcessing { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } }
        public System.Xml.EntityHandling EntityHandling { get { throw null; } set { } }
        public override bool EOF { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public bool Namespaces { get { throw null; } set { } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public bool Normalization { get { throw null; } set { } }
        public override string Prefix { get { throw null; } }
        [System.ObsoleteAttribute("Use DtdProcessing property instead.")]
        public bool ProhibitDtd { get { throw null; } set { } }
        public override char QuoteChar { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public override string Value { get { throw null; } }
        public System.Xml.WhitespaceHandling WhitespaceHandling { get { throw null; } set { } }
        public override string XmlLang { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override string GetAttribute(int i) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string localName, string namespaceURI) { throw null; }
        public System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        public System.IO.TextReader GetRemainder() { throw null; }
        public bool HasLineInfo() { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string localName, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public int ReadBase64(byte[] array, int offset, int len) { throw null; }
        public int ReadBinHex(byte[] array, int offset, int len) { throw null; }
        public int ReadChars(char[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override string ReadString() { throw null; }
        public void ResetState() { }
        public override void ResolveEntity() { }
        public override void Skip() { }
        System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class XmlTextWriter : System.Xml.XmlWriter
    {
        public XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding) { }
        public XmlTextWriter(System.IO.TextWriter w) { }
        public XmlTextWriter(string filename, System.Text.Encoding encoding) { }
        public System.IO.Stream BaseStream { get { throw null; } }
        public System.Xml.Formatting Formatting { get { throw null; } set { } }
        public int Indentation { get { throw null; } set { } }
        public char IndentChar { get { throw null; } set { } }
        public bool Namespaces { get { throw null; } set { } }
        public char QuoteChar { get { throw null; } set { } }
        public override System.Xml.WriteState WriteState { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override void Flush() { }
        public override string LookupPrefix(string ns) { throw null; }
        public override void WriteBase64(byte[] buffer, int index, int count) { }
        public override void WriteBinHex(byte[] buffer, int index, int count) { }
        public override void WriteCData(string text) { }
        public override void WriteCharEntity(char ch) { }
        public override void WriteChars(char[] buffer, int index, int count) { }
        public override void WriteComment(string text) { }
        public override void WriteDocType(string name, string pubid, string sysid, string subset) { }
        public override void WriteEndAttribute() { }
        public override void WriteEndDocument() { }
        public override void WriteEndElement() { }
        public override void WriteEntityRef(string name) { }
        public override void WriteFullEndElement() { }
        public override void WriteName(string name) { }
        public override void WriteNmToken(string name) { }
        public override void WriteProcessingInstruction(string name, string text) { }
        public override void WriteQualifiedName(string localName, string ns) { }
        public override void WriteRaw(char[] buffer, int index, int count) { }
        public override void WriteRaw(string data) { }
        public override void WriteStartAttribute(string prefix, string localName, string ns) { }
        public override void WriteStartDocument() { }
        public override void WriteStartDocument(bool standalone) { }
        public override void WriteStartElement(string prefix, string localName, string ns) { }
        public override void WriteString(string text) { }
        public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }
        public override void WriteWhitespace(string ws) { }
    }
    public enum XmlTokenizedType
    {
        CDATA = 0,
        ENTITIES = 5,
        ENTITY = 4,
        ENUMERATION = 9,
        ID = 1,
        IDREF = 2,
        IDREFS = 3,
        NCName = 11,
        NMTOKEN = 6,
        NMTOKENS = 7,
        None = 12,
        NOTATION = 8,
        QName = 10,
    }
    public partial class XmlUrlResolver : System.Xml.XmlResolver
    {
        public XmlUrlResolver() { }
        public System.Net.Cache.RequestCachePolicy CachePolicy { set { } }
        public override System.Net.ICredentials Credentials { set { } }
        public System.Net.IWebProxy Proxy { set { } }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
    }
    [System.ObsoleteAttribute("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class XmlValidatingReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
    {
        public XmlValidatingReader(System.IO.Stream xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        public XmlValidatingReader(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        public XmlValidatingReader(System.Xml.XmlReader reader) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override bool CanReadBinaryContent { get { throw null; } }
        public override bool CanResolveEntity { get { throw null; } }
        public override int Depth { get { throw null; } }
        public System.Text.Encoding Encoding { get { throw null; } }
        public System.Xml.EntityHandling EntityHandling { get { throw null; } set { } }
        public override bool EOF { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public bool Namespaces { get { throw null; } set { } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Prefix { get { throw null; } }
        public override char QuoteChar { get { throw null; } }
        public System.Xml.XmlReader Reader { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public System.Xml.Schema.XmlSchemaCollection Schemas { get { throw null; } }
        public object SchemaType { get { throw null; } }
        public System.Xml.ValidationType ValidationType { get { throw null; } set { } }
        public override string Value { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public override void Close() { }
        public override string GetAttribute(int i) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string localName, string namespaceURI) { throw null; }
        public bool HasLineInfo() { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string localName, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override string ReadString() { throw null; }
        public object ReadTypedValue() { throw null; }
        public override void ResolveEntity() { }
        System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { throw null; }
    }
    public partial class XmlWhitespace : System.Xml.XmlCharacterData
    {
        protected internal XmlWhitespace(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public abstract partial class XmlWriter : System.IDisposable
    {
        protected XmlWriter() { }
        public virtual System.Xml.XmlWriterSettings Settings { get { throw null; } }
        public abstract System.Xml.WriteState WriteState { get; }
        public virtual string XmlLang { get { throw null; } }
        public virtual System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public virtual void Close() { }
        public static System.Xml.XmlWriter Create(System.IO.Stream output) { throw null; }
        public static System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(System.IO.TextWriter output) { throw null; }
        public static System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(string outputFileName) { throw null; }
        public static System.Xml.XmlWriter Create(string outputFileName, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(System.Text.StringBuilder output) { throw null; }
        public static System.Xml.XmlWriter Create(System.Text.StringBuilder output, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(System.Xml.XmlWriter output) { throw null; }
        public static System.Xml.XmlWriter Create(System.Xml.XmlWriter output, System.Xml.XmlWriterSettings settings) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract void Flush();
        public virtual System.Threading.Tasks.Task FlushAsync() { throw null; }
        public abstract string LookupPrefix(string ns);
        public virtual void WriteAttributes(System.Xml.XmlReader reader, bool defattr) { }
        public virtual System.Threading.Tasks.Task WriteAttributesAsync(System.Xml.XmlReader reader, bool defattr) { throw null; }
        public void WriteAttributeString(string localName, string value) { }
        public void WriteAttributeString(string localName, string ns, string value) { }
        public void WriteAttributeString(string prefix, string localName, string ns, string value) { }
        public System.Threading.Tasks.Task WriteAttributeStringAsync(string prefix, string localName, string ns, string value) { throw null; }
        public abstract void WriteBase64(byte[] buffer, int index, int count);
        public virtual System.Threading.Tasks.Task WriteBase64Async(byte[] buffer, int index, int count) { throw null; }
        public virtual void WriteBinHex(byte[] buffer, int index, int count) { }
        public virtual System.Threading.Tasks.Task WriteBinHexAsync(byte[] buffer, int index, int count) { throw null; }
        public abstract void WriteCData(string text);
        public virtual System.Threading.Tasks.Task WriteCDataAsync(string text) { throw null; }
        public abstract void WriteCharEntity(char ch);
        public virtual System.Threading.Tasks.Task WriteCharEntityAsync(char ch) { throw null; }
        public abstract void WriteChars(char[] buffer, int index, int count);
        public virtual System.Threading.Tasks.Task WriteCharsAsync(char[] buffer, int index, int count) { throw null; }
        public abstract void WriteComment(string text);
        public virtual System.Threading.Tasks.Task WriteCommentAsync(string text) { throw null; }
        public abstract void WriteDocType(string name, string pubid, string sysid, string subset);
        public virtual System.Threading.Tasks.Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset) { throw null; }
        public void WriteElementString(string localName, string value) { }
        public void WriteElementString(string localName, string ns, string value) { }
        public void WriteElementString(string prefix, string localName, string ns, string value) { }
        public System.Threading.Tasks.Task WriteElementStringAsync(string prefix, string localName, string ns, string value) { throw null; }
        public abstract void WriteEndAttribute();
        protected internal virtual System.Threading.Tasks.Task WriteEndAttributeAsync() { throw null; }
        public abstract void WriteEndDocument();
        public virtual System.Threading.Tasks.Task WriteEndDocumentAsync() { throw null; }
        public abstract void WriteEndElement();
        public virtual System.Threading.Tasks.Task WriteEndElementAsync() { throw null; }
        public abstract void WriteEntityRef(string name);
        public virtual System.Threading.Tasks.Task WriteEntityRefAsync(string name) { throw null; }
        public abstract void WriteFullEndElement();
        public virtual System.Threading.Tasks.Task WriteFullEndElementAsync() { throw null; }
        public virtual void WriteName(string name) { }
        public virtual System.Threading.Tasks.Task WriteNameAsync(string name) { throw null; }
        public virtual void WriteNmToken(string name) { }
        public virtual System.Threading.Tasks.Task WriteNmTokenAsync(string name) { throw null; }
        public virtual void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
        public virtual void WriteNode(System.Xml.XPath.XPathNavigator navigator, bool defattr) { }
        public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XmlReader reader, bool defattr) { throw null; }
        public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XPath.XPathNavigator navigator, bool defattr) { throw null; }
        public abstract void WriteProcessingInstruction(string name, string text);
        public virtual System.Threading.Tasks.Task WriteProcessingInstructionAsync(string name, string text) { throw null; }
        public virtual void WriteQualifiedName(string localName, string ns) { }
        public virtual System.Threading.Tasks.Task WriteQualifiedNameAsync(string localName, string ns) { throw null; }
        public abstract void WriteRaw(char[] buffer, int index, int count);
        public abstract void WriteRaw(string data);
        public virtual System.Threading.Tasks.Task WriteRawAsync(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task WriteRawAsync(string data) { throw null; }
        public void WriteStartAttribute(string localName) { }
        public void WriteStartAttribute(string localName, string ns) { }
        public abstract void WriteStartAttribute(string prefix, string localName, string ns);
        protected internal virtual System.Threading.Tasks.Task WriteStartAttributeAsync(string prefix, string localName, string ns) { throw null; }
        public abstract void WriteStartDocument();
        public abstract void WriteStartDocument(bool standalone);
        public virtual System.Threading.Tasks.Task WriteStartDocumentAsync() { throw null; }
        public virtual System.Threading.Tasks.Task WriteStartDocumentAsync(bool standalone) { throw null; }
        public void WriteStartElement(string localName) { }
        public void WriteStartElement(string localName, string ns) { }
        public abstract void WriteStartElement(string prefix, string localName, string ns);
        public virtual System.Threading.Tasks.Task WriteStartElementAsync(string prefix, string localName, string ns) { throw null; }
        public abstract void WriteString(string text);
        public virtual System.Threading.Tasks.Task WriteStringAsync(string text) { throw null; }
        public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);
        public virtual System.Threading.Tasks.Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { throw null; }
        public virtual void WriteValue(bool value) { }
        public virtual void WriteValue(System.DateTime value) { }
        public virtual void WriteValue(System.DateTimeOffset value) { }
        public virtual void WriteValue(decimal value) { }
        public virtual void WriteValue(double value) { }
        public virtual void WriteValue(int value) { }
        public virtual void WriteValue(long value) { }
        public virtual void WriteValue(object value) { }
        public virtual void WriteValue(float value) { }
        public virtual void WriteValue(string value) { }
        public abstract void WriteWhitespace(string ws);
        public virtual System.Threading.Tasks.Task WriteWhitespaceAsync(string ws) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public sealed partial class XmlWriterSettings
    {
        public XmlWriterSettings() { }
        public bool Async { get { throw null; } set { } }
        public bool CheckCharacters { get { throw null; } set { } }
        public bool CloseOutput { get { throw null; } set { } }
        public System.Xml.ConformanceLevel ConformanceLevel { get { throw null; } set { } }
        public bool DoNotEscapeUriAttributes { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public bool Indent { get { throw null; } set { } }
        public string IndentChars { get { throw null; } set { } }
        public System.Xml.NamespaceHandling NamespaceHandling { get { throw null; } set { } }
        public string NewLineChars { get { throw null; } set { } }
        public System.Xml.NewLineHandling NewLineHandling { get { throw null; } set { } }
        public bool NewLineOnAttributes { get { throw null; } set { } }
        public bool OmitXmlDeclaration { get { throw null; } set { } }
        public System.Xml.XmlOutputMethod OutputMethod { get { throw null; } }
        public bool WriteEndDocumentOnClose { get { throw null; } set { } }
        public System.Xml.XmlWriterSettings Clone() { throw null; }
        public void Reset() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial class XmlXapResolver : System.Xml.XmlResolver
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public XmlXapResolver() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public static void RegisterApplicationResourceStreamResolver(System.Xml.IApplicationResourceStreamResolver appStreamResolver) { }
    }
}
namespace System.Xml.Resolvers
{
    [System.FlagsAttribute]
    public enum XmlKnownDtds
    {
        All = 65535,
        None = 0,
        Rss091 = 2,
        Xhtml10 = 1,
    }
    public partial class XmlPreloadedResolver : System.Xml.XmlResolver
    {
        public XmlPreloadedResolver() { }
        public XmlPreloadedResolver(System.Xml.Resolvers.XmlKnownDtds preloadedDtds) { }
        public XmlPreloadedResolver(System.Xml.XmlResolver fallbackResolver) { }
        public XmlPreloadedResolver(System.Xml.XmlResolver fallbackResolver, System.Xml.Resolvers.XmlKnownDtds preloadedDtds) { }
        public XmlPreloadedResolver(System.Xml.XmlResolver fallbackResolver, System.Xml.Resolvers.XmlKnownDtds preloadedDtds, System.Collections.Generic.IEqualityComparer<System.Uri> uriComparer) { }
        public override System.Net.ICredentials Credentials { set { } }
        public System.Collections.Generic.IEnumerable<System.Uri> PreloadedUris { get { throw null; } }
        public void Add(System.Uri uri, byte[] value) { }
        public void Add(System.Uri uri, byte[] value, int offset, int count) { }
        public void Add(System.Uri uri, System.IO.Stream value) { }
        public void Add(System.Uri uri, string value) { }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public void Remove(System.Uri uri) { }
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
        public override bool SupportsType(System.Uri absoluteUri, System.Type type) { throw null; }
    }
}
namespace System.Xml.Schema
{
    public partial interface IXmlSchemaInfo
    {
        bool IsDefault { get; }
        bool IsNil { get; }
        System.Xml.Schema.XmlSchemaSimpleType MemberType { get; }
        System.Xml.Schema.XmlSchemaAttribute SchemaAttribute { get; }
        System.Xml.Schema.XmlSchemaElement SchemaElement { get; }
        System.Xml.Schema.XmlSchemaType SchemaType { get; }
        System.Xml.Schema.XmlSchemaValidity Validity { get; }
    }
    public partial class ValidationEventArgs : System.EventArgs
    {
        internal ValidationEventArgs() { }
        public System.Xml.Schema.XmlSchemaException Exception { get { throw null; } }
        public string Message { get { throw null; } }
        public System.Xml.Schema.XmlSeverityType Severity { get { throw null; } }
    }
    public delegate void ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e);
    public sealed partial class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
    {
        internal XmlAtomicValue() { }
        public override bool IsNode { get { throw null; } }
        public override object TypedValue { get { throw null; } }
        public override string Value { get { throw null; } }
        public override bool ValueAsBoolean { get { throw null; } }
        public override System.DateTime ValueAsDateTime { get { throw null; } }
        public override double ValueAsDouble { get { throw null; } }
        public override int ValueAsInt { get { throw null; } }
        public override long ValueAsLong { get { throw null; } }
        public override System.Type ValueType { get { throw null; } }
        public override System.Xml.Schema.XmlSchemaType XmlType { get { throw null; } }
        public System.Xml.Schema.XmlAtomicValue Clone() { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public override object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver) { throw null; }
    }
    [System.Xml.Serialization.XmlRootAttribute("schema", Namespace="http://www.w3.org/2001/XMLSchema")]
    public partial class XmlSchema : System.Xml.Schema.XmlSchemaObject
    {
        public const string InstanceNamespace = "http://www.w3.org/2001/XMLSchema-instance";
        public const string Namespace = "http://www.w3.org/2001/XMLSchema";
        public XmlSchema() { }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaForm)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("attributeFormDefault")]
        public System.Xml.Schema.XmlSchemaForm AttributeFormDefault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable AttributeGroups { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Attributes { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaDerivationMethod)(256))]
        [System.Xml.Serialization.XmlAttributeAttribute("blockDefault")]
        public System.Xml.Schema.XmlSchemaDerivationMethod BlockDefault { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaForm)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("elementFormDefault")]
        public System.Xml.Schema.XmlSchemaForm ElementFormDefault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Elements { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaDerivationMethod)(256))]
        [System.Xml.Serialization.XmlAttributeAttribute("finalDefault")]
        public System.Xml.Schema.XmlSchemaDerivationMethod FinalDefault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Groups { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("import", typeof(System.Xml.Schema.XmlSchemaImport))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(System.Xml.Schema.XmlSchemaInclude))]
        [System.Xml.Serialization.XmlElementAttribute("redefine", typeof(System.Xml.Schema.XmlSchemaRedefine))]
        public System.Xml.Schema.XmlSchemaObjectCollection Includes { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool IsCompiled { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroup))]
        [System.Xml.Serialization.XmlElementAttribute("complexType", typeof(System.Xml.Schema.XmlSchemaComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroup))]
        [System.Xml.Serialization.XmlElementAttribute("notation", typeof(System.Xml.Schema.XmlSchemaNotation))]
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Notations { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable SchemaTypes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("targetNamespace", DataType="anyURI")]
        public string TargetNamespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("version", DataType="token")]
        public string Version { get { throw null; } set { } }
        [System.ObsoleteAttribute("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void Compile(System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        [System.ObsoleteAttribute("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void Compile(System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlResolver resolver) { }
        public static System.Xml.Schema.XmlSchema Read(System.IO.Stream stream, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public static System.Xml.Schema.XmlSchema Read(System.IO.TextReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public static System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public void Write(System.IO.Stream stream) { }
        public void Write(System.IO.Stream stream, System.Xml.XmlNamespaceManager namespaceManager) { }
        public void Write(System.IO.TextWriter writer) { }
        public void Write(System.IO.TextWriter writer, System.Xml.XmlNamespaceManager namespaceManager) { }
        public void Write(System.Xml.XmlWriter writer) { }
        public void Write(System.Xml.XmlWriter writer, System.Xml.XmlNamespaceManager namespaceManager) { }
    }
    public partial class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
    {
        public XmlSchemaAll() { }
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        public override System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
    }
    public partial class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaAnnotated() { }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        public System.Xml.Schema.XmlSchemaAnnotation Annotation { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
    }
    public partial class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaAnnotation() { }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("appinfo", typeof(System.Xml.Schema.XmlSchemaAppInfo))]
        [System.Xml.Serialization.XmlElementAttribute("documentation", typeof(System.Xml.Schema.XmlSchemaDocumentation))]
        public System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
    }
    public partial class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
    {
        public XmlSchemaAny() { }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaContentProcessing)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("processContents")]
        public System.Xml.Schema.XmlSchemaContentProcessing ProcessContents { get { throw null; } set { } }
    }
    public partial class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAnyAttribute() { }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaContentProcessing)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("processContents")]
        public System.Xml.Schema.XmlSchemaContentProcessing ProcessContents { get { throw null; } set { } }
    }
    public partial class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaAppInfo() { }
        [System.Xml.Serialization.XmlAnyElementAttribute]
        [System.Xml.Serialization.XmlTextAttribute]
        public System.Xml.XmlNode[] Markup { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source { get { throw null; } set { } }
    }
    public partial class XmlSchemaAttribute : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAttribute() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaSimpleType AttributeSchemaType { get { throw null; } }
        [System.ObsoleteAttribute("This property has been deprecated. Please use AttributeSchemaType property that returns a strongly typed attribute type. http://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public object AttributeType { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("default")]
        public string DefaultValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        public string FixedValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaForm)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType")]
        public System.Xml.Schema.XmlSchemaSimpleType SchemaType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public System.Xml.XmlQualifiedName SchemaTypeName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaUse)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("use")]
        public System.Xml.Schema.XmlSchemaUse Use { get { throw null; } set { } }
    }
    public partial class XmlSchemaAttributeGroup : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAttributeGroup() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaAttributeGroup RedefinedAttributeGroup { get { throw null; } }
    }
    public partial class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaAttributeGroupRef() { }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
    }
    public partial class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
    {
        public XmlSchemaChoice() { }
        [System.Xml.Serialization.XmlElementAttribute("any", typeof(System.Xml.Schema.XmlSchemaAny))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public override System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
    }
    [System.ObsoleteAttribute("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. http://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed partial class XmlSchemaCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public XmlSchemaCollection() { }
        public XmlSchemaCollection(System.Xml.XmlNameTable nametable) { }
        public int Count { get { throw null; } }
        public System.Xml.Schema.XmlSchema this[string ns] { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public System.Xml.Schema.XmlSchema Add(string ns, string uri) { throw null; }
        public System.Xml.Schema.XmlSchema Add(string ns, System.Xml.XmlReader reader) { throw null; }
        public System.Xml.Schema.XmlSchema Add(string ns, System.Xml.XmlReader reader, System.Xml.XmlResolver resolver) { throw null; }
        public System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema) { throw null; }
        public System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema, System.Xml.XmlResolver resolver) { throw null; }
        public void Add(System.Xml.Schema.XmlSchemaCollection schema) { }
        public bool Contains(string ns) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchema[] array, int index) { }
        public System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
    {
        internal XmlSchemaCollectionEnumerator() { }
        public System.Xml.Schema.XmlSchema Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public sealed partial class XmlSchemaCompilationSettings
    {
        public XmlSchemaCompilationSettings() { }
        public bool EnableUpaCheck { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
    {
        public XmlSchemaComplexContent() { }
        [System.Xml.Serialization.XmlElementAttribute("extension", typeof(System.Xml.Schema.XmlSchemaComplexContentExtension))]
        [System.Xml.Serialization.XmlElementAttribute("restriction", typeof(System.Xml.Schema.XmlSchemaComplexContentRestriction))]
        public override System.Xml.Schema.XmlSchemaContent Content { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("mixed")]
        public bool IsMixed { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaComplexContentExtension() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaParticle Particle { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaComplexContentRestriction() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaParticle Particle { get { throw null; } set { } }
    }
    public partial class XmlSchemaComplexType : System.Xml.Schema.XmlSchemaType
    {
        public XmlSchemaComplexType() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable AttributeUses { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaAnyAttribute AttributeWildcard { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaDerivationMethod)(256))]
        [System.Xml.Serialization.XmlAttributeAttribute("block")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Block { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod BlockResolved { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("complexContent", typeof(System.Xml.Schema.XmlSchemaComplexContent))]
        [System.Xml.Serialization.XmlElementAttribute("simpleContent", typeof(System.Xml.Schema.XmlSchemaSimpleContent))]
        public System.Xml.Schema.XmlSchemaContentModel ContentModel { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaContentType ContentType { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaParticle ContentTypeParticle { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abstract")]
        public bool IsAbstract { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("mixed")]
        public override bool IsMixed { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaParticle Particle { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaContent() { }
    }
    public abstract partial class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaContentModel() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public abstract System.Xml.Schema.XmlSchemaContent Content { get; set; }
    }
    public enum XmlSchemaContentProcessing
    {
        [System.Xml.Serialization.XmlEnumAttribute("lax")]
        Lax = 2,
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
        [System.Xml.Serialization.XmlEnumAttribute("skip")]
        Skip = 1,
        [System.Xml.Serialization.XmlEnumAttribute("strict")]
        Strict = 3,
    }
    public enum XmlSchemaContentType
    {
        ElementOnly = 2,
        Empty = 1,
        Mixed = 3,
        TextOnly = 0,
    }
    public abstract partial class XmlSchemaDatatype
    {
        protected XmlSchemaDatatype() { }
        public abstract System.Xml.XmlTokenizedType TokenizedType { get; }
        public virtual System.Xml.Schema.XmlTypeCode TypeCode { get { throw null; } }
        public abstract System.Type ValueType { get; }
        public virtual System.Xml.Schema.XmlSchemaDatatypeVariety Variety { get { throw null; } }
        public virtual object ChangeType(object value, System.Type targetType) { throw null; }
        public virtual object ChangeType(object value, System.Type targetType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype) { throw null; }
        public abstract object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
    }
    public enum XmlSchemaDatatypeVariety
    {
        Atomic = 0,
        List = 1,
        Union = 2,
    }
    [System.FlagsAttribute]
    public enum XmlSchemaDerivationMethod
    {
        [System.Xml.Serialization.XmlEnumAttribute("#all")]
        All = 255,
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Empty = 0,
        [System.Xml.Serialization.XmlEnumAttribute("extension")]
        Extension = 2,
        [System.Xml.Serialization.XmlEnumAttribute("list")]
        List = 8,
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 256,
        [System.Xml.Serialization.XmlEnumAttribute("restriction")]
        Restriction = 4,
        [System.Xml.Serialization.XmlEnumAttribute("substitution")]
        Substitution = 1,
        [System.Xml.Serialization.XmlEnumAttribute("union")]
        Union = 16,
    }
    public partial class XmlSchemaDocumentation : System.Xml.Schema.XmlSchemaObject
    {
        public XmlSchemaDocumentation() { }
        [System.Xml.Serialization.XmlAttributeAttribute("xml:lang")]
        public string Language { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyElementAttribute]
        [System.Xml.Serialization.XmlTextAttribute]
        public System.Xml.XmlNode[] Markup { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source { get { throw null; } set { } }
    }
    public partial class XmlSchemaElement : System.Xml.Schema.XmlSchemaParticle
    {
        public XmlSchemaElement() { }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaDerivationMethod)(256))]
        [System.Xml.Serialization.XmlAttributeAttribute("block")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Block { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod BlockResolved { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("key", typeof(System.Xml.Schema.XmlSchemaKey))]
        [System.Xml.Serialization.XmlElementAttribute("keyref", typeof(System.Xml.Schema.XmlSchemaKeyref))]
        [System.Xml.Serialization.XmlElementAttribute("unique", typeof(System.Xml.Schema.XmlSchemaUnique))]
        public System.Xml.Schema.XmlSchemaObjectCollection Constraints { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("default")]
        public string DefaultValue { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaType ElementSchemaType { get { throw null; } }
        [System.ObsoleteAttribute("This property has been deprecated. Please use ElementSchemaType property that returns a strongly typed element type. http://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public object ElementType { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaDerivationMethod)(256))]
        [System.Xml.Serialization.XmlAttributeAttribute("final")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Final { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod FinalResolved { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        public string FixedValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaForm)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abstract")]
        public bool IsAbstract { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("nillable")]
        public bool IsNillable { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("complexType", typeof(System.Xml.Schema.XmlSchemaComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaType SchemaType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public System.Xml.XmlQualifiedName SchemaTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("substitutionGroup")]
        public System.Xml.XmlQualifiedName SubstitutionGroup { get { throw null; } set { } }
    }
    public partial class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaEnumerationFacet() { }
    }
    [System.SerializableAttribute]
    public partial class XmlSchemaException : System.SystemException
    {
        public XmlSchemaException() { }
        protected XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlSchemaException(string message) { }
        public XmlSchemaException(string message, System.Exception innerException) { }
        public XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string Message { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObject SourceSchemaObject { get { throw null; } }
        public string SourceUri { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
    {
        protected XmlSchemaExternal() { }
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchema Schema { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("schemaLocation", DataType="anyURI")]
        public string SchemaLocation { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] UnhandledAttributes { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaFacet : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaFacet() { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        public virtual bool IsFixed { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get { throw null; } set { } }
    }
    public enum XmlSchemaForm
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
        [System.Xml.Serialization.XmlEnumAttribute("qualified")]
        Qualified = 1,
        [System.Xml.Serialization.XmlEnumAttribute("unqualified")]
        Unqualified = 2,
    }
    public partial class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaFractionDigitsFacet() { }
    }
    public partial class XmlSchemaGroup : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaGroup() { }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(System.Xml.Schema.XmlSchemaAll))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public System.Xml.Schema.XmlSchemaGroupBase Particle { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
    }
    public abstract partial class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
    {
        protected XmlSchemaGroupBase() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public abstract System.Xml.Schema.XmlSchemaObjectCollection Items { get; }
    }
    public partial class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
    {
        public XmlSchemaGroupRef() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaGroupBase Particle { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public System.Xml.XmlQualifiedName RefName { get { throw null; } set { } }
    }
    public partial class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaIdentityConstraint() { }
        [System.Xml.Serialization.XmlElementAttribute("field", typeof(System.Xml.Schema.XmlSchemaXPath))]
        public System.Xml.Schema.XmlSchemaObjectCollection Fields { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("selector", typeof(System.Xml.Schema.XmlSchemaXPath))]
        public System.Xml.Schema.XmlSchemaXPath Selector { get { throw null; } set { } }
    }
    public partial class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
    {
        public XmlSchemaImport() { }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        public System.Xml.Schema.XmlSchemaAnnotation Annotation { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace", DataType="anyURI")]
        public string Namespace { get { throw null; } set { } }
    }
    public partial class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
    {
        public XmlSchemaInclude() { }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        public System.Xml.Schema.XmlSchemaAnnotation Annotation { get { throw null; } set { } }
    }
    public sealed partial class XmlSchemaInference
    {
        public XmlSchemaInference() { }
        public System.Xml.Schema.XmlSchemaInference.InferenceOption Occurrence { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaInference.InferenceOption TypeInference { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument) { throw null; }
        public System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas) { throw null; }
        public enum InferenceOption
        {
            Relaxed = 1,
            Restricted = 0,
        }
    }
    [System.SerializableAttribute]
    public partial class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
    {
        public XmlSchemaInferenceException() { }
        protected XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlSchemaInferenceException(string message) { }
        public XmlSchemaInferenceException(string message, System.Exception innerException) { }
        public XmlSchemaInferenceException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class XmlSchemaInfo : System.Xml.Schema.IXmlSchemaInfo
    {
        public XmlSchemaInfo() { }
        public System.Xml.Schema.XmlSchemaContentType ContentType { get { throw null; } set { } }
        public bool IsDefault { get { throw null; } set { } }
        public bool IsNil { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSimpleType MemberType { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaAttribute SchemaAttribute { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaElement SchemaElement { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaType SchemaType { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaValidity Validity { get { throw null; } set { } }
    }
    public partial class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
    {
        public XmlSchemaKey() { }
    }
    public partial class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
    {
        public XmlSchemaKeyref() { }
        [System.Xml.Serialization.XmlAttributeAttribute("refer")]
        public System.Xml.XmlQualifiedName Refer { get { throw null; } set { } }
    }
    public partial class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaLengthFacet() { }
    }
    public partial class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMaxExclusiveFacet() { }
    }
    public partial class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMaxInclusiveFacet() { }
    }
    public partial class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaMaxLengthFacet() { }
    }
    public partial class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMinExclusiveFacet() { }
    }
    public partial class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaMinInclusiveFacet() { }
    }
    public partial class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaMinLengthFacet() { }
    }
    public partial class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaNotation() { }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("public")]
        public string Public { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("system")]
        public string System { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
    {
        protected XmlSchemaNumericFacet() { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class XmlSchemaObject
    {
        protected XmlSchemaObject() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int LineNumber { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int LinePosition { get { throw null; } set { } }
        [System.Xml.Serialization.XmlNamespaceDeclarationsAttribute]
        public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObject Parent { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string SourceUri { get { throw null; } set { } }
    }
    public partial class XmlSchemaObjectCollection : System.Collections.CollectionBase
    {
        public XmlSchemaObjectCollection() { }
        public XmlSchemaObjectCollection(System.Xml.Schema.XmlSchemaObject parent) { }
        public virtual System.Xml.Schema.XmlSchemaObject this[int index] { get { throw null; } set { } }
        public int Add(System.Xml.Schema.XmlSchemaObject item) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchemaObject item) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchemaObject[] array, int index) { }
        public new System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Xml.Schema.XmlSchemaObject item) { throw null; }
        public void Insert(int index, System.Xml.Schema.XmlSchemaObject item) { }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object item) { }
        protected override void OnRemove(int index, object item) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        public void Remove(System.Xml.Schema.XmlSchemaObject item) { }
    }
    public partial class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
    {
        internal XmlSchemaObjectEnumerator() { }
        public System.Xml.Schema.XmlSchemaObject Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class XmlSchemaObjectTable
    {
        internal XmlSchemaObjectTable() { }
        public int Count { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObject this[System.Xml.XmlQualifiedName name] { get { throw null; } }
        public System.Collections.ICollection Names { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public bool Contains(System.Xml.XmlQualifiedName name) { throw null; }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
    }
    public abstract partial class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaParticle() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public decimal MaxOccurs { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("maxOccurs")]
        public string MaxOccursString { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public decimal MinOccurs { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("minOccurs")]
        public string MinOccursString { get { throw null; } set { } }
    }
    public partial class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaPatternFacet() { }
    }
    public partial class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
    {
        public XmlSchemaRedefine() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable AttributeGroups { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable Groups { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("annotation", typeof(System.Xml.Schema.XmlSchemaAnnotation))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroup))]
        [System.Xml.Serialization.XmlElementAttribute("complexType", typeof(System.Xml.Schema.XmlSchemaComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroup))]
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaObjectTable SchemaTypes { get { throw null; } }
    }
    public partial class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
    {
        public XmlSchemaSequence() { }
        [System.Xml.Serialization.XmlElementAttribute("any", typeof(System.Xml.Schema.XmlSchemaAny))]
        [System.Xml.Serialization.XmlElementAttribute("choice", typeof(System.Xml.Schema.XmlSchemaChoice))]
        [System.Xml.Serialization.XmlElementAttribute("element", typeof(System.Xml.Schema.XmlSchemaElement))]
        [System.Xml.Serialization.XmlElementAttribute("group", typeof(System.Xml.Schema.XmlSchemaGroupRef))]
        [System.Xml.Serialization.XmlElementAttribute("sequence", typeof(System.Xml.Schema.XmlSchemaSequence))]
        public override System.Xml.Schema.XmlSchemaObjectCollection Items { get { throw null; } }
    }
    public partial class XmlSchemaSet
    {
        public XmlSchemaSet() { }
        public XmlSchemaSet(System.Xml.XmlNameTable nameTable) { }
        public System.Xml.Schema.XmlSchemaCompilationSettings CompilationSettings { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObjectTable GlobalAttributes { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObjectTable GlobalElements { get { throw null; } }
        public System.Xml.Schema.XmlSchemaObjectTable GlobalTypes { get { throw null; } }
        public bool IsCompiled { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public System.Xml.Schema.XmlSchema Add(string targetNamespace, string schemaUri) { throw null; }
        public System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.XmlReader schemaDocument) { throw null; }
        public System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void Add(System.Xml.Schema.XmlSchemaSet schemas) { }
        public void Compile() { }
        public bool Contains(string targetNamespace) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index) { }
        public System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema) { throw null; }
        public bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove) { throw null; }
        public System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema) { throw null; }
        public System.Collections.ICollection Schemas() { throw null; }
        public System.Collections.ICollection Schemas(string targetNamespace) { throw null; }
    }
    public partial class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
    {
        public XmlSchemaSimpleContent() { }
        [System.Xml.Serialization.XmlElementAttribute("extension", typeof(System.Xml.Schema.XmlSchemaSimpleContentExtension))]
        [System.Xml.Serialization.XmlElementAttribute("restriction", typeof(System.Xml.Schema.XmlSchemaSimpleContentRestriction))]
        public override System.Xml.Schema.XmlSchemaContent Content { get { throw null; } set { } }
    }
    public partial class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaSimpleContentExtension() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
    }
    public partial class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
    {
        public XmlSchemaSimpleContentRestriction() { }
        [System.Xml.Serialization.XmlElementAttribute("anyAttribute")]
        public System.Xml.Schema.XmlSchemaAnyAttribute AnyAttribute { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("attribute", typeof(System.Xml.Schema.XmlSchemaAttribute))]
        [System.Xml.Serialization.XmlElementAttribute("attributeGroup", typeof(System.Xml.Schema.XmlSchemaAttributeGroupRef))]
        public System.Xml.Schema.XmlSchemaObjectCollection Attributes { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaSimpleType BaseType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("enumeration", typeof(System.Xml.Schema.XmlSchemaEnumerationFacet))]
        [System.Xml.Serialization.XmlElementAttribute("fractionDigits", typeof(System.Xml.Schema.XmlSchemaFractionDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("length", typeof(System.Xml.Schema.XmlSchemaLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxExclusive", typeof(System.Xml.Schema.XmlSchemaMaxExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxInclusive", typeof(System.Xml.Schema.XmlSchemaMaxInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxLength", typeof(System.Xml.Schema.XmlSchemaMaxLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minExclusive", typeof(System.Xml.Schema.XmlSchemaMinExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minInclusive", typeof(System.Xml.Schema.XmlSchemaMinInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minLength", typeof(System.Xml.Schema.XmlSchemaMinLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("pattern", typeof(System.Xml.Schema.XmlSchemaPatternFacet))]
        [System.Xml.Serialization.XmlElementAttribute("totalDigits", typeof(System.Xml.Schema.XmlSchemaTotalDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("whiteSpace", typeof(System.Xml.Schema.XmlSchemaWhiteSpaceFacet))]
        public System.Xml.Schema.XmlSchemaObjectCollection Facets { get { throw null; } }
    }
    public partial class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
    {
        public XmlSchemaSimpleType() { }
        [System.Xml.Serialization.XmlElementAttribute("list", typeof(System.Xml.Schema.XmlSchemaSimpleTypeList))]
        [System.Xml.Serialization.XmlElementAttribute("restriction", typeof(System.Xml.Schema.XmlSchemaSimpleTypeRestriction))]
        [System.Xml.Serialization.XmlElementAttribute("union", typeof(System.Xml.Schema.XmlSchemaSimpleTypeUnion))]
        public System.Xml.Schema.XmlSchemaSimpleTypeContent Content { get { throw null; } set { } }
    }
    public abstract partial class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
    {
        protected XmlSchemaSimpleTypeContent() { }
    }
    public partial class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
    {
        public XmlSchemaSimpleTypeList() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaSimpleType BaseItemType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaSimpleType ItemType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("itemType")]
        public System.Xml.XmlQualifiedName ItemTypeName { get { throw null; } set { } }
    }
    public partial class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
    {
        public XmlSchemaSimpleTypeRestriction() { }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaSimpleType BaseType { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("base")]
        public System.Xml.XmlQualifiedName BaseTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("enumeration", typeof(System.Xml.Schema.XmlSchemaEnumerationFacet))]
        [System.Xml.Serialization.XmlElementAttribute("fractionDigits", typeof(System.Xml.Schema.XmlSchemaFractionDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("length", typeof(System.Xml.Schema.XmlSchemaLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxExclusive", typeof(System.Xml.Schema.XmlSchemaMaxExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxInclusive", typeof(System.Xml.Schema.XmlSchemaMaxInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("maxLength", typeof(System.Xml.Schema.XmlSchemaMaxLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minExclusive", typeof(System.Xml.Schema.XmlSchemaMinExclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minInclusive", typeof(System.Xml.Schema.XmlSchemaMinInclusiveFacet))]
        [System.Xml.Serialization.XmlElementAttribute("minLength", typeof(System.Xml.Schema.XmlSchemaMinLengthFacet))]
        [System.Xml.Serialization.XmlElementAttribute("pattern", typeof(System.Xml.Schema.XmlSchemaPatternFacet))]
        [System.Xml.Serialization.XmlElementAttribute("totalDigits", typeof(System.Xml.Schema.XmlSchemaTotalDigitsFacet))]
        [System.Xml.Serialization.XmlElementAttribute("whiteSpace", typeof(System.Xml.Schema.XmlSchemaWhiteSpaceFacet))]
        public System.Xml.Schema.XmlSchemaObjectCollection Facets { get { throw null; } }
    }
    public partial class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
    {
        public XmlSchemaSimpleTypeUnion() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaSimpleType[] BaseMemberTypes { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("simpleType", typeof(System.Xml.Schema.XmlSchemaSimpleType))]
        public System.Xml.Schema.XmlSchemaObjectCollection BaseTypes { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("memberTypes")]
        public System.Xml.XmlQualifiedName[] MemberTypes { get { throw null; } set { } }
    }
    public partial class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
    {
        public XmlSchemaTotalDigitsFacet() { }
    }
    public partial class XmlSchemaType : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaType() { }
        [System.ObsoleteAttribute("This property has been deprecated. Please use BaseXmlSchemaType property that returns a strongly typed base schema type. http://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public object BaseSchemaType { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaType BaseXmlSchemaType { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDatatype Datatype { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod DerivedBy { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Schema.XmlSchemaDerivationMethod)(256))]
        [System.Xml.Serialization.XmlAttributeAttribute("final")]
        public System.Xml.Schema.XmlSchemaDerivationMethod Final { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchemaDerivationMethod FinalResolved { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public virtual bool IsMixed { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlQualifiedName QualifiedName { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlTypeCode TypeCode { get { throw null; } }
        public static System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.Schema.XmlTypeCode typeCode) { throw null; }
        public static System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName) { throw null; }
        public static System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode) { throw null; }
        public static System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName) { throw null; }
        public static bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except) { throw null; }
    }
    public partial class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
    {
        public XmlSchemaUnique() { }
    }
    public enum XmlSchemaUse
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
        [System.Xml.Serialization.XmlEnumAttribute("optional")]
        Optional = 1,
        [System.Xml.Serialization.XmlEnumAttribute("prohibited")]
        Prohibited = 2,
        [System.Xml.Serialization.XmlEnumAttribute("required")]
        Required = 3,
    }
    [System.SerializableAttribute]
    public partial class XmlSchemaValidationException : System.Xml.Schema.XmlSchemaException
    {
        public XmlSchemaValidationException() { }
        protected XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlSchemaValidationException(string message) { }
        public XmlSchemaValidationException(string message, System.Exception innerException) { }
        public XmlSchemaValidationException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public object SourceObject { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected internal void SetSourceObject(object sourceObject) { }
    }
    [System.FlagsAttribute]
    public enum XmlSchemaValidationFlags
    {
        AllowXmlAttributes = 16,
        None = 0,
        ProcessIdentityConstraints = 8,
        ProcessInlineSchema = 1,
        ProcessSchemaLocation = 2,
        ReportValidationWarnings = 4,
    }
    public sealed partial class XmlSchemaValidator
    {
        public XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags) { }
        public System.Xml.IXmlLineInfo LineInfoProvider { get { throw null; } set { } }
        public System.Uri SourceUri { get { throw null; } set { } }
        public object ValidationEventSender { get { throw null; } set { } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public void AddSchema(System.Xml.Schema.XmlSchema schema) { }
        public void EndValidation() { }
        public System.Xml.Schema.XmlSchemaAttribute[] GetExpectedAttributes() { throw null; }
        public System.Xml.Schema.XmlSchemaParticle[] GetExpectedParticles() { throw null; }
        public void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes) { }
        public void Initialize() { }
        public void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType) { }
        public void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        public object ValidateAttribute(string localName, string namespaceUri, string attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo) { throw null; }
        public object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo) { throw null; }
        public void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        public void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }
        public object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo) { throw null; }
        public object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue) { throw null; }
        public void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        public void ValidateText(string elementValue) { }
        public void ValidateText(System.Xml.Schema.XmlValueGetter elementValue) { }
        public void ValidateWhitespace(string elementValue) { }
        public void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue) { }
    }
    public enum XmlSchemaValidity
    {
        Invalid = 2,
        NotKnown = 0,
        Valid = 1,
    }
    public partial class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
    {
        public XmlSchemaWhiteSpaceFacet() { }
    }
    public partial class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
    {
        public XmlSchemaXPath() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("xpath")]
        public string XPath { get { throw null; } set { } }
    }
    public enum XmlSeverityType
    {
        Error = 0,
        Warning = 1,
    }
    public enum XmlTypeCode
    {
        AnyAtomicType = 10,
        AnyUri = 28,
        Attribute = 5,
        Base64Binary = 27,
        Boolean = 13,
        Byte = 46,
        Comment = 8,
        Date = 20,
        DateTime = 18,
        DayTimeDuration = 54,
        Decimal = 14,
        Document = 3,
        Double = 16,
        Duration = 17,
        Element = 4,
        Entity = 39,
        Float = 15,
        GDay = 24,
        GMonth = 25,
        GMonthDay = 23,
        GYear = 22,
        GYearMonth = 21,
        HexBinary = 26,
        Id = 37,
        Idref = 38,
        Int = 44,
        Integer = 40,
        Item = 1,
        Language = 33,
        Long = 43,
        Name = 35,
        Namespace = 6,
        NCName = 36,
        NegativeInteger = 42,
        NmToken = 34,
        Node = 2,
        None = 0,
        NonNegativeInteger = 47,
        NonPositiveInteger = 41,
        NormalizedString = 31,
        Notation = 30,
        PositiveInteger = 52,
        ProcessingInstruction = 7,
        QName = 29,
        Short = 45,
        String = 12,
        Text = 9,
        Time = 19,
        Token = 32,
        UnsignedByte = 51,
        UnsignedInt = 49,
        UnsignedLong = 48,
        UnsignedShort = 50,
        UntypedAtomic = 11,
        YearMonthDuration = 53,
    }
    public delegate object XmlValueGetter();
}
namespace System.Xml.Serialization
{
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class CodeExporter
    {
        internal CodeExporter() { }
        public System.CodeDom.CodeAttributeDeclarationCollection IncludeMetadata { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum CodeGenerationOptions
    {
        [System.Xml.Serialization.XmlEnumAttribute("enableDataBinding")]
        EnableDataBinding = 16,
        [System.Xml.Serialization.XmlEnumAttribute("newAsync")]
        GenerateNewAsync = 2,
        [System.Xml.Serialization.XmlEnumAttribute("oldAsync")]
        GenerateOldAsync = 4,
        [System.Xml.Serialization.XmlEnumAttribute("order")]
        GenerateOrder = 8,
        [System.Xml.Serialization.XmlEnumAttribute("properties")]
        GenerateProperties = 1,
        [System.Xml.Serialization.XmlIgnoreAttribute]
        None = 0,
    }
    public partial class CodeIdentifier
    {
        [System.ObsoleteAttribute("This class should never get constructed as it contains only static methods.")]
        public CodeIdentifier() { }
        public static string MakeCamel(string identifier) { throw null; }
        public static string MakePascal(string identifier) { throw null; }
        public static string MakeValid(string identifier) { throw null; }
    }
    public partial class CodeIdentifiers
    {
        public CodeIdentifiers() { }
        public CodeIdentifiers(bool caseSensitive) { }
        public bool UseCamelCasing { get { throw null; } set { } }
        public void Add(string identifier, object value) { }
        public void AddReserved(string identifier) { }
        public string AddUnique(string identifier, object value) { throw null; }
        public void Clear() { }
        public bool IsInUse(string identifier) { throw null; }
        public string MakeRightCase(string identifier) { throw null; }
        public string MakeUnique(string identifier) { throw null; }
        public void Remove(string identifier) { }
        public void RemoveReserved(string identifier) { }
        public object ToArray(System.Type type) { throw null; }
    }
    public partial class ImportContext
    {
        public ImportContext(System.Xml.Serialization.CodeIdentifiers identifiers, bool shareTypes) { }
        public bool ShareTypes { get { throw null; } }
        public System.Xml.Serialization.CodeIdentifiers TypeIdentifiers { get { throw null; } }
        public System.Collections.Specialized.StringCollection Warnings { get { throw null; } }
    }
    public partial interface IXmlSerializable
    {
        System.Xml.Schema.XmlSchema GetSchema();
        void ReadXml(System.Xml.XmlReader reader);
        void WriteXml(System.Xml.XmlWriter writer);
    }
    public partial interface IXmlTextParser
    {
        bool Normalized { get; set; }
        System.Xml.WhitespaceHandling WhitespaceHandling { get; set; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class SchemaImporter
    {
        internal SchemaImporter() { }
        public System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection Extensions { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
    public partial class SoapAttributeAttribute : System.Attribute
    {
        public SoapAttributeAttribute() { }
        public SoapAttributeAttribute(string attributeName) { }
        public string AttributeName { get { throw null; } set { } }
        public string DataType { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
    }
    public partial class SoapAttributeOverrides
    {
        public SoapAttributeOverrides() { }
        public System.Xml.Serialization.SoapAttributes this[System.Type type] { get { throw null; } }
        public System.Xml.Serialization.SoapAttributes this[System.Type type, string member] { get { throw null; } }
        public void Add(System.Type type, string member, System.Xml.Serialization.SoapAttributes attributes) { }
        public void Add(System.Type type, System.Xml.Serialization.SoapAttributes attributes) { }
    }
    public partial class SoapAttributes
    {
        public SoapAttributes() { }
        public SoapAttributes(System.Reflection.ICustomAttributeProvider provider) { }
        public System.Xml.Serialization.SoapAttributeAttribute SoapAttribute { get { throw null; } set { } }
        public object SoapDefaultValue { get { throw null; } set { } }
        public System.Xml.Serialization.SoapElementAttribute SoapElement { get { throw null; } set { } }
        public System.Xml.Serialization.SoapEnumAttribute SoapEnum { get { throw null; } set { } }
        public bool SoapIgnore { get { throw null; } set { } }
        public System.Xml.Serialization.SoapTypeAttribute SoapType { get { throw null; } set { } }
    }
    public partial class SoapCodeExporter : System.Xml.Serialization.CodeExporter
    {
        public SoapCodeExporter(System.CodeDom.CodeNamespace codeNamespace) { }
        public SoapCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit) { }
        public SoapCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Xml.Serialization.CodeGenerationOptions options, System.Collections.Hashtable mappings) { }
        public SoapCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.Xml.Serialization.CodeGenerationOptions options) { }
        public SoapCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.Xml.Serialization.CodeGenerationOptions options, System.Collections.Hashtable mappings) { }
        public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, System.Xml.Serialization.XmlMemberMapping member) { }
        public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, System.Xml.Serialization.XmlMemberMapping member, bool forceUseMemberName) { }
        public void ExportMembersMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping) { }
        public void ExportTypeMapping(System.Xml.Serialization.XmlTypeMapping xmlTypeMapping) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
    public partial class SoapElementAttribute : System.Attribute
    {
        public SoapElementAttribute() { }
        public SoapElementAttribute(string elementName) { }
        public string DataType { get { throw null; } set { } }
        public string ElementName { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    public partial class SoapEnumAttribute : System.Attribute
    {
        public SoapEnumAttribute() { }
        public SoapEnumAttribute(string name) { }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
    public partial class SoapIgnoreAttribute : System.Attribute
    {
        public SoapIgnoreAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1100), AllowMultiple=true)]
    public partial class SoapIncludeAttribute : System.Attribute
    {
        public SoapIncludeAttribute(System.Type type) { }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial class SoapReflectionImporter
    {
        public SoapReflectionImporter() { }
        public SoapReflectionImporter(string defaultNamespace) { }
        public SoapReflectionImporter(System.Xml.Serialization.SoapAttributeOverrides attributeOverrides) { }
        public SoapReflectionImporter(System.Xml.Serialization.SoapAttributeOverrides attributeOverrides, string defaultNamespace) { }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement, bool writeAccessors) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement, bool writeAccessors, bool validate) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement, bool writeAccessors, bool validate, System.Xml.Serialization.XmlMappingAccess access) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace) { throw null; }
        public void IncludeType(System.Type type) { }
        public void IncludeTypes(System.Reflection.ICustomAttributeProvider provider) { }
    }
    public partial class SoapSchemaExporter
    {
        public SoapSchemaExporter(System.Xml.Serialization.XmlSchemas schemas) { }
        public void ExportMembersMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping) { }
        public void ExportMembersMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping, bool exportEnclosingType) { }
        public void ExportTypeMapping(System.Xml.Serialization.XmlTypeMapping xmlTypeMapping) { }
    }
    public partial class SoapSchemaImporter : System.Xml.Serialization.SchemaImporter
    {
        public SoapSchemaImporter(System.Xml.Serialization.XmlSchemas schemas) { }
        public SoapSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Xml.Serialization.ImportContext context) { }
        public SoapSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeGenerationOptions options, System.Xml.Serialization.ImportContext context) { }
        public SoapSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeIdentifiers typeIdentifiers) { }
        public SoapSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeIdentifiers typeIdentifiers, System.Xml.Serialization.CodeGenerationOptions options) { }
        public System.Xml.Serialization.XmlTypeMapping ImportDerivedTypeMapping(System.Xml.XmlQualifiedName name, System.Type baseType, bool baseTypeCanBeIndirect) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string name, string ns, System.Xml.Serialization.SoapSchemaMember member) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string name, string ns, System.Xml.Serialization.SoapSchemaMember[] members) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string name, string ns, System.Xml.Serialization.SoapSchemaMember[] members, bool hasWrapperElement) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string name, string ns, System.Xml.Serialization.SoapSchemaMember[] members, bool hasWrapperElement, System.Type baseType, bool baseTypeCanBeIndirect) { throw null; }
    }
    public partial class SoapSchemaMember
    {
        public SoapSchemaMember() { }
        public string MemberName { get { throw null; } set { } }
        public System.Xml.XmlQualifiedName MemberType { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1052))]
    public partial class SoapTypeAttribute : System.Attribute
    {
        public SoapTypeAttribute() { }
        public SoapTypeAttribute(string typeName) { }
        public SoapTypeAttribute(string typeName, string ns) { }
        public bool IncludeInSchema { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
    }
    public partial class UnreferencedObjectEventArgs : System.EventArgs
    {
        public UnreferencedObjectEventArgs(object o, string id) { }
        public string UnreferencedId { get { throw null; } }
        public object UnreferencedObject { get { throw null; } }
    }
    public delegate void UnreferencedObjectEventHandler(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e);
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
    public partial class XmlAnyAttributeAttribute : System.Attribute
    {
        public XmlAnyAttributeAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=true)]
    public partial class XmlAnyElementAttribute : System.Attribute
    {
        public XmlAnyElementAttribute() { }
        public XmlAnyElementAttribute(string name) { }
        public XmlAnyElementAttribute(string name, string ns) { }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
    }
    public partial class XmlAnyElementAttributes : System.Collections.CollectionBase
    {
        public XmlAnyElementAttributes() { }
        public System.Xml.Serialization.XmlAnyElementAttribute this[int index] { get { throw null; } set { } }
        public int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute) { throw null; }
        public bool Contains(System.Xml.Serialization.XmlAnyElementAttribute attribute) { throw null; }
        public void CopyTo(System.Xml.Serialization.XmlAnyElementAttribute[] array, int index) { }
        public int IndexOf(System.Xml.Serialization.XmlAnyElementAttribute attribute) { throw null; }
        public void Insert(int index, System.Xml.Serialization.XmlAnyElementAttribute attribute) { }
        public void Remove(System.Xml.Serialization.XmlAnyElementAttribute attribute) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
    public partial class XmlArrayAttribute : System.Attribute
    {
        public XmlArrayAttribute() { }
        public XmlArrayAttribute(string elementName) { }
        public string ElementName { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=true)]
    public partial class XmlArrayItemAttribute : System.Attribute
    {
        public XmlArrayItemAttribute() { }
        public XmlArrayItemAttribute(string elementName) { }
        public XmlArrayItemAttribute(string elementName, System.Type type) { }
        public XmlArrayItemAttribute(System.Type type) { }
        public string DataType { get { throw null; } set { } }
        public string ElementName { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public int NestingLevel { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial class XmlArrayItemAttributes : System.Collections.CollectionBase
    {
        public XmlArrayItemAttributes() { }
        public System.Xml.Serialization.XmlArrayItemAttribute this[int index] { get { throw null; } set { } }
        public int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute) { throw null; }
        public bool Contains(System.Xml.Serialization.XmlArrayItemAttribute attribute) { throw null; }
        public void CopyTo(System.Xml.Serialization.XmlArrayItemAttribute[] array, int index) { }
        public int IndexOf(System.Xml.Serialization.XmlArrayItemAttribute attribute) { throw null; }
        public void Insert(int index, System.Xml.Serialization.XmlArrayItemAttribute attribute) { }
        public void Remove(System.Xml.Serialization.XmlArrayItemAttribute attribute) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
    public partial class XmlAttributeAttribute : System.Attribute
    {
        public XmlAttributeAttribute() { }
        public XmlAttributeAttribute(string attributeName) { }
        public XmlAttributeAttribute(string attributeName, System.Type type) { }
        public XmlAttributeAttribute(System.Type type) { }
        public string AttributeName { get { throw null; } set { } }
        public string DataType { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial class XmlAttributeEventArgs : System.EventArgs
    {
        internal XmlAttributeEventArgs() { }
        public System.Xml.XmlAttribute Attr { get { throw null; } }
        public string ExpectedAttributes { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public object ObjectBeingDeserialized { get { throw null; } }
    }
    public delegate void XmlAttributeEventHandler(object sender, System.Xml.Serialization.XmlAttributeEventArgs e);
    public partial class XmlAttributeOverrides
    {
        public XmlAttributeOverrides() { }
        public System.Xml.Serialization.XmlAttributes this[System.Type type] { get { throw null; } }
        public System.Xml.Serialization.XmlAttributes this[System.Type type, string member] { get { throw null; } }
        public void Add(System.Type type, string member, System.Xml.Serialization.XmlAttributes attributes) { }
        public void Add(System.Type type, System.Xml.Serialization.XmlAttributes attributes) { }
    }
    public partial class XmlAttributes
    {
        public XmlAttributes() { }
        public XmlAttributes(System.Reflection.ICustomAttributeProvider provider) { }
        public System.Xml.Serialization.XmlAnyAttributeAttribute XmlAnyAttribute { get { throw null; } set { } }
        public System.Xml.Serialization.XmlAnyElementAttributes XmlAnyElements { get { throw null; } }
        public System.Xml.Serialization.XmlArrayAttribute XmlArray { get { throw null; } set { } }
        public System.Xml.Serialization.XmlArrayItemAttributes XmlArrayItems { get { throw null; } }
        public System.Xml.Serialization.XmlAttributeAttribute XmlAttribute { get { throw null; } set { } }
        public System.Xml.Serialization.XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get { throw null; } }
        public object XmlDefaultValue { get { throw null; } set { } }
        public System.Xml.Serialization.XmlElementAttributes XmlElements { get { throw null; } }
        public System.Xml.Serialization.XmlEnumAttribute XmlEnum { get { throw null; } set { } }
        public bool XmlIgnore { get { throw null; } set { } }
        public bool Xmlns { get { throw null; } set { } }
        public System.Xml.Serialization.XmlRootAttribute XmlRoot { get { throw null; } set { } }
        public System.Xml.Serialization.XmlTextAttribute XmlText { get { throw null; } set { } }
        public System.Xml.Serialization.XmlTypeAttribute XmlType { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
    public partial class XmlChoiceIdentifierAttribute : System.Attribute
    {
        public XmlChoiceIdentifierAttribute() { }
        public XmlChoiceIdentifierAttribute(string name) { }
        public string MemberName { get { throw null; } set { } }
    }
    public partial class XmlCodeExporter : System.Xml.Serialization.CodeExporter
    {
        public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace) { }
        public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit) { }
        public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Xml.Serialization.CodeGenerationOptions options, System.Collections.Hashtable mappings) { }
        public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.Xml.Serialization.CodeGenerationOptions options) { }
        public XmlCodeExporter(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit, System.Xml.Serialization.CodeGenerationOptions options, System.Collections.Hashtable mappings) { }
        public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, System.Xml.Serialization.XmlMemberMapping member, string ns) { }
        public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, System.Xml.Serialization.XmlMemberMapping member, string ns, bool forceUseMemberName) { }
        public void AddMappingMetadata(System.CodeDom.CodeAttributeDeclarationCollection metadata, System.Xml.Serialization.XmlTypeMapping mapping, string ns) { }
        public void ExportMembersMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping) { }
        public void ExportTypeMapping(System.Xml.Serialization.XmlTypeMapping xmlTypeMapping) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XmlDeserializationEvents
    {
        public System.Xml.Serialization.XmlAttributeEventHandler OnUnknownAttribute { get { throw null; } set { } }
        public System.Xml.Serialization.XmlElementEventHandler OnUnknownElement { get { throw null; } set { } }
        public System.Xml.Serialization.XmlNodeEventHandler OnUnknownNode { get { throw null; } set { } }
        public System.Xml.Serialization.UnreferencedObjectEventHandler OnUnreferencedObject { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=true)]
    public partial class XmlElementAttribute : System.Attribute
    {
        public XmlElementAttribute() { }
        public XmlElementAttribute(string elementName) { }
        public XmlElementAttribute(string elementName, System.Type type) { }
        public XmlElementAttribute(System.Type type) { }
        public string DataType { get { throw null; } set { } }
        public string ElementName { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaForm Form { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial class XmlElementAttributes : System.Collections.CollectionBase
    {
        public XmlElementAttributes() { }
        public System.Xml.Serialization.XmlElementAttribute this[int index] { get { throw null; } set { } }
        public int Add(System.Xml.Serialization.XmlElementAttribute attribute) { throw null; }
        public bool Contains(System.Xml.Serialization.XmlElementAttribute attribute) { throw null; }
        public void CopyTo(System.Xml.Serialization.XmlElementAttribute[] array, int index) { }
        public int IndexOf(System.Xml.Serialization.XmlElementAttribute attribute) { throw null; }
        public void Insert(int index, System.Xml.Serialization.XmlElementAttribute attribute) { }
        public void Remove(System.Xml.Serialization.XmlElementAttribute attribute) { }
    }
    public partial class XmlElementEventArgs : System.EventArgs
    {
        internal XmlElementEventArgs() { }
        public System.Xml.XmlElement Element { get { throw null; } }
        public string ExpectedElements { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public object ObjectBeingDeserialized { get { throw null; } }
    }
    public delegate void XmlElementEventHandler(object sender, System.Xml.Serialization.XmlElementEventArgs e);
    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    public partial class XmlEnumAttribute : System.Attribute
    {
        public XmlEnumAttribute() { }
        public XmlEnumAttribute(string name) { }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
    public partial class XmlIgnoreAttribute : System.Attribute
    {
        public XmlIgnoreAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1100), AllowMultiple=true)]
    public partial class XmlIncludeAttribute : System.Attribute
    {
        public XmlIncludeAttribute(System.Type type) { }
        public System.Type Type { get { throw null; } set { } }
    }
    public abstract partial class XmlMapping
    {
        internal XmlMapping() { }
        public string ElementName { get { throw null; } }
        public string Namespace { get { throw null; } }
        public string XsdElementName { get { throw null; } }
        public void SetKey(string key) { }
    }
    [System.FlagsAttribute]
    public enum XmlMappingAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
    }
    public partial class XmlMemberMapping
    {
        internal XmlMemberMapping() { }
        public bool Any { get { throw null; } }
        public bool CheckSpecified { get { throw null; } }
        public string ElementName { get { throw null; } }
        public string MemberName { get { throw null; } }
        public string Namespace { get { throw null; } }
        public string TypeFullName { get { throw null; } }
        public string TypeName { get { throw null; } }
        public string TypeNamespace { get { throw null; } }
        public string XsdElementName { get { throw null; } }
        public string GenerateTypeName(System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
    }
    public partial class XmlMembersMapping : System.Xml.Serialization.XmlMapping
    {
        internal XmlMembersMapping() { }
        public int Count { get { throw null; } }
        public System.Xml.Serialization.XmlMemberMapping this[int index] { get { throw null; } }
        public string TypeName { get { throw null; } }
        public string TypeNamespace { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
    public partial class XmlNamespaceDeclarationsAttribute : System.Attribute
    {
        public XmlNamespaceDeclarationsAttribute() { }
    }
    public partial class XmlNodeEventArgs : System.EventArgs
    {
        internal XmlNodeEventArgs() { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public string LocalName { get { throw null; } }
        public string Name { get { throw null; } }
        public string NamespaceURI { get { throw null; } }
        public System.Xml.XmlNodeType NodeType { get { throw null; } }
        public object ObjectBeingDeserialized { get { throw null; } }
        public string Text { get { throw null; } }
    }
    public delegate void XmlNodeEventHandler(object sender, System.Xml.Serialization.XmlNodeEventArgs e);
    public partial class XmlReflectionImporter
    {
        public XmlReflectionImporter() { }
        public XmlReflectionImporter(string defaultNamespace) { }
        public XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides) { }
        public XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement, bool rpc) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement, bool rpc, bool openModel) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string elementName, string ns, System.Xml.Serialization.XmlReflectionMember[] members, bool hasWrapperElement, bool rpc, bool openModel, System.Xml.Serialization.XmlMappingAccess access) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace) { throw null; }
        public void IncludeType(System.Type type) { }
        public void IncludeTypes(System.Reflection.ICustomAttributeProvider provider) { }
    }
    public partial class XmlReflectionMember
    {
        public XmlReflectionMember() { }
        public bool IsReturnValue { get { throw null; } set { } }
        public string MemberName { get { throw null; } set { } }
        public System.Type MemberType { get { throw null; } set { } }
        public bool OverrideIsNullable { get { throw null; } set { } }
        public System.Xml.Serialization.SoapAttributes SoapAttributes { get { throw null; } set { } }
        public System.Xml.Serialization.XmlAttributes XmlAttributes { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(9244))]
    public partial class XmlRootAttribute : System.Attribute
    {
        public XmlRootAttribute() { }
        public XmlRootAttribute(string elementName) { }
        public string DataType { get { throw null; } set { } }
        public string ElementName { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
    }
    public partial class XmlSchemaEnumerator : System.Collections.Generic.IEnumerator<System.Xml.Schema.XmlSchema>, System.Collections.IEnumerator, System.IDisposable
    {
        public XmlSchemaEnumerator(System.Xml.Serialization.XmlSchemas list) { }
        public System.Xml.Schema.XmlSchema Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public void Dispose() { }
        public bool MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class XmlSchemaExporter
    {
        public XmlSchemaExporter(System.Xml.Serialization.XmlSchemas schemas) { }
        public string ExportAnyType(string ns) { throw null; }
        public string ExportAnyType(System.Xml.Serialization.XmlMembersMapping members) { throw null; }
        public void ExportMembersMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping) { }
        public void ExportMembersMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping, bool exportEnclosingType) { }
        public System.Xml.XmlQualifiedName ExportTypeMapping(System.Xml.Serialization.XmlMembersMapping xmlMembersMapping) { throw null; }
        public void ExportTypeMapping(System.Xml.Serialization.XmlTypeMapping xmlTypeMapping) { }
    }
    public partial class XmlSchemaImporter : System.Xml.Serialization.SchemaImporter
    {
        public XmlSchemaImporter(System.Xml.Serialization.XmlSchemas schemas) { }
        public XmlSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Xml.Serialization.ImportContext context) { }
        public XmlSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeGenerationOptions options, System.Xml.Serialization.ImportContext context) { }
        public XmlSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeIdentifiers typeIdentifiers) { }
        public XmlSchemaImporter(System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.CodeIdentifiers typeIdentifiers, System.Xml.Serialization.CodeGenerationOptions options) { }
        public System.Xml.Serialization.XmlMembersMapping ImportAnyType(System.Xml.XmlQualifiedName typeName, string elementName) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportDerivedTypeMapping(System.Xml.XmlQualifiedName name, System.Type baseType) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportDerivedTypeMapping(System.Xml.XmlQualifiedName name, System.Type baseType, bool baseTypeCanBeIndirect) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(string name, string ns, System.Xml.Serialization.SoapSchemaMember[] members) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(System.Xml.XmlQualifiedName name) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(System.Xml.XmlQualifiedName[] names) { throw null; }
        public System.Xml.Serialization.XmlMembersMapping ImportMembersMapping(System.Xml.XmlQualifiedName[] names, System.Type baseType, bool baseTypeCanBeIndirect) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportSchemaType(System.Xml.XmlQualifiedName typeName) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportSchemaType(System.Xml.XmlQualifiedName typeName, System.Type baseType) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportSchemaType(System.Xml.XmlQualifiedName typeName, System.Type baseType, bool baseTypeCanBeIndirect) { throw null; }
        public System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.XmlQualifiedName name) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1036))]
    public sealed partial class XmlSchemaProviderAttribute : System.Attribute
    {
        public XmlSchemaProviderAttribute(string methodName) { }
        public bool IsAny { get { throw null; } set { } }
        public string MethodName { get { throw null; } }
    }
    public partial class XmlSchemas : System.Collections.CollectionBase, System.Collections.Generic.IEnumerable<System.Xml.Schema.XmlSchema>, System.Collections.IEnumerable
    {
        public XmlSchemas() { }
        public bool IsCompiled { get { throw null; } }
        public System.Xml.Schema.XmlSchema this[int index] { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchema this[string ns] { get { throw null; } }
        public int Add(System.Xml.Schema.XmlSchema schema) { throw null; }
        public int Add(System.Xml.Schema.XmlSchema schema, System.Uri baseUri) { throw null; }
        public void Add(System.Xml.Serialization.XmlSchemas schemas) { }
        public void AddReference(System.Xml.Schema.XmlSchema schema) { }
        public void Compile(System.Xml.Schema.ValidationEventHandler handler, bool fullCompile) { }
        public bool Contains(string targetNamespace) { throw null; }
        public bool Contains(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void CopyTo(System.Xml.Schema.XmlSchema[] array, int index) { }
        public object Find(System.Xml.XmlQualifiedName name, System.Type type) { throw null; }
        public System.Collections.IList GetSchemas(string ns) { throw null; }
        public int IndexOf(System.Xml.Schema.XmlSchema schema) { throw null; }
        public void Insert(int index, System.Xml.Schema.XmlSchema schema) { }
        public static bool IsDataSet(System.Xml.Schema.XmlSchema schema) { throw null; }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        public void Remove(System.Xml.Schema.XmlSchema schema) { }
        System.Collections.Generic.IEnumerator<System.Xml.Schema.XmlSchema> System.Collections.Generic.IEnumerable<System.Xml.Schema.XmlSchema>.GetEnumerator() { throw null; }
    }
    public delegate void XmlSerializationCollectionFixupCallback(object collection, object collectionItems);
    public delegate void XmlSerializationFixupCallback(object fixup);
    public abstract partial class XmlSerializationGeneratedCode
    {
        protected XmlSerializationGeneratedCode() { }
    }
    public delegate object XmlSerializationReadCallback();
    public abstract partial class XmlSerializationReader : System.Xml.Serialization.XmlSerializationGeneratedCode
    {
        protected XmlSerializationReader() { }
        protected bool DecodeName { get { throw null; } set { } }
        protected System.Xml.XmlDocument Document { get { throw null; } }
        protected bool IsReturnValue { get { throw null; } set { } }
        protected System.Xml.XmlReader Reader { get { throw null; } }
        protected int ReaderCount { get { throw null; } }
        protected void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup) { }
        protected void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup) { }
        protected void AddReadCallback(string name, string ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read) { }
        protected void AddTarget(string id, object o) { }
        protected void CheckReaderCount(ref int whileIterations, ref int readerCount) { }
        protected string CollapseWhitespace(string value) { throw null; }
        protected System.Exception CreateAbstractTypeException(string name, string ns) { throw null; }
        protected System.Exception CreateBadDerivationException(string xsdDerived, string nsDerived, string xsdBase, string nsBase, string clrDerived, string clrBase) { throw null; }
        protected System.Exception CreateCtorHasSecurityException(string typeName) { throw null; }
        protected System.Exception CreateInaccessibleConstructorException(string typeName) { throw null; }
        protected System.Exception CreateInvalidCastException(System.Type type, object value) { throw null; }
        protected System.Exception CreateInvalidCastException(System.Type type, object value, string id) { throw null; }
        protected System.Exception CreateMissingIXmlSerializableType(string name, string ns, string clrType) { throw null; }
        protected System.Exception CreateReadOnlyCollectionException(string name) { throw null; }
        protected System.Exception CreateUnknownConstantException(string value, System.Type enumType) { throw null; }
        protected System.Exception CreateUnknownNodeException() { throw null; }
        protected System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type) { throw null; }
        protected System.Array EnsureArrayIndex(System.Array a, int index, System.Type elementType) { throw null; }
        protected void FixupArrayRefs(object fixup) { }
        protected int GetArrayLength(string name, string ns) { throw null; }
        protected bool GetNullAttr() { throw null; }
        protected object GetTarget(string id) { throw null; }
        protected System.Xml.XmlQualifiedName GetXsiType() { throw null; }
        protected abstract void InitCallbacks();
        protected abstract void InitIDs();
        protected bool IsXmlnsAttribute(string name) { throw null; }
        protected void ParseWsdlArrayType(System.Xml.XmlAttribute attr) { }
        protected System.Xml.XmlQualifiedName ReadElementQualifiedName() { throw null; }
        protected void ReadEndElement() { }
        protected bool ReadNull() { throw null; }
        protected System.Xml.XmlQualifiedName ReadNullableQualifiedName() { throw null; }
        protected string ReadNullableString() { throw null; }
        protected bool ReadReference(out string fixupReference) { fixupReference = default(string); throw null; }
        protected object ReadReferencedElement() { throw null; }
        protected object ReadReferencedElement(string name, string ns) { throw null; }
        protected void ReadReferencedElements() { }
        protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { fixupReference = default(string); throw null; }
        protected object ReadReferencingElement(string name, string ns, out string fixupReference) { fixupReference = default(string); throw null; }
        protected object ReadReferencingElement(out string fixupReference) { fixupReference = default(string); throw null; }
        protected System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable) { throw null; }
        protected System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable, bool wrappedAny) { throw null; }
        protected string ReadString(string value) { throw null; }
        protected string ReadString(string value, bool trim) { throw null; }
        protected object ReadTypedNull(System.Xml.XmlQualifiedName type) { throw null; }
        protected object ReadTypedPrimitive(System.Xml.XmlQualifiedName type) { throw null; }
        protected System.Xml.XmlDocument ReadXmlDocument(bool wrapped) { throw null; }
        protected System.Xml.XmlNode ReadXmlNode(bool wrapped) { throw null; }
        protected void Referenced(object o) { }
        protected static System.Reflection.Assembly ResolveDynamicAssembly(string assemblyFullName) { throw null; }
        protected System.Array ShrinkArray(System.Array a, int length, System.Type elementType, bool isNullable) { throw null; }
        protected byte[] ToByteArrayBase64(bool isNull) { throw null; }
        protected static byte[] ToByteArrayBase64(string value) { throw null; }
        protected byte[] ToByteArrayHex(bool isNull) { throw null; }
        protected static byte[] ToByteArrayHex(string value) { throw null; }
        protected static char ToChar(string value) { throw null; }
        protected static System.DateTime ToDate(string value) { throw null; }
        protected static System.DateTime ToDateTime(string value) { throw null; }
        protected static long ToEnum(string value, System.Collections.Hashtable h, string typeName) { throw null; }
        protected static System.DateTime ToTime(string value) { throw null; }
        protected static string ToXmlName(string value) { throw null; }
        protected static string ToXmlNCName(string value) { throw null; }
        protected static string ToXmlNmToken(string value) { throw null; }
        protected static string ToXmlNmTokens(string value) { throw null; }
        protected System.Xml.XmlQualifiedName ToXmlQualifiedName(string value) { throw null; }
        protected void UnknownAttribute(object o, System.Xml.XmlAttribute attr) { }
        protected void UnknownAttribute(object o, System.Xml.XmlAttribute attr, string qnames) { }
        protected void UnknownElement(object o, System.Xml.XmlElement elem) { }
        protected void UnknownElement(object o, System.Xml.XmlElement elem, string qnames) { }
        protected void UnknownNode(object o) { }
        protected void UnknownNode(object o, string qnames) { }
        protected void UnreferencedObject(string id, object o) { }
        protected partial class CollectionFixup
        {
            public CollectionFixup(object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, object collectionItems) { }
            public System.Xml.Serialization.XmlSerializationCollectionFixupCallback Callback { get { throw null; } }
            public object Collection { get { throw null; } }
            public object CollectionItems { get { throw null; } }
        }
        protected partial class Fixup
        {
            public Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, int count) { }
            public Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, string[] ids) { }
            public System.Xml.Serialization.XmlSerializationFixupCallback Callback { get { throw null; } }
            public string[] Ids { get { throw null; } }
            public object Source { get { throw null; } set { } }
        }
    }
    public delegate void XmlSerializationWriteCallback(object o);
    public abstract partial class XmlSerializationWriter : System.Xml.Serialization.XmlSerializationGeneratedCode
    {
        protected XmlSerializationWriter() { }
        protected bool EscapeName { get { throw null; } set { } }
        protected System.Collections.ArrayList Namespaces { get { throw null; } set { } }
        protected System.Xml.XmlWriter Writer { get { throw null; } set { } }
        protected void AddWriteCallback(System.Type type, string typeName, string typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback) { }
        protected System.Exception CreateChoiceIdentifierValueException(string value, string identifier, string name, string ns) { throw null; }
        protected System.Exception CreateInvalidAnyTypeException(object o) { throw null; }
        protected System.Exception CreateInvalidAnyTypeException(System.Type type) { throw null; }
        protected System.Exception CreateInvalidChoiceIdentifierValueException(string type, string identifier) { throw null; }
        protected System.Exception CreateInvalidEnumValueException(object value, string typeName) { throw null; }
        protected System.Exception CreateMismatchChoiceException(string value, string elementName, string enumValue) { throw null; }
        protected System.Exception CreateUnknownAnyElementException(string name, string ns) { throw null; }
        protected System.Exception CreateUnknownTypeException(object o) { throw null; }
        protected System.Exception CreateUnknownTypeException(System.Type type) { throw null; }
        protected static byte[] FromByteArrayBase64(byte[] value) { throw null; }
        protected static string FromByteArrayHex(byte[] value) { throw null; }
        protected static string FromChar(char value) { throw null; }
        protected static string FromDate(System.DateTime value) { throw null; }
        protected static string FromDateTime(System.DateTime value) { throw null; }
        protected static string FromEnum(long value, string[] values, long[] ids) { throw null; }
        protected static string FromEnum(long value, string[] values, long[] ids, string typeName) { throw null; }
        protected static string FromTime(System.DateTime value) { throw null; }
        protected static string FromXmlName(string name) { throw null; }
        protected static string FromXmlNCName(string ncName) { throw null; }
        protected static string FromXmlNmToken(string nmToken) { throw null; }
        protected static string FromXmlNmTokens(string nmTokens) { throw null; }
        protected string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName) { throw null; }
        protected string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName, bool ignoreEmpty) { throw null; }
        protected abstract void InitCallbacks();
        protected static System.Reflection.Assembly ResolveDynamicAssembly(string assemblyFullName) { throw null; }
        protected void TopLevelElement() { }
        protected void WriteAttribute(string localName, byte[] value) { }
        protected void WriteAttribute(string localName, string value) { }
        protected void WriteAttribute(string localName, string ns, byte[] value) { }
        protected void WriteAttribute(string localName, string ns, string value) { }
        protected void WriteAttribute(string prefix, string localName, string ns, string value) { }
        protected void WriteElementEncoded(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any) { }
        protected void WriteElementLiteral(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any) { }
        protected void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value) { }
        protected void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementQualifiedName(string localName, System.Xml.XmlQualifiedName value) { }
        protected void WriteElementQualifiedName(string localName, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementString(string localName, string value) { }
        protected void WriteElementString(string localName, string ns, string value) { }
        protected void WriteElementString(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementString(string localName, string value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementStringRaw(string localName, byte[] value) { }
        protected void WriteElementStringRaw(string localName, byte[] value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementStringRaw(string localName, string value) { }
        protected void WriteElementStringRaw(string localName, string ns, byte[] value) { }
        protected void WriteElementStringRaw(string localName, string ns, byte[] value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementStringRaw(string localName, string ns, string value) { }
        protected void WriteElementStringRaw(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteElementStringRaw(string localName, string value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteEmptyTag(string name) { }
        protected void WriteEmptyTag(string name, string ns) { }
        protected void WriteEndElement() { }
        protected void WriteEndElement(object o) { }
        protected void WriteId(object o) { }
        protected void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns) { }
        protected void WriteNullableQualifiedNameEncoded(string name, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteNullableQualifiedNameLiteral(string name, string ns, System.Xml.XmlQualifiedName value) { }
        protected void WriteNullableStringEncoded(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteNullableStringEncodedRaw(string name, string ns, byte[] value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteNullableStringEncodedRaw(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType) { }
        protected void WriteNullableStringLiteral(string name, string ns, string value) { }
        protected void WriteNullableStringLiteralRaw(string name, string ns, byte[] value) { }
        protected void WriteNullableStringLiteralRaw(string name, string ns, string value) { }
        protected void WriteNullTagEncoded(string name) { }
        protected void WriteNullTagEncoded(string name, string ns) { }
        protected void WriteNullTagLiteral(string name) { }
        protected void WriteNullTagLiteral(string name, string ns) { }
        protected void WritePotentiallyReferencingElement(string n, string ns, object o) { }
        protected void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType) { }
        protected void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference) { }
        protected void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference, bool isNullable) { }
        protected void WriteReferencedElements() { }
        protected void WriteReferencingElement(string n, string ns, object o) { }
        protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }
        protected void WriteRpcResult(string name, string ns) { }
        protected void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable) { }
        protected void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }
        protected void WriteStartDocument() { }
        protected void WriteStartElement(string name) { }
        protected void WriteStartElement(string name, string ns) { }
        protected void WriteStartElement(string name, string ns, bool writePrefixed) { }
        protected void WriteStartElement(string name, string ns, object o) { }
        protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }
        protected void WriteStartElement(string name, string ns, object o, bool writePrefixed, System.Xml.Serialization.XmlSerializerNamespaces xmlns) { }
        protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }
        protected void WriteValue(byte[] value) { }
        protected void WriteValue(string value) { }
        protected void WriteXmlAttribute(System.Xml.XmlNode node) { }
        protected void WriteXmlAttribute(System.Xml.XmlNode node, object container) { }
        protected void WriteXsiType(string name, string ns) { }
    }
    public partial class XmlSerializer
    {
        protected XmlSerializer() { }
        public XmlSerializer(System.Type type) { }
        public XmlSerializer(System.Type type, string defaultNamespace) { }
        public XmlSerializer(System.Type type, System.Type[] extraTypes) { }
        public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides) { }
        public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace) { }
        public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, string location) { }
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use a XmlSerializer constructor overload which does not take an Evidence parameter. See http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
        public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, string location, System.Security.Policy.Evidence evidence) { }
        public XmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root) { }
        public XmlSerializer(System.Xml.Serialization.XmlTypeMapping xmlTypeMapping) { }
        public event System.Xml.Serialization.XmlAttributeEventHandler UnknownAttribute { add { } remove { } }
        public event System.Xml.Serialization.XmlElementEventHandler UnknownElement { add { } remove { } }
        public event System.Xml.Serialization.XmlNodeEventHandler UnknownNode { add { } remove { } }
        public event System.Xml.Serialization.UnreferencedObjectEventHandler UnreferencedObject { add { } remove { } }
        public virtual bool CanDeserialize(System.Xml.XmlReader xmlReader) { throw null; }
        protected virtual System.Xml.Serialization.XmlSerializationReader CreateReader() { throw null; }
        protected virtual System.Xml.Serialization.XmlSerializationWriter CreateWriter() { throw null; }
        public object Deserialize(System.IO.Stream stream) { throw null; }
        public object Deserialize(System.IO.TextReader textReader) { throw null; }
        protected virtual object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) { throw null; }
        public object Deserialize(System.Xml.XmlReader xmlReader) { throw null; }
        public object Deserialize(System.Xml.XmlReader xmlReader, string encodingStyle) { throw null; }
        public object Deserialize(System.Xml.XmlReader xmlReader, string encodingStyle, System.Xml.Serialization.XmlDeserializationEvents events) { throw null; }
        public object Deserialize(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlDeserializationEvents events) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static System.Xml.Serialization.XmlSerializer[] FromMappings(System.Xml.Serialization.XmlMapping[] mappings) { throw null; }
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of FromMappings which does not take an Evidence parameter. See http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static System.Xml.Serialization.XmlSerializer[] FromMappings(System.Xml.Serialization.XmlMapping[] mappings, System.Security.Policy.Evidence evidence) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static System.Xml.Serialization.XmlSerializer[] FromMappings(System.Xml.Serialization.XmlMapping[] mappings, System.Type type) { throw null; }
        public static System.Xml.Serialization.XmlSerializer[] FromTypes(System.Type[] types) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static System.Reflection.Assembly GenerateSerializer(System.Type[] types, System.Xml.Serialization.XmlMapping[] mappings) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
        public static System.Reflection.Assembly GenerateSerializer(System.Type[] types, System.Xml.Serialization.XmlMapping[] mappings, System.CodeDom.Compiler.CompilerParameters parameters) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
        public static string GetXmlSerializerAssemblyName(System.Type type) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
        public static string GetXmlSerializerAssemblyName(System.Type type, string defaultNamespace) { throw null; }
        public void Serialize(System.IO.Stream stream, object o) { }
        public void Serialize(System.IO.Stream stream, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
        public void Serialize(System.IO.TextWriter textWriter, object o) { }
        public void Serialize(System.IO.TextWriter textWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
        protected virtual void Serialize(object o, System.Xml.Serialization.XmlSerializationWriter writer) { }
        public void Serialize(System.Xml.XmlWriter xmlWriter, object o) { }
        public void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
        public void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces, string encodingStyle) { }
        public void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces, string encodingStyle, string id) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1052), AllowMultiple=false)]
    public sealed partial class XmlSerializerAssemblyAttribute : System.Attribute
    {
        public XmlSerializerAssemblyAttribute() { }
        public XmlSerializerAssemblyAttribute(string assemblyName) { }
        public XmlSerializerAssemblyAttribute(string assemblyName, string codeBase) { }
        public string AssemblyName { get { throw null; } set { } }
        public string CodeBase { get { throw null; } set { } }
    }
    public partial class XmlSerializerFactory
    {
        public XmlSerializerFactory() { }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, string defaultNamespace) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Type[] extraTypes) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, string location) { throw null; }
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateSerializer which does not take an Evidence parameter. See http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, string location, System.Security.Policy.Evidence evidence) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root) { throw null; }
        public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Xml.Serialization.XmlTypeMapping xmlTypeMapping) { throw null; }
    }
    public abstract partial class XmlSerializerImplementation
    {
        protected XmlSerializerImplementation() { }
        public virtual System.Xml.Serialization.XmlSerializationReader Reader { get { throw null; } }
        public virtual System.Collections.Hashtable ReadMethods { get { throw null; } }
        public virtual System.Collections.Hashtable TypedSerializers { get { throw null; } }
        public virtual System.Collections.Hashtable WriteMethods { get { throw null; } }
        public virtual System.Xml.Serialization.XmlSerializationWriter Writer { get { throw null; } }
        public virtual bool CanSerialize(System.Type type) { throw null; }
        public virtual System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) { throw null; }
    }
    public partial class XmlSerializerNamespaces
    {
        public XmlSerializerNamespaces() { }
        public XmlSerializerNamespaces(System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
        public XmlSerializerNamespaces(System.Xml.XmlQualifiedName[] namespaces) { }
        public int Count { get { throw null; } }
        public void Add(string prefix, string ns) { }
        public System.Xml.XmlQualifiedName[] ToArray() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    public sealed partial class XmlSerializerVersionAttribute : System.Attribute
    {
        public XmlSerializerVersionAttribute() { }
        public XmlSerializerVersionAttribute(System.Type type) { }
        public string Namespace { get { throw null; } set { } }
        public string ParentAssemblyId { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
    public partial class XmlTextAttribute : System.Attribute
    {
        public XmlTextAttribute() { }
        public XmlTextAttribute(System.Type type) { }
        public string DataType { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1052))]
    public partial class XmlTypeAttribute : System.Attribute
    {
        public XmlTypeAttribute() { }
        public XmlTypeAttribute(string typeName) { }
        public bool AnonymousType { get { throw null; } set { } }
        public bool IncludeInSchema { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
    }
    public partial class XmlTypeMapping : System.Xml.Serialization.XmlMapping
    {
        internal XmlTypeMapping() { }
        public string TypeFullName { get { throw null; } }
        public string TypeName { get { throw null; } }
        public string XsdTypeName { get { throw null; } }
        public string XsdTypeNamespace { get { throw null; } }
    }
}
namespace System.Xml.Serialization.Advanced
{
    public abstract partial class SchemaImporterExtension
    {
        protected SchemaImporterExtension() { }
        public virtual string ImportAnyElement(System.Xml.Schema.XmlSchemaAny any, bool mixed, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public virtual System.CodeDom.CodeExpression ImportDefaultValue(string value, string type) { throw null; }
        public virtual string ImportSchemaType(string name, string ns, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public virtual string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
    }
    public partial class SchemaImporterExtensionCollection : System.Collections.CollectionBase
    {
        public SchemaImporterExtensionCollection() { }
        public System.Xml.Serialization.Advanced.SchemaImporterExtension this[int index] { get { throw null; } set { } }
        public int Add(string name, System.Type type) { throw null; }
        public int Add(System.Xml.Serialization.Advanced.SchemaImporterExtension extension) { throw null; }
        public new void Clear() { }
        public bool Contains(System.Xml.Serialization.Advanced.SchemaImporterExtension extension) { throw null; }
        public void CopyTo(System.Xml.Serialization.Advanced.SchemaImporterExtension[] array, int index) { }
        public int IndexOf(System.Xml.Serialization.Advanced.SchemaImporterExtension extension) { throw null; }
        public void Insert(int index, System.Xml.Serialization.Advanced.SchemaImporterExtension extension) { }
        public void Remove(string name) { }
        public void Remove(System.Xml.Serialization.Advanced.SchemaImporterExtension extension) { }
    }
}
namespace System.Xml.Serialization.Configuration
{
    public sealed partial class DateTimeSerializationSection : System.Configuration.ConfigurationSection
    {
        public DateTimeSerializationSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue=(System.Xml.Serialization.Configuration.DateTimeSerializationSection.DateTimeSerializationMode)(1))]
        public System.Xml.Serialization.Configuration.DateTimeSerializationSection.DateTimeSerializationMode Mode { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        public enum DateTimeSerializationMode
        {
            Default = 0,
            Local = 2,
            Roundtrip = 1,
        }
    }
    public partial class RootedPathValidator : System.Configuration.ConfigurationValidatorBase
    {
        public RootedPathValidator() { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    public sealed partial class SchemaImporterExtensionElement : System.Configuration.ConfigurationElement
    {
        public SchemaImporterExtensionElement() { }
        public SchemaImporterExtensionElement(string name, string type) { }
        public SchemaImporterExtensionElement(string name, System.Type type) { }
        [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=true, IsKey=true)]
        public string Name { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.ComponentModel.TypeConverterAttribute("System.Xml.Serialization.Configuration.SchemaImporterExtensionElement.TypeTypeConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("type", IsRequired=true, IsKey=false)]
        public System.Type Type { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Xml.Serialization.Configuration.SchemaImporterExtensionElement))]
    public sealed partial class SchemaImporterExtensionElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public SchemaImporterExtensionElementCollection() { }
        public System.Xml.Serialization.Configuration.SchemaImporterExtensionElement this[int index] { get { throw null; } set { } }
        public new System.Xml.Serialization.Configuration.SchemaImporterExtensionElement this[string name] { get { throw null; } set { } }
        public void Add(System.Xml.Serialization.Configuration.SchemaImporterExtensionElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Xml.Serialization.Configuration.SchemaImporterExtensionElement element) { throw null; }
        public void Remove(string name) { }
        public void Remove(System.Xml.Serialization.Configuration.SchemaImporterExtensionElement element) { }
        public void RemoveAt(int index) { }
    }
    public sealed partial class SchemaImporterExtensionsSection : System.Configuration.ConfigurationSection
    {
        public SchemaImporterExtensionsSection() { }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("", IsDefaultCollection=true)]
        public System.Xml.Serialization.Configuration.SchemaImporterExtensionElementCollection SchemaImporterExtensions { get { throw null; } }
        protected override void InitializeDefault() { }
    }
    public sealed partial class SerializationSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public SerializationSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("dateTimeSerialization")]
        public System.Xml.Serialization.Configuration.DateTimeSerializationSection DateTimeSerialization { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("schemaImporterExtensions")]
        public System.Xml.Serialization.Configuration.SchemaImporterExtensionsSection SchemaImporterExtensions { get { throw null; } }
        public System.Xml.Serialization.Configuration.XmlSerializerSection XmlSerializer { get { throw null; } }
    }
    public sealed partial class XmlSerializerSection : System.Configuration.ConfigurationSection
    {
        public XmlSerializerSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("checkDeserializeAdvances", DefaultValue=false)]
        public bool CheckDeserializeAdvances { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("tempFilesLocation", DefaultValue=null)]
        public string TempFilesLocation { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("useLegacySerializerGeneration", DefaultValue=false)]
        public bool UseLegacySerializerGeneration { get { throw null; } set { } }
    }
}
namespace System.Xml.XmlConfiguration
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlReaderSection : System.Configuration.ConfigurationSection
    {
        public XmlReaderSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("prohibitDefaultResolver", DefaultValue="false")]
        public string ProhibitDefaultResolverString { get { throw null; } set { } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XsltConfigSection : System.Configuration.ConfigurationSection
    {
        public XsltConfigSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("prohibitDefaultResolver", DefaultValue="false")]
        public string ProhibitDefaultResolverString { get { throw null; } set { } }
    }
}
namespace System.Xml.XPath
{
    public partial interface IXPathNavigable
    {
        System.Xml.XPath.XPathNavigator CreateNavigator();
    }
    public enum XmlCaseOrder
    {
        LowerFirst = 2,
        None = 0,
        UpperFirst = 1,
    }
    public enum XmlDataType
    {
        Number = 2,
        Text = 1,
    }
    public enum XmlSortOrder
    {
        Ascending = 1,
        Descending = 2,
    }
    public partial class XPathDocument : System.Xml.XPath.IXPathNavigable
    {
        public XPathDocument(System.IO.Stream stream) { }
        public XPathDocument(System.IO.TextReader textReader) { }
        public XPathDocument(string uri) { }
        public XPathDocument(string uri, System.Xml.XmlSpace space) { }
        public XPathDocument(System.Xml.XmlReader reader) { }
        public XPathDocument(System.Xml.XmlReader reader, System.Xml.XmlSpace space) { }
        public System.Xml.XPath.XPathNavigator CreateNavigator() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class XPathException : System.SystemException
    {
        public XPathException() { }
        protected XPathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XPathException(string message) { }
        public XPathException(string message, System.Exception innerException) { }
        public override string Message { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XPathExpression
    {
        internal XPathExpression() { }
        public abstract string Expression { get; }
        public abstract System.Xml.XPath.XPathResultType ReturnType { get; }
        public abstract void AddSort(object expr, System.Collections.IComparer comparer);
        public abstract void AddSort(object expr, System.Xml.XPath.XmlSortOrder order, System.Xml.XPath.XmlCaseOrder caseOrder, string lang, System.Xml.XPath.XmlDataType dataType);
        public abstract System.Xml.XPath.XPathExpression Clone();
        public static System.Xml.XPath.XPathExpression Compile(string xpath) { throw null; }
        public static System.Xml.XPath.XPathExpression Compile(string xpath, System.Xml.IXmlNamespaceResolver nsResolver) { throw null; }
        public abstract void SetContext(System.Xml.IXmlNamespaceResolver nsResolver);
        public abstract void SetContext(System.Xml.XmlNamespaceManager nsManager);
    }
    public abstract partial class XPathItem
    {
        protected XPathItem() { }
        public abstract bool IsNode { get; }
        public abstract object TypedValue { get; }
        public abstract string Value { get; }
        public abstract bool ValueAsBoolean { get; }
        public abstract System.DateTime ValueAsDateTime { get; }
        public abstract double ValueAsDouble { get; }
        public abstract int ValueAsInt { get; }
        public abstract long ValueAsLong { get; }
        public abstract System.Type ValueType { get; }
        public abstract System.Xml.Schema.XmlSchemaType XmlType { get; }
        public virtual object ValueAs(System.Type returnType) { throw null; }
        public abstract object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
    }
    public enum XPathNamespaceScope
    {
        All = 0,
        ExcludeXml = 1,
        Local = 2,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{debuggerDisplayProxy}")]
    public abstract partial class XPathNavigator : System.Xml.XPath.XPathItem, System.ICloneable, System.Xml.IXmlNamespaceResolver, System.Xml.XPath.IXPathNavigable
    {
        protected XPathNavigator() { }
        public abstract string BaseURI { get; }
        public virtual bool CanEdit { get { throw null; } }
        public virtual bool HasAttributes { get { throw null; } }
        public virtual bool HasChildren { get { throw null; } }
        public virtual string InnerXml { get { throw null; } set { } }
        public abstract bool IsEmptyElement { get; }
        public sealed override bool IsNode { get { throw null; } }
        public abstract string LocalName { get; }
        public abstract string Name { get; }
        public abstract string NamespaceURI { get; }
        public abstract System.Xml.XmlNameTable NameTable { get; }
        public static System.Collections.IEqualityComparer NavigatorComparer { get { throw null; } }
        public abstract System.Xml.XPath.XPathNodeType NodeType { get; }
        public virtual string OuterXml { get { throw null; } set { } }
        public abstract string Prefix { get; }
        public virtual System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public override object TypedValue { get { throw null; } }
        public virtual object UnderlyingObject { get { throw null; } }
        public override bool ValueAsBoolean { get { throw null; } }
        public override System.DateTime ValueAsDateTime { get { throw null; } }
        public override double ValueAsDouble { get { throw null; } }
        public override int ValueAsInt { get { throw null; } }
        public override long ValueAsLong { get { throw null; } }
        public override System.Type ValueType { get { throw null; } }
        public virtual string XmlLang { get { throw null; } }
        public override System.Xml.Schema.XmlSchemaType XmlType { get { throw null; } }
        public virtual System.Xml.XmlWriter AppendChild() { throw null; }
        public virtual void AppendChild(string newChild) { }
        public virtual void AppendChild(System.Xml.XmlReader newChild) { }
        public virtual void AppendChild(System.Xml.XPath.XPathNavigator newChild) { }
        public virtual void AppendChildElement(string prefix, string localName, string namespaceURI, string value) { }
        public virtual bool CheckValidity(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public abstract System.Xml.XPath.XPathNavigator Clone();
        public virtual System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator nav) { throw null; }
        public virtual System.Xml.XPath.XPathExpression Compile(string xpath) { throw null; }
        public virtual void CreateAttribute(string prefix, string localName, string namespaceURI, string value) { }
        public virtual System.Xml.XmlWriter CreateAttributes() { throw null; }
        public virtual System.Xml.XPath.XPathNavigator CreateNavigator() { throw null; }
        public virtual void DeleteRange(System.Xml.XPath.XPathNavigator lastSiblingToDelete) { }
        public virtual void DeleteSelf() { }
        public virtual object Evaluate(string xpath) { throw null; }
        public virtual object Evaluate(string xpath, System.Xml.IXmlNamespaceResolver resolver) { throw null; }
        public virtual object Evaluate(System.Xml.XPath.XPathExpression expr) { throw null; }
        public virtual object Evaluate(System.Xml.XPath.XPathExpression expr, System.Xml.XPath.XPathNodeIterator context) { throw null; }
        public virtual string GetAttribute(string localName, string namespaceURI) { throw null; }
        public virtual string GetNamespace(string name) { throw null; }
        public virtual System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        public virtual System.Xml.XmlWriter InsertAfter() { throw null; }
        public virtual void InsertAfter(string newSibling) { }
        public virtual void InsertAfter(System.Xml.XmlReader newSibling) { }
        public virtual void InsertAfter(System.Xml.XPath.XPathNavigator newSibling) { }
        public virtual System.Xml.XmlWriter InsertBefore() { throw null; }
        public virtual void InsertBefore(string newSibling) { }
        public virtual void InsertBefore(System.Xml.XmlReader newSibling) { }
        public virtual void InsertBefore(System.Xml.XPath.XPathNavigator newSibling) { }
        public virtual void InsertElementAfter(string prefix, string localName, string namespaceURI, string value) { }
        public virtual void InsertElementBefore(string prefix, string localName, string namespaceURI, string value) { }
        public virtual bool IsDescendant(System.Xml.XPath.XPathNavigator nav) { throw null; }
        public abstract bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
        public virtual string LookupNamespace(string prefix) { throw null; }
        public virtual string LookupPrefix(string namespaceURI) { throw null; }
        public virtual bool Matches(string xpath) { throw null; }
        public virtual bool Matches(System.Xml.XPath.XPathExpression expr) { throw null; }
        public abstract bool MoveTo(System.Xml.XPath.XPathNavigator other);
        public virtual bool MoveToAttribute(string localName, string namespaceURI) { throw null; }
        public virtual bool MoveToChild(string localName, string namespaceURI) { throw null; }
        public virtual bool MoveToChild(System.Xml.XPath.XPathNodeType type) { throw null; }
        public virtual bool MoveToFirst() { throw null; }
        public abstract bool MoveToFirstAttribute();
        public abstract bool MoveToFirstChild();
        public bool MoveToFirstNamespace() { throw null; }
        public abstract bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
        public virtual bool MoveToFollowing(string localName, string namespaceURI) { throw null; }
        public virtual bool MoveToFollowing(string localName, string namespaceURI, System.Xml.XPath.XPathNavigator end) { throw null; }
        public virtual bool MoveToFollowing(System.Xml.XPath.XPathNodeType type) { throw null; }
        public virtual bool MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end) { throw null; }
        public abstract bool MoveToId(string id);
        public virtual bool MoveToNamespace(string name) { throw null; }
        public abstract bool MoveToNext();
        public virtual bool MoveToNext(string localName, string namespaceURI) { throw null; }
        public virtual bool MoveToNext(System.Xml.XPath.XPathNodeType type) { throw null; }
        public abstract bool MoveToNextAttribute();
        public bool MoveToNextNamespace() { throw null; }
        public abstract bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
        public abstract bool MoveToParent();
        public abstract bool MoveToPrevious();
        public virtual void MoveToRoot() { }
        public virtual System.Xml.XmlWriter PrependChild() { throw null; }
        public virtual void PrependChild(string newChild) { }
        public virtual void PrependChild(System.Xml.XmlReader newChild) { }
        public virtual void PrependChild(System.Xml.XPath.XPathNavigator newChild) { }
        public virtual void PrependChildElement(string prefix, string localName, string namespaceURI, string value) { }
        public virtual System.Xml.XmlReader ReadSubtree() { throw null; }
        public virtual System.Xml.XmlWriter ReplaceRange(System.Xml.XPath.XPathNavigator lastSiblingToReplace) { throw null; }
        public virtual void ReplaceSelf(string newNode) { }
        public virtual void ReplaceSelf(System.Xml.XmlReader newNode) { }
        public virtual void ReplaceSelf(System.Xml.XPath.XPathNavigator newNode) { }
        public virtual System.Xml.XPath.XPathNodeIterator Select(string xpath) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator Select(string xpath, System.Xml.IXmlNamespaceResolver resolver) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator Select(System.Xml.XPath.XPathExpression expr) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator SelectAncestors(string name, string namespaceURI, bool matchSelf) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator SelectAncestors(System.Xml.XPath.XPathNodeType type, bool matchSelf) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator SelectChildren(string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType type) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { throw null; }
        public virtual System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType type, bool matchSelf) { throw null; }
        public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(string xpath) { throw null; }
        public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(string xpath, System.Xml.IXmlNamespaceResolver resolver) { throw null; }
        public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(System.Xml.XPath.XPathExpression expression) { throw null; }
        public virtual void SetTypedValue(object typedValue) { }
        public virtual void SetValue(string value) { }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
        public override object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver) { throw null; }
        public virtual void WriteSubtree(System.Xml.XmlWriter writer) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Position={CurrentPosition}, Current={debuggerDisplayProxy}")]
    public abstract partial class XPathNodeIterator : System.Collections.IEnumerable, System.ICloneable
    {
        protected XPathNodeIterator() { }
        public virtual int Count { get { throw null; } }
        public abstract System.Xml.XPath.XPathNavigator Current { get; }
        public abstract int CurrentPosition { get; }
        public abstract System.Xml.XPath.XPathNodeIterator Clone();
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public abstract bool MoveNext();
        object System.ICloneable.Clone() { throw null; }
    }
    public enum XPathNodeType
    {
        All = 9,
        Attribute = 2,
        Comment = 8,
        Element = 1,
        Namespace = 3,
        ProcessingInstruction = 7,
        Root = 0,
        SignificantWhitespace = 5,
        Text = 4,
        Whitespace = 6,
    }
    public enum XPathResultType
    {
        Any = 5,
        Boolean = 2,
        Error = 6,
        Navigator = 1,
        NodeSet = 3,
        Number = 0,
        String = 1,
    }
}
namespace System.Xml.Xsl
{
    public partial interface IXsltContextFunction
    {
        System.Xml.XPath.XPathResultType[] ArgTypes { get; }
        int Maxargs { get; }
        int Minargs { get; }
        System.Xml.XPath.XPathResultType ReturnType { get; }
        object Invoke(System.Xml.Xsl.XsltContext xsltContext, object[] args, System.Xml.XPath.XPathNavigator docContext);
    }
    public partial interface IXsltContextVariable
    {
        bool IsLocal { get; }
        bool IsParam { get; }
        System.Xml.XPath.XPathResultType VariableType { get; }
        object Evaluate(System.Xml.Xsl.XsltContext xsltContext);
    }
    public sealed partial class XslCompiledTransform
    {
        public XslCompiledTransform() { }
        public XslCompiledTransform(bool enableDebug) { }
        public System.Xml.XmlWriterSettings OutputSettings { get { throw null; } }
        public System.CodeDom.Compiler.TempFileCollection TemporaryFiles { [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]get { throw null; } }
        public static System.CodeDom.Compiler.CompilerErrorCollection CompileToType(System.Xml.XmlReader stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver, bool debug, System.Reflection.Emit.TypeBuilder typeBuilder, string scriptAssemblyPath) { throw null; }
        public void Load(System.Reflection.MethodInfo executeMethod, byte[] queryData, System.Type[] earlyBoundTypes) { }
        public void Load(string stylesheetUri) { }
        public void Load(string stylesheetUri, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) { }
        public void Load(System.Type compiledStylesheet) { }
        public void Load(System.Xml.XmlReader stylesheet) { }
        public void Load(System.Xml.XmlReader stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver) { }
        public void Transform(string inputUri, string resultsFile) { }
        public void Transform(string inputUri, System.Xml.XmlWriter results) { }
        public void Transform(string inputUri, System.Xml.Xsl.XsltArgumentList arguments, System.IO.Stream results) { }
        public void Transform(string inputUri, System.Xml.Xsl.XsltArgumentList arguments, System.IO.TextWriter results) { }
        public void Transform(string inputUri, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.Stream results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.TextWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XmlReader input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results, System.Xml.XmlResolver documentResolver) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.Stream results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.IO.TextWriter results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList arguments, System.Xml.XmlWriter results, System.Xml.XmlResolver documentResolver) { }
    }
    public partial class XsltArgumentList
    {
        public XsltArgumentList() { }
        public event System.Xml.Xsl.XsltMessageEncounteredEventHandler XsltMessageEncountered { add { } remove { } }
        public void AddExtensionObject(string namespaceUri, object extension) { }
        public void AddParam(string name, string namespaceUri, object parameter) { }
        public void Clear() { }
        public object GetExtensionObject(string namespaceUri) { throw null; }
        public object GetParam(string name, string namespaceUri) { throw null; }
        public object RemoveExtensionObject(string namespaceUri) { throw null; }
        public object RemoveParam(string name, string namespaceUri) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class XsltCompileException : System.Xml.Xsl.XsltException
    {
        public XsltCompileException() { }
        public XsltCompileException(System.Exception inner, string sourceUri, int lineNumber, int linePosition) { }
        protected XsltCompileException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XsltCompileException(string message) { }
        public XsltCompileException(string message, System.Exception innerException) { }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XsltContext : System.Xml.XmlNamespaceManager
    {
        protected XsltContext() : base (default(System.Xml.XmlNameTable)) { }
        protected XsltContext(System.Xml.NameTable table) : base (default(System.Xml.XmlNameTable)) { }
        public abstract bool Whitespace { get; }
        public abstract int CompareDocument(string baseUri, string nextbaseUri);
        public abstract bool PreserveWhitespace(System.Xml.XPath.XPathNavigator node);
        public abstract System.Xml.Xsl.IXsltContextFunction ResolveFunction(string prefix, string name, System.Xml.XPath.XPathResultType[] ArgTypes);
        public abstract System.Xml.Xsl.IXsltContextVariable ResolveVariable(string prefix, string name);
    }
    [System.SerializableAttribute]
    public partial class XsltException : System.SystemException
    {
        public XsltException() { }
        protected XsltException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XsltException(string message) { }
        public XsltException(string message, System.Exception innerException) { }
        public virtual int LineNumber { get { throw null; } }
        public virtual int LinePosition { get { throw null; } }
        public override string Message { get { throw null; } }
        public virtual string SourceUri { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class XsltMessageEncounteredEventArgs : System.EventArgs
    {
        protected XsltMessageEncounteredEventArgs() { }
        public abstract string Message { get; }
    }
    public delegate void XsltMessageEncounteredEventHandler(object sender, System.Xml.Xsl.XsltMessageEncounteredEventArgs e);
    [System.ObsoleteAttribute("This class has been deprecated. Please use System.Xml.Xsl.XslCompiledTransform instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed partial class XslTransform
    {
        public XslTransform() { }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public void Load(string url) { }
        public void Load(string url, System.Xml.XmlResolver resolver) { }
        public void Load(System.Xml.XmlReader stylesheet) { }
        public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver) { }
        public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver) { }
        public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public void Load(System.Xml.XPath.XPathNavigator stylesheet) { }
        public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver) { }
        public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public void Transform(string inputfile, string outputfile) { }
        public void Transform(string inputfile, string outputfile, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args) { throw null; }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output, System.Xml.XmlResolver resolver) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlResolver resolver) { throw null; }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output) { }
        public void Transform(System.Xml.XPath.IXPathNavigable input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args) { throw null; }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.Stream output, System.Xml.XmlResolver resolver) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.IO.TextWriter output, System.Xml.XmlResolver resolver) { }
        public System.Xml.XmlReader Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlResolver resolver) { throw null; }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output) { }
        public void Transform(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.XsltArgumentList args, System.Xml.XmlWriter output, System.Xml.XmlResolver resolver) { }
    }
    public sealed partial class XsltSettings
    {
        public XsltSettings() { }
        public XsltSettings(bool enableDocumentFunction, bool enableScript) { }
        public static System.Xml.Xsl.XsltSettings Default { get { throw null; } }
        public bool EnableDocumentFunction { get { throw null; } set { } }
        public bool EnableScript { get { throw null; } set { } }
        public static System.Xml.Xsl.XsltSettings TrustedXslt { get { throw null; } }
    }
}
namespace System.Xml.Xsl.Runtime
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AncestorDocOrderIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AncestorIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AttributeContentIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AttributeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ContentIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ContentMergeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DecimalAggregator
    {
        public decimal AverageResult { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public decimal MaximumResult { get { throw null; } }
        public decimal MinimumResult { get { throw null; } }
        public decimal SumResult { get { throw null; } }
        public void Average(decimal value) { }
        public void Create() { }
        public void Maximum(decimal value) { }
        public void Minimum(decimal value) { }
        public void Sum(decimal value) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DescendantIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DescendantMergeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
        public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DifferenceIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
        public System.Xml.Xsl.Runtime.SetIteratorResult MoveNext(System.Xml.XPath.XPathNavigator nestedNavigator) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DodSequenceMerge
    {
        public void AddSequence(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> sequence) { }
        public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
        public System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> MergeSequences() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DoubleAggregator
    {
        public double AverageResult { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public double MaximumResult { get { throw null; } }
        public double MinimumResult { get { throw null; } }
        public double SumResult { get { throw null; } }
        public void Average(double value) { }
        public void Create() { }
        public void Maximum(double value) { }
        public void Minimum(double value) { }
        public void Sum(double value) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ElementContentIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, string localName, string ns) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FollowingSiblingIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FollowingSiblingMergeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator navigator) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IdIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, string value) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Int32Aggregator
    {
        public int AverageResult { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public int MaximumResult { get { throw null; } }
        public int MinimumResult { get { throw null; } }
        public int SumResult { get { throw null; } }
        public void Average(int value) { }
        public void Create() { }
        public void Maximum(int value) { }
        public void Minimum(int value) { }
        public void Sum(int value) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Int64Aggregator
    {
        public long AverageResult { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public long MaximumResult { get { throw null; } }
        public long MinimumResult { get { throw null; } }
        public long SumResult { get { throw null; } }
        public void Average(long value) { }
        public void Create() { }
        public void Maximum(long value) { }
        public void Minimum(long value) { }
        public void Sum(long value) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IntersectIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
        public System.Xml.Xsl.Runtime.SetIteratorResult MoveNext(System.Xml.XPath.XPathNavigator nestedNavigator) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public enum IteratorResult
    {
        HaveCurrentNode = 2,
        NeedInputNode = 1,
        NoMoreNodes = 0,
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NamespaceIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NodeKindContentIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.XPath.XPathNodeType nodeType) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NodeRangeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator start, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, System.Xml.XPath.XPathNavigator end) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ParentIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PrecedingIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PrecedingSiblingDocOrderIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PrecedingSiblingIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public enum SetIteratorResult
    {
        HaveCurrentNode = 4,
        InitRightIterator = 1,
        NeedLeftNode = 2,
        NeedRightNode = 3,
        NoMoreNodes = 0,
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct StringConcat
    {
        public string Delimiter { get { throw null; } set { } }
        public void Clear() { }
        public void Concat(string value) { }
        public string GetResult() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UnionIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
        public System.Xml.Xsl.Runtime.SetIteratorResult MoveNext(System.Xml.XPath.XPathNavigator nestedNavigator) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlCollation
    {
        internal XmlCollation() { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlILIndex
    {
        internal XmlILIndex() { }
        public void Add(string key, System.Xml.XPath.XPathNavigator navigator) { }
        public System.Xml.Xsl.Runtime.XmlQueryNodeSequence Lookup(string key) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class XmlILStorageConverter
    {
        public static System.Xml.Schema.XmlAtomicValue BooleanToAtomicValue(bool value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue BytesToAtomicValue(byte[] value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue DateTimeToAtomicValue(System.DateTime value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue DecimalToAtomicValue(decimal value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue DoubleToAtomicValue(double value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue Int32ToAtomicValue(int value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue Int64ToAtomicValue(long value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> ItemsToNavigators(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static System.Collections.Generic.IList<System.Xml.XPath.XPathItem> NavigatorsToItems(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> listNavigators) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue SingleToAtomicValue(float value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue StringToAtomicValue(string value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue TimeSpanToAtomicValue(System.TimeSpan value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
        public static System.Xml.Schema.XmlAtomicValue XmlQualifiedNameToAtomicValue(System.Xml.XmlQualifiedName value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract partial class XmlNavigatorFilter
    {
        protected XmlNavigatorFilter() { }
        public abstract bool IsFiltered(System.Xml.XPath.XPathNavigator navigator);
        public abstract bool MoveToContent(System.Xml.XPath.XPathNavigator navigator);
        public abstract bool MoveToFollowing(System.Xml.XPath.XPathNavigator navigator, System.Xml.XPath.XPathNavigator navigatorEnd);
        public abstract bool MoveToFollowingSibling(System.Xml.XPath.XPathNavigator navigator);
        public abstract bool MoveToNextContent(System.Xml.XPath.XPathNavigator navigator);
        public abstract bool MoveToPreviousSibling(System.Xml.XPath.XPathNavigator navigator);
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlQueryContext
    {
        internal XmlQueryContext() { }
        public System.Xml.XPath.XPathNavigator DefaultDataSource { get { throw null; } }
        public System.Xml.XmlNameTable DefaultNameTable { get { throw null; } }
        public System.Xml.XmlNameTable QueryNameTable { get { throw null; } }
        public System.Xml.XPath.XPathNavigator GetDataSource(string uriRelative, string uriBase) { throw null; }
        public object GetLateBoundObject(string namespaceUri) { throw null; }
        public object GetParameter(string localName, string namespaceUri) { throw null; }
        public System.Collections.Generic.IList<System.Xml.XPath.XPathItem> InvokeXsltLateBoundFunction(string name, string namespaceUri, System.Collections.Generic.IList<System.Xml.XPath.XPathItem>[] args) { throw null; }
        public bool LateBoundFunctionExists(string name, string namespaceUri) { throw null; }
        public void OnXsltMessageEncountered(string message) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlQueryItemSequence : System.Xml.Xsl.Runtime.XmlQuerySequence<System.Xml.XPath.XPathItem>
    {
        public static readonly new System.Xml.Xsl.Runtime.XmlQueryItemSequence Empty;
        public XmlQueryItemSequence() { }
        public XmlQueryItemSequence(int capacity) { }
        public XmlQueryItemSequence(System.Xml.XPath.XPathItem item) { }
        public void AddClone(System.Xml.XPath.XPathItem item) { }
        public static System.Xml.Xsl.Runtime.XmlQueryItemSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryItemSequence seq) { throw null; }
        public static System.Xml.Xsl.Runtime.XmlQueryItemSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryItemSequence seq, System.Xml.XPath.XPathItem item) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlQueryNodeSequence : System.Xml.Xsl.Runtime.XmlQuerySequence<System.Xml.XPath.XPathNavigator>, System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>, System.Collections.Generic.IEnumerable<System.Xml.XPath.XPathItem>, System.Collections.Generic.IList<System.Xml.XPath.XPathItem>, System.Collections.IEnumerable
    {
        public static readonly new System.Xml.Xsl.Runtime.XmlQueryNodeSequence Empty;
        public XmlQueryNodeSequence() { }
        public XmlQueryNodeSequence(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> list) { }
        public XmlQueryNodeSequence(int capacity) { }
        public XmlQueryNodeSequence(System.Xml.XPath.XPathNavigator navigator) { }
        public XmlQueryNodeSequence(System.Xml.XPath.XPathNavigator[] array, int size) { }
        public bool IsDocOrderDistinct { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.IsReadOnly { get { throw null; } }
        System.Xml.XPath.XPathItem System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.this[int index] { get { throw null; } set { } }
        public void AddClone(System.Xml.XPath.XPathNavigator navigator) { }
        public static System.Xml.Xsl.Runtime.XmlQueryNodeSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryNodeSequence seq) { throw null; }
        public static System.Xml.Xsl.Runtime.XmlQueryNodeSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryNodeSequence seq, System.Xml.XPath.XPathNavigator navigator) { throw null; }
        public System.Xml.Xsl.Runtime.XmlQueryNodeSequence DocOrderDistinct(System.Collections.Generic.IComparer<System.Xml.XPath.XPathNavigator> comparer) { throw null; }
        protected override void OnItemsChanged() { }
        void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Add(System.Xml.XPath.XPathItem value) { }
        void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Contains(System.Xml.XPath.XPathItem value) { throw null; }
        void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.CopyTo(System.Xml.XPath.XPathItem[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Remove(System.Xml.XPath.XPathItem value) { throw null; }
        System.Collections.Generic.IEnumerator<System.Xml.XPath.XPathItem> System.Collections.Generic.IEnumerable<System.Xml.XPath.XPathItem>.GetEnumerator() { throw null; }
        int System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.IndexOf(System.Xml.XPath.XPathItem value) { throw null; }
        void System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.Insert(int index, System.Xml.XPath.XPathItem value) { }
        void System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.RemoveAt(int index) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlQueryOutput : System.Xml.XmlWriter
    {
        internal XmlQueryOutput() { }
        public override System.Xml.WriteState WriteState { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public void EndCopy(System.Xml.XPath.XPathNavigator navigator) { }
        public void EndTree() { }
        public override void Flush() { }
        public override string LookupPrefix(string ns) { throw null; }
        public bool StartCopy(System.Xml.XPath.XPathNavigator navigator) { throw null; }
        public void StartElementContentUnchecked() { }
        public void StartTree(System.Xml.XPath.XPathNodeType rootType) { }
        public override void WriteBase64(byte[] buffer, int index, int count) { }
        public override void WriteCData(string text) { }
        public override void WriteCharEntity(char ch) { }
        public override void WriteChars(char[] buffer, int index, int count) { }
        public override void WriteComment(string text) { }
        public void WriteCommentString(string text) { }
        public override void WriteDocType(string name, string pubid, string sysid, string subset) { }
        public override void WriteEndAttribute() { }
        public void WriteEndAttributeUnchecked() { }
        public void WriteEndComment() { }
        public override void WriteEndDocument() { }
        public override void WriteEndElement() { }
        public void WriteEndElementUnchecked(string localName) { }
        public void WriteEndElementUnchecked(string prefix, string localName, string ns) { }
        public void WriteEndNamespace() { }
        public void WriteEndProcessingInstruction() { }
        public void WriteEndRoot() { }
        public override void WriteEntityRef(string name) { }
        public override void WriteFullEndElement() { }
        public void WriteItem(System.Xml.XPath.XPathItem item) { }
        public void WriteNamespaceDeclaration(string prefix, string ns) { }
        public void WriteNamespaceDeclarationUnchecked(string prefix, string ns) { }
        public void WriteNamespaceString(string text) { }
        public override void WriteProcessingInstruction(string target, string text) { }
        public void WriteProcessingInstructionString(string text) { }
        public override void WriteRaw(char[] buffer, int index, int count) { }
        public override void WriteRaw(string data) { }
        public void WriteRawUnchecked(string text) { }
        public override void WriteStartAttribute(string prefix, string localName, string ns) { }
        public void WriteStartAttributeComputed(string tagName, int prefixMappingsIndex) { }
        public void WriteStartAttributeComputed(string tagName, string ns) { }
        public void WriteStartAttributeComputed(System.Xml.XmlQualifiedName name) { }
        public void WriteStartAttributeComputed(System.Xml.XPath.XPathNavigator navigator) { }
        public void WriteStartAttributeLocalName(string localName) { }
        public void WriteStartAttributeUnchecked(string localName) { }
        public void WriteStartAttributeUnchecked(string prefix, string localName, string ns) { }
        public void WriteStartComment() { }
        public override void WriteStartDocument() { }
        public override void WriteStartDocument(bool standalone) { }
        public override void WriteStartElement(string prefix, string localName, string ns) { }
        public void WriteStartElementComputed(string tagName, int prefixMappingsIndex) { }
        public void WriteStartElementComputed(string tagName, string ns) { }
        public void WriteStartElementComputed(System.Xml.XmlQualifiedName name) { }
        public void WriteStartElementComputed(System.Xml.XPath.XPathNavigator navigator) { }
        public void WriteStartElementLocalName(string localName) { }
        public void WriteStartElementUnchecked(string localName) { }
        public void WriteStartElementUnchecked(string prefix, string localName, string ns) { }
        public void WriteStartNamespace(string prefix) { }
        public void WriteStartProcessingInstruction(string target) { }
        public void WriteStartRoot() { }
        public override void WriteString(string text) { }
        public void WriteStringUnchecked(string text) { }
        public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }
        public override void WriteWhitespace(string ws) { }
        public void XsltCopyOf(System.Xml.XPath.XPathNavigator navigator) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XmlQueryRuntime
    {
        internal XmlQueryRuntime() { }
        public System.Xml.Xsl.Runtime.XmlQueryContext ExternalContext { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        public System.Xml.Xsl.Runtime.XmlQueryOutput Output { get { throw null; } }
        public System.Xml.Xsl.Runtime.XsltLibrary XsltFunctions { get { throw null; } }
        public void AddNewIndex(System.Xml.XPath.XPathNavigator context, int indexId, System.Xml.Xsl.Runtime.XmlILIndex index) { }
        public object ChangeTypeXsltArgument(int indexType, object value, System.Type destinationType) { throw null; }
        public object ChangeTypeXsltResult(int indexType, object value) { throw null; }
        public int ComparePosition(System.Xml.XPath.XPathNavigator navigatorThis, System.Xml.XPath.XPathNavigator navigatorThat) { throw null; }
        public System.Xml.Xsl.Runtime.XmlCollation CreateCollation(string collation) { throw null; }
        public string[] DebugGetGlobalNames() { throw null; }
        public System.Collections.IList DebugGetGlobalValue(string name) { throw null; }
        public object DebugGetXsltValue(System.Collections.IList seq) { throw null; }
        public void DebugSetGlobalValue(string name, object value) { }
        public System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> DocOrderDistinct(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> seq) { throw null; }
        public bool EarlyBoundFunctionExists(string name, string namespaceUri) { throw null; }
        public System.Xml.XPath.XPathNavigator EndRtfConstruction(out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); throw null; }
        public System.Collections.Generic.IList<System.Xml.XPath.XPathItem> EndSequenceConstruction(out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); throw null; }
        public bool FindIndex(System.Xml.XPath.XPathNavigator context, int indexId, out System.Xml.Xsl.Runtime.XmlILIndex index) { index = default(System.Xml.Xsl.Runtime.XmlILIndex); throw null; }
        public string GenerateId(System.Xml.XPath.XPathNavigator navigator) { throw null; }
        public string GetAtomizedName(int index) { throw null; }
        public System.Xml.Xsl.Runtime.XmlCollation GetCollation(int index) { throw null; }
        public object GetEarlyBoundObject(int index) { throw null; }
        public object GetGlobalValue(int index) { throw null; }
        public System.Xml.Xsl.Runtime.XmlNavigatorFilter GetNameFilter(int index) { throw null; }
        public System.Xml.Xsl.Runtime.XmlNavigatorFilter GetTypeFilter(System.Xml.XPath.XPathNodeType nodeType) { throw null; }
        public bool IsGlobalComputed(int index) { throw null; }
        public bool IsQNameEqual(System.Xml.XPath.XPathNavigator navigator, int indexLocalName, int indexNamespaceUri) { throw null; }
        public bool IsQNameEqual(System.Xml.XPath.XPathNavigator n1, System.Xml.XPath.XPathNavigator n2) { throw null; }
        public bool MatchesXmlType(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> seq, int indexType) { throw null; }
        public bool MatchesXmlType(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> seq, System.Xml.Schema.XmlTypeCode code) { throw null; }
        public bool MatchesXmlType(System.Xml.XPath.XPathItem item, int indexType) { throw null; }
        public bool MatchesXmlType(System.Xml.XPath.XPathItem item, System.Xml.Schema.XmlTypeCode code) { throw null; }
        public static int OnCurrentNodeChanged(System.Xml.XPath.XPathNavigator currentNode) { throw null; }
        public System.Xml.XmlQualifiedName ParseTagName(string tagName, int indexPrefixMappings) { throw null; }
        public System.Xml.XmlQualifiedName ParseTagName(string tagName, string ns) { throw null; }
        public void SendMessage(string message) { }
        public void SetGlobalValue(int index, object value) { }
        public void StartRtfConstruction(string baseUri, out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); }
        public void StartSequenceConstruction(out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); }
        public System.Xml.XPath.XPathNavigator TextRtfConstruction(string text, string baseUri) { throw null; }
        public void ThrowException(string text) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class XmlQuerySequence<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public static readonly System.Xml.Xsl.Runtime.XmlQuerySequence<T> Empty;
        public XmlQuerySequence() { }
        public XmlQuerySequence(int capacity) { }
        public XmlQuerySequence(T value) { }
        public XmlQuerySequence(T[] array, int size) { }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void Add(T value) { }
        public void Clear() { }
        public bool Contains(T value) { throw null; }
        public void CopyTo(T[] array, int index) { }
        public static System.Xml.Xsl.Runtime.XmlQuerySequence<T> CreateOrReuse(System.Xml.Xsl.Runtime.XmlQuerySequence<T> seq) { throw null; }
        public static System.Xml.Xsl.Runtime.XmlQuerySequence<T> CreateOrReuse(System.Xml.Xsl.Runtime.XmlQuerySequence<T> seq, T item) { throw null; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int IndexOf(T value) { throw null; }
        protected virtual void OnItemsChanged() { }
        public void SortByKeys(System.Array keys) { }
        void System.Collections.Generic.ICollection<T>.Add(T value) { }
        void System.Collections.Generic.ICollection<T>.Clear() { }
        bool System.Collections.Generic.ICollection<T>.Remove(T value) { throw null; }
        void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XmlSortKeyAccumulator
    {
        public System.Array Keys { get { throw null; } }
        public void AddDateTimeSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, System.DateTime value) { }
        public void AddDecimalSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, decimal value) { }
        public void AddDoubleSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, double value) { }
        public void AddEmptySortKey(System.Xml.Xsl.Runtime.XmlCollation collation) { }
        public void AddIntegerSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, long value) { }
        public void AddIntSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, int value) { }
        public void AddStringSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, string value) { }
        public void Create() { }
        public void FinishSortKeys() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XPathFollowingIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XPathFollowingMergeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XPathPrecedingDocOrderIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XPathPrecedingIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public bool MoveNext() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XPathPrecedingMergeIterator
    {
        public System.Xml.XPath.XPathNavigator Current { get { throw null; } }
        public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
        public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class XsltConvert
    {
        public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> EnsureNodeSet(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static bool ToBoolean(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static bool ToBoolean(System.Xml.XPath.XPathItem item) { throw null; }
        public static System.DateTime ToDateTime(string value) { throw null; }
        public static decimal ToDecimal(double value) { throw null; }
        public static double ToDouble(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static double ToDouble(decimal value) { throw null; }
        public static double ToDouble(int value) { throw null; }
        public static double ToDouble(long value) { throw null; }
        public static double ToDouble(string value) { throw null; }
        public static double ToDouble(System.Xml.XPath.XPathItem item) { throw null; }
        public static int ToInt(double value) { throw null; }
        public static long ToLong(double value) { throw null; }
        public static System.Xml.XPath.XPathNavigator ToNode(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static System.Xml.XPath.XPathNavigator ToNode(System.Xml.XPath.XPathItem item) { throw null; }
        public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> ToNodeSet(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> ToNodeSet(System.Xml.XPath.XPathItem item) { throw null; }
        public static string ToString(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { throw null; }
        public static string ToString(System.DateTime value) { throw null; }
        public static string ToString(double value) { throw null; }
        public static string ToString(System.Xml.XPath.XPathItem item) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class XsltFunctions
    {
        public static string BaseUri(System.Xml.XPath.XPathNavigator navigator) { throw null; }
        public static bool Contains(string s1, string s2) { throw null; }
        public static string EXslObjectType(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> value) { throw null; }
        public static bool Lang(string value, System.Xml.XPath.XPathNavigator context) { throw null; }
        public static string MSFormatDateTime(string dateTime, string format, string lang, bool isDate) { throw null; }
        public static string MSLocalName(string name) { throw null; }
        public static string MSNamespaceUri(string name, System.Xml.XPath.XPathNavigator currentNode) { throw null; }
        public static double MSNumber(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> value) { throw null; }
        public static double MSStringCompare(string s1, string s2, string lang, string options) { throw null; }
        public static string MSUtc(string dateTime) { throw null; }
        public static string NormalizeSpace(string value) { throw null; }
        public static string OuterXml(System.Xml.XPath.XPathNavigator navigator) { throw null; }
        public static double Round(double value) { throw null; }
        public static bool StartsWith(string s1, string s2) { throw null; }
        public static string Substring(string value, double startIndex) { throw null; }
        public static string Substring(string value, double startIndex, double length) { throw null; }
        public static string SubstringAfter(string s1, string s2) { throw null; }
        public static string SubstringBefore(string s1, string s2) { throw null; }
        public static System.Xml.XPath.XPathItem SystemProperty(System.Xml.XmlQualifiedName name) { throw null; }
        public static string Translate(string arg, string mapString, string transString) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class XsltLibrary
    {
        internal XsltLibrary() { }
        public int CheckScriptNamespace(string nsUri) { throw null; }
        public bool ElementAvailable(System.Xml.XmlQualifiedName name) { throw null; }
        public bool EqualityOperator(double opCode, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> left, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> right) { throw null; }
        public string FormatMessage(string res, System.Collections.Generic.IList<string> args) { throw null; }
        public string FormatNumberDynamic(double value, string formatPicture, System.Xml.XmlQualifiedName decimalFormatName, string errorMessageName) { throw null; }
        public string FormatNumberStatic(double value, double decimalFormatterIndex) { throw null; }
        public bool FunctionAvailable(System.Xml.XmlQualifiedName name) { throw null; }
        public bool IsSameNodeSort(System.Xml.XPath.XPathNavigator nav1, System.Xml.XPath.XPathNavigator nav2) { throw null; }
        public int LangToLcid(string lang, bool forwardCompatibility) { throw null; }
        public string NumberFormat(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> value, string formatString, double lang, string letterValue, string groupingSeparator, double groupingSize) { throw null; }
        public int RegisterDecimalFormat(System.Xml.XmlQualifiedName name, string infinitySymbol, string nanSymbol, string characters) { throw null; }
        public double RegisterDecimalFormatter(string formatPicture, string infinitySymbol, string nanSymbol, string characters) { throw null; }
        public bool RelationalOperator(double opCode, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> left, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> right) { throw null; }
    }
}
