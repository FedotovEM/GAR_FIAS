using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_NORMATIVE_DOCS_TYPES")]
    public partial class AsNormativeDocsType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(500)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }

        public static AsNormativeDocsType GetAttributeValue(XmlReader item)
        {
            AsNormativeDocsType asNormativeDocsType = new AsNormativeDocsType();

            item.MoveToAttribute("ID");
            asNormativeDocsType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asNormativeDocsType.Name = item.Value;

            item.MoveToAttribute("STARTDATE");
            asNormativeDocsType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asNormativeDocsType.Enddate = DateTime.Parse(item.Value);

            return asNormativeDocsType;
        }
    }
}
