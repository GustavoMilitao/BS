//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.DataCenter
{
    using System;


    [Serializable()]
    public class Url : IData
    {
        
        public virtual int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private int mId;
        
        public virtual int BrowserId
        {
            get
            {
                return mBrowserId;
            }
            set
            {
                mBrowserId = value;
            }
        }
        
        private int mBrowserId;
        
        public virtual string Link
        {
            get
            {
                return mLink;
            }
            set
            {
                mLink = value;
            }
        }
        
        private string mLink;
        
        public virtual string Param
        {
            get
            {
                return mParam;
            }
            set
            {
                mParam = value;
            }
        }
        
        private string mParam;
        
        public virtual string Method
        {
            get
            {
                return mMethod;
            }
            set
            {
                mMethod = value;
            }
        }
        
        private string mMethod;
        
        public Url()
        {
        }
    }
}
