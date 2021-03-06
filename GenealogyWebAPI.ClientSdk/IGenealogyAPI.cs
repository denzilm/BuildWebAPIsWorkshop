// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace GenealogyWebAPI.ClientSdk
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Building Web APIs Workshop Demo Web API
    /// </summary>
    public partial interface IGenealogyAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IFamilyName.
        /// </summary>
        IFamilyName FamilyName { get; }

    }
}
