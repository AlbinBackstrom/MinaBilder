namespace MinaBilder3._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Images
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Titel { get; set; }

        [StringLength(50)]
        public string Kommentar { get; set; }

        [StringLength(50)]
        public string Path { get; set; }
    }
}
