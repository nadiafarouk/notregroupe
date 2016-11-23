//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormaGroup
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evaluation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evaluation()
        {
            this.Note = new HashSet<Note>();
        }
    
        public int IdEvaluation { get; set; }
        public int IdSession { get; set; }
        public int IdModule { get; set; }
        public int IdFormateur { get; set; }
        public System.DateTime DateEffet { get; set; }
        public string Commentaire { get; set; }
    
        public virtual Formateur Formateur { get; set; }
        public virtual Module Module { get; set; }
        public virtual Session Session { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Note { get; set; }
    }
}