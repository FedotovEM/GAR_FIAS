using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Keyless]
    [Table("AS_ADM_HIERARCHY")]
    public partial class AsAdmHierarchy
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("PARENTOBJID")]
        public long? Parentobjid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("REGIONCODE")]
        [StringLength(4)]
        public string Regioncode { get; set; }
        [Column("AREACODE")]
        [StringLength(4)]
        public string Areacode { get; set; }
        [Column("CITYCODE")]
        [StringLength(4)]
        public string Citycode { get; set; }
        [Column("PLACECODE")]
        [StringLength(4)]
        public string Placecode { get; set; }
        [Column("PLANCODE")]
        [StringLength(4)]
        public string Plancode { get; set; }
        [Column("STREETCODE")]
        [StringLength(4)]
        public string Streetcode { get; set; }
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

        public static AsAdmHierarchy GetAttributeValue(XmlReader item)
        {
            AsAdmHierarchy asAdmHierarchy = new AsAdmHierarchy();

            item.MoveToAttribute("ID");
            asAdmHierarchy.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asAdmHierarchy.Objectid = long.Parse(item.Value);

            if (item.MoveToAttribute("PARENTOBJID"))
                asAdmHierarchy.Parentobjid = long.Parse(item.Value);
            else
                asAdmHierarchy.Parentobjid = null;

            item.MoveToAttribute("CHANGEID");
            asAdmHierarchy.Changeid = long.Parse(item.Value);

            if (item.MoveToAttribute("REGIONCODE"))
                asAdmHierarchy.Regioncode = item.Value;
            else
                asAdmHierarchy.Regioncode = null;

            if (item.MoveToAttribute("AREACODE"))
                asAdmHierarchy.Areacode = item.Value;
            else
                asAdmHierarchy.Areacode = null;

            if (item.MoveToAttribute("CITYCODE"))
                asAdmHierarchy.Citycode = item.Value;
            else
                asAdmHierarchy.Citycode = null;

            if (item.MoveToAttribute("PLACECODE"))
                asAdmHierarchy.Placecode = item.Value;
            else
                asAdmHierarchy.Placecode = null;

            if (item.MoveToAttribute("PLANCODE"))
                asAdmHierarchy.Plancode = item.Value;
            else
                asAdmHierarchy.Plancode = null;

            if (item.MoveToAttribute("STREETCODE"))
                asAdmHierarchy.Streetcode = item.Value;
            else
                asAdmHierarchy.Streetcode = null;

            if (item.MoveToAttribute("PREVID"))
                asAdmHierarchy.Previd = long.Parse(item.Value);
            else
                asAdmHierarchy.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asAdmHierarchy.Nextid = long.Parse(item.Value);
            else
                asAdmHierarchy.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asAdmHierarchy.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asAdmHierarchy.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asAdmHierarchy.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asAdmHierarchy.Isactive = true;
            else
                asAdmHierarchy.Isactive = false;

            item.MoveToAttribute("PATH");
            asAdmHierarchy.Path = item.Value;
            return asAdmHierarchy;
        }
    }
}
