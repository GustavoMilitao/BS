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
    public class SmileyCategory : IData
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
        
        public virtual uint Order
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
        
        private uint mOrder;
        
        public virtual string GfxId
        {
            get
            {
                return mGfxId;
            }
            set
            {
                mGfxId = value;
            }
        }
        
        private string mGfxId;
        
        public virtual bool IsFake
        {
            get
            {
                return mIsFake;
            }
            set
            {
                mIsFake = value;
            }
        }
        
        private bool mIsFake;
        
        public SmileyCategory()
        {
        }
    }
}
