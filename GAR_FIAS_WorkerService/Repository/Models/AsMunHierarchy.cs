using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_MUN_HIERARCHY")]
    public partial class AsMunHierarchy
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("PARENTOBJID")]
        public long? Parentobjid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Required]
        [Column("OKTMO")]
        [StringLength(11)]
        public string Oktmo { get; set; }
        [Column("PREVID")]
        public long? Previd { get; set; }
        [Column("NEXTID")]
        public long? Nextid { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }
        [Required]
        [Column("PATH", TypeName = "text")]
        public string Path { get; set; }

        public static AsMunHierarchy GetAttributeValue(XmlReader item)
        {
            AsMunHierarchy asMunHierarchy = new AsMunHierarchy();

            item.MoveToAttribute("ID");
            asMunHierarchy.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asMunHierarchy.Objectid = long.Parse(item.Value);

            if (item.MoveToAttribute("PARENTOBJID"))
                asMunHierarchy.Parentobjid = long.Parse(item.Value);
            else
                asMunHierarchy.Parentobjid = null;

            item.MoveToAttribute("CHANGEID");
            asMunHierarchy.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("OKTMO");
            asMunHierarchy.Oktmo = item.Value;

            if (item.MoveToAttribute("PREVID"))
                asMunHierarchy.Previd = long.Parse(item.Value);
            else
                asMunHierarchy.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asMunHierarchy.Nextid = long.Parse(item.Value);
            else
                asMunHierarchy.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asMunHierarchy.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asMunHierarchy.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asMunHierarchy.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asMunHierarchy.Isactive = true;
            else
                asMunHierarchy.Isactive = false;

            item.MoveToAttribute("PATH");
            asMunHierarchy.Path = item.Value;

            return asMunHierarchy;
        }
    }
}
