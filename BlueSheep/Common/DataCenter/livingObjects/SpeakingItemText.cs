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
    public class SpeakingItemText : IData
    {
        
        public virtual int TextId
        {
            get
            {
                return mTextId;
            }
            set
            {
                mTextId = value;
            }
        }
        
        private int mTextId;
        
        public virtual double TextProba
        {
            get
            {
                return mTextProba;
            }
            set
            {
                mTextProba = value;
            }
        }
        
        private double mTextProba;
        
        public virtual uint TextStringId
        {
            get
            {
                return mTextStringId;
            }
            set
            {
                mTextStringId = value;
            }
        }
        
        private uint mTextStringId;
        
        public virtual int TextLevel
        {
            get
            {
                return mTextLevel;
            }
            set
            {
                mTextLevel = value;
            }
        }
        
        private int mTextLevel;
        
        public virtual int TextSound
        {
            get
            {
                return mTextSound;
            }
            set
            {
                mTextSound = value;
            }
        }
        
        private int mTextSound;
        
        public virtual string TextRestriction
        {
            get
            {
                return mTextRestriction;
            }
            set
            {
                mTextRestriction = value;
            }
        }
        
        private string mTextRestriction;
        
        public SpeakingItemText()
        {
        }
    }
}
