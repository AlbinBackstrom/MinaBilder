namespace MinaBilder3._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ange ett �nskat anv�ndarnamn" )]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Ange ett l�senord")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [Compare("Password", ErrorMessage = "L�senorden matchade inte. Prova igen")]
        public string ConfirmPassword { get; set; }

    }
}
