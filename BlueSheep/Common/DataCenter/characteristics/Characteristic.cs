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
    public class Characteristic : IData
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
        
        public virtual string Keyword
        {
            get
            {
                return mKeyword;
            }
            set
            {
                mKeyword = value;
            }
        }
        
        private string mKeyword;
        
        public virtual uint NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private uint mNameId;
        
        public virtual string Asset
        {
            get
            {
                return mAsset;
            }
            set
            {
                mAsset = value;
            }
        }
        
        private string mAsset;
        
        public virtual int CategoryId
        {
            get
            {
                return mCategoryId;
            }
            set
            {
                mCategoryId = value;
            }
        }
        
        private int mCategoryId;
        
        public virtual bool Visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                mVisible = value;
            }
        }
        
        private bool mVisible;
        
        public virtual int Order
        {
            get
            {
                return mOrder;
            }
            set
            {
                mOrder = value;
            }
        }
        
        private int mOrder;
        
        public virtual bool Upgradable
        {
            get
            {
                return mUpgradable;
            }
            set
            {
                mUpgradable = value;
            }
        }
        
        private bool mUpgradable;
        
        public Characteristic()
        {
        }
    }
}
