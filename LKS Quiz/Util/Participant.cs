//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Quiz.Util
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Participant()
        {
            this.ParticipantAnswers = new HashSet<ParticipantAnswer>();
        }
    
        public int ID { get; set; }
        public int QuizID { get; set; }
        public string ParticipantNickname { get; set; }
        public System.DateTime ParticipationDate { get; set; }
        public int TimeTaken { get; set; }
    
        public virtual Quiz Quiz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipantAnswer> ParticipantAnswers { get; set; }
    }
}
