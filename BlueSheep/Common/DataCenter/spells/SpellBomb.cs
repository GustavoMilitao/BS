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
    public class SpellBomb : IData
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
        
        public virtual int ChainReactionSpellId
        {
            get
            {
                return mChainReactionSpellId;
            }
            set
            {
                mChainReactionSpellId = value;
            }
        }
        
        private int mChainReactionSpellId;
        
        public virtual int ExplodSpellId
        {
            get
            {
                return mExplodSpellId;
            }
            set
            {
                mExplodSpellId = value;
            }
        }
        
        private int mExplodSpellId;
        
        public virtual int WallId
        {
            get
            {
                return mWallId;
            }
            set
            {
                mWallId = value;
            }
        }
        
        private int mWallId;
        
        public virtual int InstantSpellId
        {
            get
            {
                return mInstantSpellId;
            }
            set
            {
                mInstantSpellId = value;
            }
        }
        
        private int mInstantSpellId;
        
        public virtual int ComboCoeff
        {
            get
            {
                return mComboCoeff;
            }
            set
            {
                mComboCoeff = value;
            }
        }
        
        private int mComboCoeff;
        
        public SpellBomb()
        {
        }
    }
}
