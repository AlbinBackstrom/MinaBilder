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

        [Required(ErrorMessage = "Ange ett önskat användarnamn" )]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Ange ett lösenord")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [Compare("Password", ErrorMessage = "Lösenorden matchade inte. Prova igen")]
        public string ConfirmPassword { get; set; }

    }
}
