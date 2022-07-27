using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository.Models
{
    [Table("AS_NORMATIVE_DOCS")]
    public partial class AsNormativeDocs
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
        [StringLength(20)]
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

        public static AsNormativeDocs GetAttributeValue(XmlElement item)
        {
            AsNormativeDocs asNormativeDocs = new AsNormativeDocs();

            asNormativeDocs.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asNormativeDocs.Name = item.Attributes.GetNamedItem("NAME").Value;
            asNormativeDocs.Date = DateTime.Parse(item.Attributes.GetNamedItem("DATE").Value);
            asNormativeDocs.Number = item.Attributes.GetNamedItem("NUMBER").Value;
            asNormativeDocs.Type = int.Parse(item.Attributes.GetNamedItem("TYPE").Value);
            asNormativeDocs.Kind = int.Parse(item.Attributes.GetNamedItem("KIND").Value);
            asNormativeDocs.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asNormativeDocs.Orgname = item.Attributes.GetNamedItem("ORGNAME").Value;
            asNormativeDocs.Regnum = item.Attributes.GetNamedItem("REGNUM").Value;

            if (item.HasAttribute("REGDATE"))
                asNormativeDocs.Regdate = DateTime.Parse(item.Attributes.GetNamedItem("REGDATE").Value);
            else
                asNormativeDocs.Regdate = null;

            if (item.HasAttribute("ACCDATE"))
                asNormativeDocs.Accdate = DateTime.Parse(item.Attributes.GetNamedItem("ACCDATE").Value);
            else
                asNormativeDocs.Accdate = null;

            asNormativeDocs.Comment = item.Attributes.GetNamedItem("COMMENT").Value;

            return asNormativeDocs;
        }
    }
}
