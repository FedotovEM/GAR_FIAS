using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_NORMATIVE_DOCS_KINDS")]
    public partial class AsNormativeDocsKind
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(500)]
        [Unicode(false)]
        public string Name { get; set; }

        public static AsNormativeDocsKind GetAttributeValue(XmlReader item)
        {
            AsNormativeDocsKind asNormativeDocsKind = new AsNormativeDocsKind();

            item.MoveToAttribute("ID");
            asNormativeDocsKind.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asNormativeDocsKind.Name = item.Value;

            return asNormativeDocsKind;
        }
    }
}
