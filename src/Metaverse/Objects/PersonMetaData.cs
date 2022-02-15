﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TV.Metaverse
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Person meta data.
    /// </summary>
    // *** Start programmer edit section *** (PersonMetaData CustomAttributes)

    // *** End programmer edit section *** (PersonMetaData CustomAttributes)
    [AutoAltered()]
    [Caption("Person meta data")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("PersonMetaDataE", new string[] {
            "Url as \'Url\'",
            "DateTime as \'Date time\'",
            "DataType as \'Data type\'",
            "Author as \'Author\'",
            "Author.EsiaId as \'Esia id\'",
            "Person as \'Person\'",
            "Person.EsiaId as \'Esia id\'"}, Hidden=new string[] {
            "Author.EsiaId",
            "Person.EsiaId"})]
    [MasterViewDefineAttribute("PersonMetaDataE", "Author", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "EsiaId")]
    [MasterViewDefineAttribute("PersonMetaDataE", "Person", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "EsiaId")]
    [View("PersonMetaDataL", new string[] {
            "Url as \'Url\'",
            "DateTime as \'Date time\'",
            "DataType as \'Data type\'",
            "Author.EsiaId as \'Esia id\'",
            "Person.EsiaId as \'Esia id\'"})]
    public class PersonMetaData : ICSSoft.STORMNET.DataObject
    {
        
        private string fUrl;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fDateTime;
        
        private TV.Metaverse.DataType fDataType;
        
        private TV.Metaverse.Person fAuthor;
        
        private TV.Metaverse.Person fPerson;
        
        // *** Start programmer edit section *** (PersonMetaData CustomMembers)

        // *** End programmer edit section *** (PersonMetaData CustomMembers)

        
        /// <summary>
        /// Url.
        /// </summary>
        // *** Start programmer edit section *** (PersonMetaData.Url CustomAttributes)

        // *** End programmer edit section *** (PersonMetaData.Url CustomAttributes)
        [StrLen(255)]
        public virtual string Url
        {
            get
            {
                // *** Start programmer edit section *** (PersonMetaData.Url Get start)

                // *** End programmer edit section *** (PersonMetaData.Url Get start)
                string result = this.fUrl;
                // *** Start programmer edit section *** (PersonMetaData.Url Get end)

                // *** End programmer edit section *** (PersonMetaData.Url Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (PersonMetaData.Url Set start)

                // *** End programmer edit section *** (PersonMetaData.Url Set start)
                this.fUrl = value;
                // *** Start programmer edit section *** (PersonMetaData.Url Set end)

                // *** End programmer edit section *** (PersonMetaData.Url Set end)
            }
        }
        
        /// <summary>
        /// DateTime.
        /// </summary>
        // *** Start programmer edit section *** (PersonMetaData.DateTime CustomAttributes)

        // *** End programmer edit section *** (PersonMetaData.DateTime CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime DateTime
        {
            get
            {
                // *** Start programmer edit section *** (PersonMetaData.DateTime Get start)

                // *** End programmer edit section *** (PersonMetaData.DateTime Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fDateTime;
                // *** Start programmer edit section *** (PersonMetaData.DateTime Get end)

                // *** End programmer edit section *** (PersonMetaData.DateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (PersonMetaData.DateTime Set start)

                // *** End programmer edit section *** (PersonMetaData.DateTime Set start)
                this.fDateTime = value;
                // *** Start programmer edit section *** (PersonMetaData.DateTime Set end)

                // *** End programmer edit section *** (PersonMetaData.DateTime Set end)
            }
        }
        
        /// <summary>
        /// DataType.
        /// </summary>
        // *** Start programmer edit section *** (PersonMetaData.DataType CustomAttributes)

        // *** End programmer edit section *** (PersonMetaData.DataType CustomAttributes)
        public virtual TV.Metaverse.DataType DataType
        {
            get
            {
                // *** Start programmer edit section *** (PersonMetaData.DataType Get start)

                // *** End programmer edit section *** (PersonMetaData.DataType Get start)
                TV.Metaverse.DataType result = this.fDataType;
                // *** Start programmer edit section *** (PersonMetaData.DataType Get end)

                // *** End programmer edit section *** (PersonMetaData.DataType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (PersonMetaData.DataType Set start)

                // *** End programmer edit section *** (PersonMetaData.DataType Set start)
                this.fDataType = value;
                // *** Start programmer edit section *** (PersonMetaData.DataType Set end)

                // *** End programmer edit section *** (PersonMetaData.DataType Set end)
            }
        }
        
        /// <summary>
        /// Person meta data.
        /// </summary>
        // *** Start programmer edit section *** (PersonMetaData.Author CustomAttributes)

        // *** End programmer edit section *** (PersonMetaData.Author CustomAttributes)
        [PropertyStorage(new string[] {
                "Author"})]
        public virtual TV.Metaverse.Person Author
        {
            get
            {
                // *** Start programmer edit section *** (PersonMetaData.Author Get start)

                // *** End programmer edit section *** (PersonMetaData.Author Get start)
                TV.Metaverse.Person result = this.fAuthor;
                // *** Start programmer edit section *** (PersonMetaData.Author Get end)

                // *** End programmer edit section *** (PersonMetaData.Author Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (PersonMetaData.Author Set start)

                // *** End programmer edit section *** (PersonMetaData.Author Set start)
                this.fAuthor = value;
                // *** Start programmer edit section *** (PersonMetaData.Author Set end)

                // *** End programmer edit section *** (PersonMetaData.Author Set end)
            }
        }
        
        /// <summary>
        /// Person meta data.
        /// </summary>
        // *** Start programmer edit section *** (PersonMetaData.Person CustomAttributes)

        // *** End programmer edit section *** (PersonMetaData.Person CustomAttributes)
        [PropertyStorage(new string[] {
                "Person"})]
        public virtual TV.Metaverse.Person Person
        {
            get
            {
                // *** Start programmer edit section *** (PersonMetaData.Person Get start)

                // *** End programmer edit section *** (PersonMetaData.Person Get start)
                TV.Metaverse.Person result = this.fPerson;
                // *** Start programmer edit section *** (PersonMetaData.Person Get end)

                // *** End programmer edit section *** (PersonMetaData.Person Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (PersonMetaData.Person Set start)

                // *** End programmer edit section *** (PersonMetaData.Person Set start)
                this.fPerson = value;
                // *** Start programmer edit section *** (PersonMetaData.Person Set end)

                // *** End programmer edit section *** (PersonMetaData.Person Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "PersonMetaDataE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PersonMetaDataE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PersonMetaDataE", typeof(TV.Metaverse.PersonMetaData));
                }
            }
            
            /// <summary>
            /// "PersonMetaDataL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PersonMetaDataL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PersonMetaDataL", typeof(TV.Metaverse.PersonMetaData));
                }
            }
        }
    }
}
