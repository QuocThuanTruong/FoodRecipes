//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodRecipes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Igredient
    {
        public int ID_RECIPE { get; set; }
        public string NAME { get; set; }
        public string QUANTITY { get; set; }
    
        public virtual Recipe Recipe { get; set; }
    }
}
