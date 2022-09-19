using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_NORMATIVE_DOCS")]
    public partial class AsNormativeDoc
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(8000)]
        public string Name { get; set; }
        [Column("DATE", TypeName = "date")]
        public DateTime Date { get; set; }
        [Required]
        [Column("NUMBER")]
        [StringLength(50)]
        public string Number { get; set; }
        [Column("TYPE")]
        public int Type { get; set; }
        [Column("KIND")]
        public int Kind { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("ORGNAME")]
        [StringLength(255)]
        public string Orgname { get; set; }
        [Column("REGNUM")]
        [StringLength(100)]
        public string Regnum { get; set; }
        [Column("REGDATE", TypeName = "date")]
        public DateTime? Regdate { get; set; }
        [Column("ACCDATE", TypeName = "date")]
        public DateTime? Accdate { get; set; }
        [Column("COMMENT")]
        [StringLength(8000)]
        public string Comment { get; set; }

        public static AsNormativeDoc GetAttributeValue(XmlReader item)
        {
            AsNormativeDoc asNormativeDocs = new AsNormativeDoc();

            item.MoveToAttribute("ID");
            asNormativeDocs.Id = long.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asNormativeDocs.Name = item.Value;
            item.MoveToAttribute("DATE");
            asNormativeDocs.Date = DateTime.Parse(item.Value);
            item.MoveToAttribute("NUMBER");
            asNormativeDocs.Number = item.Value;
            item.MoveToAttribute("TYPE");
            asNormativeDocs.Type = int.Parse(item.Value);
            item.MoveToAttribute("KIND");
            asNormativeDocs.Kind = int.Parse(item.Value);
            item.MoveToAttribute("UPDATEDATE");
            asNormativeDocs.Updatedate = DateTime.Parse(item.Value);

            if (item.MoveToAttribute("ORGNAME"))
                asNormativeDocs.Orgname = item.Value;
            else
                asNormativeDocs.Orgname = null;

            if (item.MoveToAttribute("REGNUM"))
                asNormativeDocs.Regnum = item.Value;
            else
                asNormativeDocs.Regnum = null;

            if (item.MoveToAttribute("REGDATE"))
                asNormativeDocs.Regdate = DateTime.Parse(item.Value);
            else
                asNormativeDocs.Regdate = null;

            if (item.MoveToAttribute("ACCDATE"))
                asNormativeDocs.Accdate = DateTime.Parse(item.Value);
            else
                asNormativeDocs.Accdate = null;

            if (item.MoveToAttribute("COMMENT"))
                asNormativeDocs.Comment = item.Value;
            else
                asNormativeDocs.Comment = null;

            return asNormativeDocs;
        }
    }
}
